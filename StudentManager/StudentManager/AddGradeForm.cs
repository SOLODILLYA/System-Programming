using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace StudentManager
{
    public partial class AddGradeForm : Form
    {
        public List<Student> Students;
        public List<Subject> Subjects;
        public Grade NewGrade;
        public AddGradeForm()
        {
            InitializeComponent();
        }

        private void AddGradeForm_Load(object sender, EventArgs e)
        {
            StudentComboBox.Items.Clear();
            StudentComboBox.DataSource = Students;
            StudentComboBox.DisplayMember = "Name";
            if (StudentComboBox.Items.Count > 0)
            {
                StudentComboBox.SelectedIndex = 0;
            }
            SubjectComboBox.DataSource = Subjects;
            SubjectComboBox.DisplayMember = "SubjectName";
            if (SubjectComboBox.Items.Count > 0)
            {
                SubjectComboBox.SelectedIndex = 0;
            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            try
            {
                int grade = int.Parse(GradeTextBox.Text);
                if (grade > 0 && grade < 13)
                {
                    NewGrade = new Grade()
                    {
                        Id = 0,
                        Student = StudentComboBox.SelectedItem as Student,
                        Subject = SubjectComboBox.SelectedItem as Subject,
                        GradeValue = grade,
                    };
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Please enter grade between 1 and 12");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Please enter number in grade field");
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
