namespace AppRunner1
{
    partial class EditApplicationForm
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
            this.AddPathButton = new System.Windows.Forms.Button();
            this.NameText = new System.Windows.Forms.TextBox();
            this.PathText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PathsComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddPathButton
            // 
            this.AddPathButton.Location = new System.Drawing.Point(166, 149);
            this.AddPathButton.Name = "AddPathButton";
            this.AddPathButton.Size = new System.Drawing.Size(111, 46);
            this.AddPathButton.TabIndex = 22;
            this.AddPathButton.Text = "Edit Application";
            this.AddPathButton.UseVisualStyleBackColor = true;
            this.AddPathButton.Click += new System.EventHandler(this.AddPathButton_Click);
            // 
            // NameText
            // 
            this.NameText.Location = new System.Drawing.Point(12, 67);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(431, 20);
            this.NameText.TabIndex = 21;
            // 
            // PathText
            // 
            this.PathText.Location = new System.Drawing.Point(9, 111);
            this.PathText.Name = "PathText";
            this.PathText.Size = new System.Drawing.Size(434, 20);
            this.PathText.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Application Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Application Path:";
            // 
            // PathsComboBox
            // 
            this.PathsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PathsComboBox.FormattingEnabled = true;
            this.PathsComboBox.Location = new System.Drawing.Point(9, 27);
            this.PathsComboBox.Name = "PathsComboBox";
            this.PathsComboBox.Size = new System.Drawing.Size(430, 21);
            this.PathsComboBox.TabIndex = 24;
            this.PathsComboBox.SelectedIndexChanged += new System.EventHandler(this.PathsComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Application:";
            // 
            // EditApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 208);
            this.Controls.Add(this.PathsComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AddPathButton);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.PathText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditApplicationForm";
            this.Text = "EditApplicationForm";
            this.Load += new System.EventHandler(this.EditApplicationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddPathButton;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.TextBox PathText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox PathsComboBox;
        private System.Windows.Forms.Label label3;
    }
}