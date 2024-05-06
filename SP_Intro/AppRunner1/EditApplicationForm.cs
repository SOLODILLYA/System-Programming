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
    public partial class EditApplicationForm : Form
    {
        public List<ConPath> conPaths { get; set; }
        public ConPath editedConPath { get; set; }
        public EditApplicationForm()
        {
            InitializeComponent();
        }

        private void EditApplicationForm_Load(object sender, EventArgs e)
        {
            UpdatePaths();
        }
        private void UpdatePaths()
        {
            PathsComboBox.DataSource = conPaths;
            PathsComboBox.DisplayMember = "Name";
            PathsComboBox.SelectedIndex = 0;
        }

        private void PathsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            NameText.Text = (PathsComboBox.SelectedItem as ConPath).Name;
            PathText.Text = (PathsComboBox.SelectedItem as ConPath).PathString;
        }

        private void AddPathButton_Click(object sender, EventArgs e)
        {
            editedConPath = new ConPath()
            {
                Id = (PathsComboBox.SelectedItem as ConPath).Id,
                Name = NameText.Text,
                PathString = PathText.Text
            };
            this.DialogResult = DialogResult.OK;
        }
    }
}
