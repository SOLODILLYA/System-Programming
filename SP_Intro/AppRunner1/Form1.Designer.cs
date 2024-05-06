namespace AppRunner1
{
    partial class Form1
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
            this.EndButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.ControlParamField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PathsComboBox = new System.Windows.Forms.ComboBox();
            this.EditPathsButton = new System.Windows.Forms.Button();
            this.AddPathsButton = new System.Windows.Forms.Button();
            this.DeletePathsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EndButton
            // 
            this.EndButton.Location = new System.Drawing.Point(238, 110);
            this.EndButton.Name = "EndButton";
            this.EndButton.Size = new System.Drawing.Size(114, 46);
            this.EndButton.TabIndex = 11;
            this.EndButton.Text = "End";
            this.EndButton.UseVisualStyleBackColor = true;
            this.EndButton.Click += new System.EventHandler(this.EndButton_Click_1);
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(82, 110);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(114, 46);
            this.StartButton.TabIndex = 10;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // ControlParamField
            // 
            this.ControlParamField.Location = new System.Drawing.Point(12, 69);
            this.ControlParamField.Name = "ControlParamField";
            this.ControlParamField.Size = new System.Drawing.Size(434, 20);
            this.ControlParamField.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Controlling Parameter:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Application Path:";
            // 
            // PathsComboBox
            // 
            this.PathsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PathsComboBox.FormattingEnabled = true;
            this.PathsComboBox.Location = new System.Drawing.Point(15, 26);
            this.PathsComboBox.Name = "PathsComboBox";
            this.PathsComboBox.Size = new System.Drawing.Size(430, 21);
            this.PathsComboBox.TabIndex = 12;
            this.PathsComboBox.SelectedIndexChanged += new System.EventHandler(this.PathsComboBox_SelectedIndexChanged);
            // 
            // EditPathsButton
            // 
            this.EditPathsButton.Location = new System.Drawing.Point(166, 166);
            this.EditPathsButton.Name = "EditPathsButton";
            this.EditPathsButton.Size = new System.Drawing.Size(114, 46);
            this.EditPathsButton.TabIndex = 13;
            this.EditPathsButton.Text = "Edit Application";
            this.EditPathsButton.UseVisualStyleBackColor = true;
            this.EditPathsButton.Click += new System.EventHandler(this.EditPathsButton_Click);
            // 
            // AddPathsButton
            // 
            this.AddPathsButton.Location = new System.Drawing.Point(46, 166);
            this.AddPathsButton.Name = "AddPathsButton";
            this.AddPathsButton.Size = new System.Drawing.Size(114, 46);
            this.AddPathsButton.TabIndex = 14;
            this.AddPathsButton.Text = "Add Application";
            this.AddPathsButton.UseVisualStyleBackColor = true;
            this.AddPathsButton.Click += new System.EventHandler(this.AddPathsButton_Click);
            // 
            // DeletePathsButton
            // 
            this.DeletePathsButton.Location = new System.Drawing.Point(286, 166);
            this.DeletePathsButton.Name = "DeletePathsButton";
            this.DeletePathsButton.Size = new System.Drawing.Size(114, 46);
            this.DeletePathsButton.TabIndex = 15;
            this.DeletePathsButton.Text = "Delete Application";
            this.DeletePathsButton.UseVisualStyleBackColor = true;
            this.DeletePathsButton.Click += new System.EventHandler(this.DeletePathsButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 224);
            this.Controls.Add(this.DeletePathsButton);
            this.Controls.Add(this.AddPathsButton);
            this.Controls.Add(this.EditPathsButton);
            this.Controls.Add(this.PathsComboBox);
            this.Controls.Add(this.EndButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.ControlParamField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EndButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.TextBox ControlParamField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox PathsComboBox;
        private System.Windows.Forms.Button EditPathsButton;
        private System.Windows.Forms.Button AddPathsButton;
        private System.Windows.Forms.Button DeletePathsButton;
    }
}

