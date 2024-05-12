using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManager
{
    public partial class Form1 : Form
    {
        private School _context;
        private BindingSource _bindingSource = new BindingSource();
        private System.Threading.Timer threadingTimer;

        public Form1()
        {
            InitializeComponent();
            FormClosing += Form1_FormClosing;
        }
        private void StartThreadingTimer()
        {
            TimerCallback timerCallback = new TimerCallback(TimerTask);

            Thread.Sleep(1000);
            threadingTimer = new System.Threading.Timer(timerCallback, null, 0, 10000);
            
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            _context = new School();
            _context.Students.Load();
            _context.Subjects.Load();
            _context.Attendance.Load();
            _context.Grades.Load();
            _bindingSource.DataSource = _context.Students.Local.ToBindingList();
            dataGridView1.DataSource = _bindingSource;
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["AverageGrade"].DefaultCellStyle.Format = "N2";
            dataGridView1.Columns["Attendance"].DefaultCellStyle.Format = "N2";
            StartThreadingTimer();
        }

        private async void TimerTask(object state)
        {
            if (this.IsDisposed || !this.IsHandleCreated)
                return;

            try
            {
                var updatedData = await Task.Run(async () => await UpdateStudentMetricsAsync());

                this.Invoke((MethodInvoker)delegate
                {
                    foreach (var item in updatedData)
                    {
                        var student = _context.Students.FirstOrDefault(s => s.Id == item.studentId);
                        if (student != null)
                        {
                            student.Attendance = item.attendanceRate;
                            student.AverageGrade = item.averageGrade;
                        }
                    }
                    _context.SaveChanges();
                    _bindingSource.ResetBindings(false);
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to update student metrics: " + ex.Message);
            }
        }

        public async Task<List<(int studentId, decimal attendanceRate, decimal averageGrade)>> UpdateStudentMetricsAsync()
        {
            var studentIds = await _context.Students.Select(s => s.Id).ToListAsync();
            var tasks = studentIds.Select(id => CalculateStudentMetricsAsync(id));
            var resultsArray = await Task.WhenAll(tasks);
            return resultsArray.ToList();
        }

        private async Task<(int studentId, decimal attendanceRate, decimal averageGrade)> CalculateStudentMetricsAsync(int studentId)
        {
            using (var context = new School())
            {
                var totalAttendances = await context.Attendance
                    .Where(a => a.Student.Id == studentId)
                    .CountAsync();

                var positiveAttendances = await context.Attendance
                    .Where(a => a.Student.Id == studentId && a.IsPresent)
                    .CountAsync();

                var grades = await context.Grades
                    .Where(g => g.Student.Id == studentId)
                    .ToListAsync();

                decimal attendanceRate = totalAttendances > 0 ? (decimal)positiveAttendances / totalAttendances : 0;
                decimal averageGrade = grades.Any() ? (decimal)grades.Average(g => g.GradeValue) : 0;

                return (studentId, attendanceRate, averageGrade);
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _context.SaveChanges();
            _context.Dispose();
            StopThreadingTimer();
        }

        private void StopThreadingTimer()
        {
            threadingTimer?.Change(Timeout.Infinite, 0);
            threadingTimer?.Dispose();
        }

        private void AddAttendanceButton_Click(object sender, EventArgs e)
        {
            var addAttendance = new AddAttendance();
            addAttendance.Students = _context.Students.ToList();
            addAttendance.Subjects = _context.Subjects.ToList();
            if(addAttendance.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Attendandance was successfuly added");
                _context.Attendance.Add(addAttendance.NewAttendance);
                _context.SaveChanges();
                _bindingSource.ResetBindings(false);
            }
        }

        private void EditAttendanceButton_Click(object sender, EventArgs e)
        {
            var attendanceForm = new EditAttendanceForm(_context);
            if (attendanceForm.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Attendandance was successfuly updated");
                foreach (var attendance in attendanceForm.ChangedAttendance)
                {
                    if (attendance.Id == 0)
                    {
                        _context.Attendance.Add(attendance);
                    }
                    else
                    {
                        var existingAttendance = _context.Attendance.Find(attendance.Id);
                        _context.Entry(existingAttendance).CurrentValues.SetValues(attendance);
                    }
                }

                _context.SaveChanges();
            }
        }

        private void AddGradeButton_Click(object sender, EventArgs e)
        {
            var addGrade = new AddGradeForm();
            addGrade.Students = _context.Students.ToList();
            addGrade.Subjects = _context.Subjects.ToList();
            if (addGrade.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Grade was successfuly added");
                _context.Grades.Add(addGrade.NewGrade);
                _context.SaveChanges();
                _bindingSource.ResetBindings(false);
            }
        }

        private void EditGradeButton_Click(object sender, EventArgs e)
        {
            var editGrades = new EditGradesForm(_context);
            if(editGrades.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Grades were successfuly updated");
                foreach (var grade in editGrades.ChangedGrades)
                {
                    if (grade.Id == 0)
                    {
                        _context.Grades.Add(grade);
                    }
                    else
                    {
                        var existingGrade = _context.Grades.Find(grade.Id);
                        _context.Entry(existingGrade).CurrentValues.SetValues(grade);
                    }
                }

                _context.SaveChanges();
            }
        }

        private void AddStudentButton_Click(object sender, EventArgs e)
        {
            var addStudent = new AddStudent();
            if(addStudent.ShowDialog() == DialogResult.OK)
            {
                _context.Students.Add(addStudent.student);
                MessageBox.Show("Student was successfuly added");
                _context.SaveChanges();
            }
        }

        private void EditStudentsButton_Click(object sender, EventArgs e)
        {
            var editStudents = new EditStudentsForm(_context);
            if (editStudents.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Students were successfuly updated");
                foreach (var student in editStudents.ChangedStudents)
                {
                    if (student.Id == 0)
                    {
                        _context.Students.Add(student);
                    }
                    else
                    {
                        var existingStudent = _context.Students.Find(student.Id);
                        _context.Entry(existingStudent).CurrentValues.SetValues(student);
                    }
                }

                _context.SaveChanges();
            }
        }
    }
}
