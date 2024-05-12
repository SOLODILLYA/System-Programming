using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManager
{
    public partial class AddAttendance : Form
    {
        public Attendance NewAttendance;
        public List<Student> Students;
        public List<Subject> Subjects;
        public AddAttendance()
        {
            InitializeComponent();
        }

        private void AddAttendance_Load(object sender, EventArgs e)
        {
            StudentComboBox.Items.Clear();
            StudentComboBox.DataSource = Students;
            StudentComboBox.DisplayMember = "Name";
            if(StudentComboBox.Items.Count > 0)
            {
                StudentComboBox.SelectedIndex = 0;
            }
            SubjectComboBox.DataSource = Subjects;
            SubjectComboBox.DisplayMember = "SubjectName";
            if(SubjectComboBox.Items. Count > 0)
            {
                SubjectComboBox.SelectedIndex = 0;
            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            NewAttendance = new Attendance()
            {
                Id = 0,
                Student = StudentComboBox.SelectedItem as Student,
                Subject = SubjectComboBox.SelectedItem as Subject,
                IsPresent = checkBox1.Checked,
            };
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
