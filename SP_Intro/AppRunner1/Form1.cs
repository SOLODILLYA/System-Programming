using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppRunner1
{
    public partial class Form1 : Form
    {
        private string _exePath;
        private string _controlParam;
        private Process _targetProcess;

        private readonly Model1 _dbManager;
        private List<ConPath> _conPaths;
        public Form1()
        {
            InitializeComponent();
            _dbManager = new Model1();
            _conPaths = new List<ConPath>();
        }
        private void StartButton_Click(object sender, EventArgs e)
        {
            _controlParam = ControlParamField.Text;        
            if (string.IsNullOrWhiteSpace(_exePath))
            {
                MessageBox.Show("No path to program was entered");
            }
            else
            {
                _targetProcess = new Process();
                if (!string.IsNullOrWhiteSpace(_controlParam)) 
                {
                    _targetProcess.StartInfo = new ProcessStartInfo(_exePath);
                }
                else
                {
                    _targetProcess.StartInfo = new ProcessStartInfo(_exePath, _controlParam);
                }
                _targetProcess.Start();
            }
        }


        private void EndButton_Click_1(object sender, EventArgs e)
        {
            //_targetProcess.CloseMainWindow();
            //_targetProcess.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdatePaths();
        }

        private void PathsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _exePath = (PathsComboBox.SelectedItem as ConPath).PathString;
        }

        private void AddPathsButton_Click(object sender, EventArgs e)
        {
            var addPath = new AddPathForm();
            if(addPath.ShowDialog() == DialogResult.OK)
            {
                _dbManager.ConPaths.Add(addPath.NewPath);
                _dbManager.SaveChanges();
                MessageBox.Show("Application was added successfuly");
                UpdatePaths();
            }
        }

        private void EditPathsButton_Click(object sender, EventArgs e)
        {
            var editApp = new EditApplicationForm();
            editApp.conPaths = _conPaths;
            if(editApp.ShowDialog() == DialogResult.OK)
            {
                var entityToUpdate = _dbManager.ConPaths.FirstOrDefault(p => p.Id == editApp.editedConPath.Id);

                if (entityToUpdate != null)
                {
                    entityToUpdate.Name = editApp.editedConPath.Name;
                    entityToUpdate.PathString = editApp.editedConPath.PathString;
                    _dbManager.SaveChanges();
                    MessageBox.Show("Application was edited successfuly");
                    UpdatePaths();
                }
            }
        }

        private void DeletePathsButton_Click(object sender, EventArgs e)
        {
            var deleteApp = new DeleteApplicationForm();
            deleteApp.conPaths = _conPaths;
            if(deleteApp.ShowDialog() == DialogResult.OK)
            {
                _dbManager.ConPaths.Remove(deleteApp.deleteConPath);
                _dbManager.SaveChanges();
                MessageBox.Show("Application was deleted successfuly");
                UpdatePaths();
            }
        }

        private void UpdatePaths()
        {
            _conPaths = _dbManager.ConPaths.ToList();
            PathsComboBox.DataSource = _conPaths;
            PathsComboBox.DisplayMember = "Name";
            PathsComboBox.SelectedIndex = 0;
        }
    }
}
