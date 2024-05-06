using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppRunner1
{
    public partial class DeleteApplicationForm : Form
    {
        public List<ConPath> conPaths { get; set; }
        public ConPath deleteConPath { get; set; }
        public DeleteApplicationForm()
        {
            InitializeComponent();
        }

        private void AddPathButton_Click(object sender, EventArgs e)
        {
            deleteConPath = (PathsComboBox.SelectedItem as ConPath);
            this.DialogResult = DialogResult.OK;
        }

        private void DeleteApplicationForm_Load(object sender, EventArgs e)
        {
            UpdatePaths();
        }
        private void UpdatePaths()
        {
            PathsComboBox.DataSource = conPaths;
            PathsComboBox.DisplayMember = "Name";
            PathsComboBox.SelectedIndex = 0;
        }
    }
}
