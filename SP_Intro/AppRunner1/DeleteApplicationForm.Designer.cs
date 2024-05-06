namespace AppRunner1
{
    partial class DeleteApplicationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PathsComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AddPathButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PathsComboBox
            // 
            this.PathsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PathsComboBox.FormattingEnabled = true;
            this.PathsComboBox.Location = new System.Drawing.Point(11, 24);
            this.PathsComboBox.Name = "PathsComboBox";
            this.PathsComboBox.Size = new System.Drawing.Size(430, 21);
            this.PathsComboBox.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Application:";
            // 
            // AddPathButton
            // 
            this.AddPathButton.Location = new System.Drawing.Point(182, 63);
            this.AddPathButton.Name = "AddPathButton";
            this.AddPathButton.Size = new System.Drawing.Size(111, 46);
            this.AddPathButton.TabIndex = 25;
            this.AddPathButton.Text = "Delete Application";
            this.AddPathButton.UseVisualStyleBackColor = true;
            this.AddPathButton.Click += new System.EventHandler(this.AddPathButton_Click);
            // 
            // DeleteApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 123);
            this.Controls.Add(this.PathsComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AddPathButton);
            this.Name = "DeleteApplicationForm";
            this.Text = "DeleteApplicationForm";
            this.Load += new System.EventHandler(this.DeleteApplicationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox PathsComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddPathButton;
    }
}