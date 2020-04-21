namespace dataBase
{
    partial class doctorRegisteration
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
            this.button1 = new System.Windows.Forms.Button();
            this.Shift = new System.Windows.Forms.TextBox();
            this.Degree = new System.Windows.Forms.TextBox();
            this.Department = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(305, 382);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 28);
            this.button1.TabIndex = 31;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Shift
            // 
            this.Shift.Location = new System.Drawing.Point(406, 189);
            this.Shift.Name = "Shift";
            this.Shift.Size = new System.Drawing.Size(100, 20);
            this.Shift.TabIndex = 27;
            this.Shift.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // Degree
            // 
            this.Degree.Location = new System.Drawing.Point(406, 219);
            this.Degree.Name = "Degree";
            this.Degree.Size = new System.Drawing.Size(100, 20);
            this.Degree.TabIndex = 26;
            this.Degree.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // Department
            // 
            this.Department.Location = new System.Drawing.Point(406, 160);
            this.Department.Name = "Department";
            this.Department.Size = new System.Drawing.Size(100, 20);
            this.Department.TabIndex = 24;
            this.Department.TextChanged += new System.EventHandler(this.username_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(254, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 21);
            this.label3.TabIndex = 19;
            this.label3.Text = "Degree";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(254, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 21);
            this.label2.TabIndex = 18;
            this.label2.Text = "Shift";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(254, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 21);
            this.label1.TabIndex = 17;
            this.label1.Text = "Department";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // doctorRegisteration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::dataBase.Properties.Resources.bakground;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Shift);
            this.Controls.Add(this.Degree);
            this.Controls.Add(this.Department);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "doctorRegisteration";
            this.Text = "doctorRegisteration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Shift;
        private System.Windows.Forms.TextBox Degree;
        private System.Windows.Forms.TextBox Department;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}