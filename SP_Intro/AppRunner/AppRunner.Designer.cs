namespace AppRunner
{
    partial class AppRunner
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
            this.label1 = new System.Windows.Forms.Label();
            this.ExePathField = new System.Windows.Forms.TextBox();
            this.ControlParamField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.EndButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Application Path:";
            // 
            // ExePathField
            // 
            this.ExePathField.Location = new System.Drawing.Point(13, 30);
            this.ExePathField.Name = "ExePathField";
            this.ExePathField.Size = new System.Drawing.Size(434, 20);
            this.ExePathField.TabIndex = 1;
            // 
            // ControlParamField
            // 
            this.ControlParamField.Location = new System.Drawing.Point(13, 73);
            this.ControlParamField.Name = "ControlParamField";
            this.ControlParamField.Size = new System.Drawing.Size(434, 20);
            this.ControlParamField.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Controlling Parameter:";
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(83, 114);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(114, 46);
            this.StartButton.TabIndex = 4;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // EndButton
            // 
            this.EndButton.Location = new System.Drawing.Point(239, 114);
            this.EndButton.Name = "EndButton";
            this.EndButton.Size = new System.Drawing.Size(114, 46);
            this.EndButton.TabIndex = 5;
            this.EndButton.Text = "End";
            this.EndButton.UseVisualStyleBackColor = true;
            this.EndButton.Click += new System.EventHandler(this.EndButton_Click);
            // 
            // AppRunner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 175);
            this.Controls.Add(this.EndButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.ControlParamField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ExePathField);
            this.Controls.Add(this.label1);
            this.Name = "AppRunner";
            this.Text = "Simple Application Runner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ExePathField;
        private System.Windows.Forms.TextBox ControlParamField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button EndButton;
    }
}