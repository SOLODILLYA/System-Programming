namespace AppRunner1
{
    partial class AddPathForm
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
            this.PathText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NameText = new System.Windows.Forms.TextBox();
            this.AddPathButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PathText
            // 
            this.PathText.Location = new System.Drawing.Point(9, 69);
            this.PathText.Name = "PathText";
            this.PathText.Size = new System.Drawing.Size(434, 20);
            this.PathText.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Application Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Application Path:";
            // 
            // NameText
            // 
            this.NameText.Location = new System.Drawing.Point(12, 25);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(434, 20);
            this.NameText.TabIndex = 16;
            // 
            // AddPathButton
            // 
            this.AddPathButton.Location = new System.Drawing.Point(166, 107);
            this.AddPathButton.Name = "AddPathButton";
            this.AddPathButton.Size = new System.Drawing.Size(111, 46);
            this.AddPathButton.TabIndex = 17;
            this.AddPathButton.Text = "Add Application";
            this.AddPathButton.UseVisualStyleBackColor = true;
            this.AddPathButton.Click += new System.EventHandler(this.AddPathButton_Click);
            // 
            // AddPathForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 165);
            this.Controls.Add(this.AddPathButton);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.PathText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddPathForm";
            this.Text = "AddPathForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PathText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.Button AddPathButton;
    }
}