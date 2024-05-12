using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManager
{
    public partial class EditAttendanceForm : Form
    {

        private School _context;
        private BindingSource _bindingSource = new BindingSource();
        private System.Threading.Timer threadingTimer;
        public ObservableCollection<Attendance> ChangedAttendance;
        public EditAttendanceForm(School context)
        {
            InitializeComponent();
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            _context = context;
        }
        private void StartThreadingTimer()
        {
            TimerCallback timerCallback = new TimerCallback(TimerTask);
            threadingTimer = new System.Threading.Timer(timerCallback, null, 0, 10000);

        }
        private void AddAttendanceForm_Load(object sender, EventArgs e)
        {
            _context.Attendance.Include(a => a.Student).Include(a => a.Subject).Load();
            _bindingSource.DataSource = _context.Attendance.Local.ToBindingList();
            dataGridView1.DataSource = _bindingSource;
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["Student"].Visible = false;
            dataGridView1.Columns["Subject"].Visible = false;
            ConfigureDataGridViewColumns();
            StartThreadingTimer();
        }

        private async void TimerTask(object state)
        {
            if (this.IsDisposed || !this.IsHandleCreated)
                return;

            try
            {
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to update attendance: " + ex.Message);
            }
        }

        private void ConfigureDataGridViewColumns()
        {
            if (!dataGridView1.Columns.Contains("StudentName"))
            {
                DataGridViewTextBoxColumn studentNameColumn = new DataGridViewTextBoxColumn();
                studentNameColumn.Name = "StudentName";
                studentNameColumn.HeaderText = "Student Name";
                studentNameColumn.DataPropertyName = "StudentName"; 
                dataGridView1.Columns.Add(studentNameColumn);
                dataGridView1.Columns["StudentName"].ReadOnly = true;
            }

            if (!dataGridView1.Columns.Contains("SubjectName"))
            {
                DataGridViewTextBoxColumn subjectNameColumn = new DataGridViewTextBoxColumn();
                subjectNameColumn.Name = "SubjectName";
                subjectNameColumn.HeaderText = "Subject Name";
                subjectNameColumn.DataPropertyName = "SubjectName";
                dataGridView1.Columns.Add(subjectNameColumn);
                dataGridView1.Columns["SubjectName"].ReadOnly = true;
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "StudentName" && e.RowIndex >= 0)
            {
                Attendance attendance = dataGridView1.Rows[e.RowIndex].DataBoundItem as Attendance;
                if (attendance != null && attendance.Student != null)
                {
                    e.Value = attendance.Student.Name;
                }
            }
            if (dataGridView1.Columns[e.ColumnIndex].Name == "SubjectName" && e.RowIndex >= 0)
            {
                Attendance attendance = dataGridView1.Rows[e.RowIndex].DataBoundItem as Attendance;
                if (attendance != null && attendance.Subject != null)
                {
                    e.Value = attendance.Subject.SubjectName;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            ChangedAttendance = _context.Attendance.Local;
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
