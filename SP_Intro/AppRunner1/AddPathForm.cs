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
    public partial class AddPathForm : Form
    {
        public ConPath NewPath { get; set; }
        public AddPathForm()
        {
            InitializeComponent();
        }

        private void AddPathButton_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(NameText.Text) || string.IsNullOrWhiteSpace(PathText.Text))
            {
                MessageBox.Show("You have not entered all data");
            }
            else
            {
                NewPath = new ConPath()
                {
                    Id = 0,
                    Name = NameText.Text,
                    PathString = PathText.Text,
                };
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
