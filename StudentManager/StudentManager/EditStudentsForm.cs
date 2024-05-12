using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManager
{
    public partial class EditStudentsForm : Form
    {
        private School _context;
        private BindingSource _bindingSource = new BindingSource();
        private System.Threading.Timer threadingTimer;
        public ObservableCollection<Student> ChangedStudents;
        public EditStudentsForm(School context)
        {
            InitializeComponent();
            _context = context;
        }

        private void EditStudentsForm_Load(object sender, EventArgs e)
        {
            _bindingSource.DataSource = _context.Students.Local.ToBindingList();
            dataGridView1.DataSource = _bindingSource;
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["AverageGrade"].Visible = false;
            dataGridView1.Columns["Attendance"].Visible = false;
            StartThreadingTimer();
        }

        private void StartThreadingTimer()
        {
            TimerCallback timerCallback = new TimerCallback(TimerTask);
            threadingTimer = new System.Threading.Timer(timerCallback, null, 0, 10000);
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
                MessageBox.Show("Failed to update grades: " + ex.Message);
            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            _context.SaveChanges();
            ChangedStudents = _context.Students.Local;
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.Cancel;
            this.Close();
        }
    }
}
