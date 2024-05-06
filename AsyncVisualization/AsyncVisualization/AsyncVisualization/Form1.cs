using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics.Eventing.Reader;

namespace AsyncVisualization
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OperationAsync1(int id, int n, int d)
        {
            //1
            StartOperation1.Enabled = false;
            textBox1.Text = $"Operation No{id} - set to execution in pool.\r\n";
            Thread.Sleep(d);
            progressBar1.Maximum = n;

            //2
            int counter = 0;
            for(int i = 0; i < n; i++)
            {
                counter = i + 1;
                textBox1.Text += $"Thread No{Thread.CurrentThread.ManagedThreadId}: operation No {counter} / {n}\r\n";
                progressBar1.Value++;
                Thread.Sleep(d);
            }

            //3
            textBox1.Text = $"Operation No{id} - ended successfuly!\r\n";
            textBox1.Text += $"Operations count - {counter} / {n}\r\n";
            textBox1.Text += $"Time spent - {(counter * d / 1000):f} seconds.\r\n";

            StartOperation1.Enabled = true;
        }
        private void OperationAsync2(int id, int n, int d)
        {
            //1
            StartOperation2.Enabled = false;
            textBox2.Text = $"Operation No{id} - set to execution in pool.\r\n";
            Thread.Sleep(d);
            progressBar2.Maximum = n;

            //2
            int counter = 0;
            for (int i = 0; i < n; i++)
            {
                counter = i + 1;
                textBox2.Text += $"Thread No{Thread.CurrentThread.ManagedThreadId}: operation No {counter} / {n}\r\n";
                progressBar2.Value++;
                Thread.Sleep(d);
            }

            //3
            textBox2.Text = $"Operation No{id} - ended successfuly!\r\n";
            textBox2.Text += $"Operations count - {counter} / {n}\r\n";
            textBox2.Text += $"Time spent - {(counter * d / 1000):f} seconds.\r\n";

            StartOperation2.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void StartOperation1_Click(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                OperationAsync1(1, 25, 500);
            });
        }

        private async void StartOperation2_Click(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                OperationAsync2(2, 15, 400);
            });
        }

        private void ResetOperations_Click(object sender, EventArgs e)
        {
            if(StartOperation1.Enabled && StartOperation2.Enabled)
            {
                textBox1.Clear();
                textBox2.Clear();
                progressBar1.Value = 0;
                progressBar2.Value = 0;

            }
            else
            {
                MessageBox.Show("Operation is unavailable until end of all operations", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
