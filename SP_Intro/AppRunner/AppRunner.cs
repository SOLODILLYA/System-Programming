using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace AppRunner
{
    public partial class AppRunner : Form
    {
        private string _exePath;
        private string _controlParam;
        private Process _targetProcess;
        public AppRunner()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            _exePath = ExePathField.Text;
            _controlParam = ControlParamField.Text;

            if (string.IsNullOrWhiteSpace(_exePath))
            {
                MessageBox.Show("No path to program was entered");
            }
            else
            {
                _targetProcess = new Process();
                _targetProcess.StartInfo = new ProcessStartInfo(_exePath);
                _targetProcess.Start();
            }
        }

        private void EndButton_Click(object sender, EventArgs e)
        {
            _targetProcess.CloseMainWindow();
            _targetProcess.Start();
        }
    }
}
