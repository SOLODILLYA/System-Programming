namespace StudentManager
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AddAttendanceButton = new System.Windows.Forms.Button();
            this.EditAttendanceButton = new System.Windows.Forms.Button();
            this.AddGradeButton = new System.Windows.Forms.Button();
            this.EditGradeButton = new System.Windows.Forms.Button();
            this.EditStudentsButton = new System.Windows.Forms.Button();
            this.AddStudentButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(343, 344);
            this.dataGridView1.TabIndex = 0;
            // 
            // AddAttendanceButton
            // 
            this.AddAttendanceButton.Location = new System.Drawing.Point(58, 372);
            this.AddAttendanceButton.Name = "AddAttendanceButton";
            this.AddAttendanceButton.Size = new System.Drawing.Size(126, 49);
            this.AddAttendanceButton.TabIndex = 1;
            this.AddAttendanceButton.Text = "Add Attendance";
            this.AddAttendanceButton.UseVisualStyleBackColor = true;
            this.AddAttendanceButton.Click += new System.EventHandler(this.AddAttendanceButton_Click);
            // 
            // EditAttendanceButton
            // 
            this.EditAttendanceButton.Location = new System.Drawing.Point(190, 372);
            this.EditAttendanceButton.Name = "EditAttendanceButton";
            this.EditAttendanceButton.Size = new System.Drawing.Size(126, 49);
            this.EditAttendanceButton.TabIndex = 2;
            this.EditAttendanceButton.Text = "Edit Attendance";
            this.EditAttendanceButton.UseVisualStyleBackColor = true;
            this.EditAttendanceButton.Click += new System.EventHandler(this.EditAttendanceButton_Click);
            // 
            // AddGradeButton
            // 
            this.AddGradeButton.Location = new System.Drawing.Point(58, 427);
            this.AddGradeButton.Name = "AddGradeButton";
            this.AddGradeButton.Size = new System.Drawing.Size(126, 49);
            this.AddGradeButton.TabIndex = 3;
            this.AddGradeButton.Text = "Add Grade";
            this.AddGradeButton.UseVisualStyleBackColor = true;
            this.AddGradeButton.Click += new System.EventHandler(this.AddGradeButton_Click);
            // 
            // EditGradeButton
            // 
            this.EditGradeButton.Location = new System.Drawing.Point(190, 427);
            this.EditGradeButton.Name = "EditGradeButton";
            this.EditGradeButton.Size = new System.Drawing.Size(126, 49);
            this.EditGradeButton.TabIndex = 4;
            this.EditGradeButton.Text = "Edit Grades";
            this.EditGradeButton.UseVisualStyleBackColor = true;
            this.EditGradeButton.Click += new System.EventHandler(this.EditGradeButton_Click);
            // 
            // EditStudentsButton
            // 
            this.EditStudentsButton.Location = new System.Drawing.Point(190, 482);
            this.EditStudentsButton.Name = "EditStudentsButton";
            this.EditStudentsButton.Size = new System.Drawing.Size(126, 49);
            this.EditStudentsButton.TabIndex = 6;
            this.EditStudentsButton.Text = "Edit Students";
            this.EditStudentsButton.UseVisualStyleBackColor = true;
            this.EditStudentsButton.Click += new System.EventHandler(this.EditStudentsButton_Click);
            // 
            // AddStudentButton
            // 
            this.AddStudentButton.Location = new System.Drawing.Point(58, 482);
            this.AddStudentButton.Name = "AddStudentButton";
            this.AddStudentButton.Size = new System.Drawing.Size(126, 49);
            this.AddStudentButton.TabIndex = 5;
            this.AddStudentButton.Text = "Add Student";
            this.AddStudentButton.UseVisualStyleBackColor = true;
            this.AddStudentButton.Click += new System.EventHandler(this.AddStudentButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 535);
            this.Controls.Add(this.EditStudentsButton);
            this.Controls.Add(this.AddStudentButton);
            this.Controls.Add(this.EditGradeButton);
            this.Controls.Add(this.AddGradeButton);
            this.Controls.Add(this.EditAttendanceButton);
            this.Controls.Add(this.AddAttendanceButton);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AddAttendanceButton;
        private System.Windows.Forms.Button EditAttendanceButton;
        private System.Windows.Forms.Button AddGradeButton;
        private System.Windows.Forms.Button EditGradeButton;
        private System.Windows.Forms.Button EditStudentsButton;
        private System.Windows.Forms.Button AddStudentButton;
    }
}

