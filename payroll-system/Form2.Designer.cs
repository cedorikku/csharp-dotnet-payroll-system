namespace payroll_system
{
    partial class Form2
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
            this.lblMessage = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbEmployeeStatus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCompute = new System.Windows.Forms.Button();
            this.dteStart = new System.Windows.Forms.DateTimePicker();
            this.dteEnd = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMessage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(0, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Padding = new System.Windows.Forms.Padding(50, 20, 0, 0);
            this.lblMessage.Size = new System.Drawing.Size(121, 41);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "Message";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cmbEmployeeStatus);
            this.panel1.Location = new System.Drawing.Point(26, 37);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(227, 41);
            this.panel1.TabIndex = 2;
            // 
            // cmbEmployeeStatus
            // 
            this.cmbEmployeeStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmbEmployeeStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmployeeStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbEmployeeStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEmployeeStatus.FormattingEnabled = true;
            this.cmbEmployeeStatus.Location = new System.Drawing.Point(5, 5);
            this.cmbEmployeeStatus.Name = "cmbEmployeeStatus";
            this.cmbEmployeeStatus.Size = new System.Drawing.Size(215, 29);
            this.cmbEmployeeStatus.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Status";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.Location = new System.Drawing.Point(48, 35);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(205, 37);
            this.lblFullName.TabIndex = 4;
            this.lblFullName.Text = "Full name here";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(55, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 101);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee Details";
            // 
            // btnCompute
            // 
            this.btnCompute.BackColor = System.Drawing.Color.Black;
            this.btnCompute.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCompute.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompute.ForeColor = System.Drawing.Color.White;
            this.btnCompute.Location = new System.Drawing.Point(55, 416);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(347, 43);
            this.btnCompute.TabIndex = 6;
            this.btnCompute.Text = "Compute";
            this.btnCompute.UseVisualStyleBackColor = false;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // dteStart
            // 
            this.dteStart.Checked = false;
            this.dteStart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dteStart.Location = new System.Drawing.Point(24, 57);
            this.dteStart.MaxDate = new System.DateTime(2024, 12, 31, 0, 0, 0, 0);
            this.dteStart.MinDate = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            this.dteStart.Name = "dteStart";
            this.dteStart.Size = new System.Drawing.Size(288, 29);
            this.dteStart.TabIndex = 1;
            this.dteStart.Value = new System.DateTime(2023, 9, 11, 0, 0, 0, 0);
            // 
            // dteEnd
            // 
            this.dteEnd.Checked = false;
            this.dteEnd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dteEnd.Location = new System.Drawing.Point(24, 114);
            this.dteEnd.MaxDate = new System.DateTime(2024, 12, 31, 0, 0, 0, 0);
            this.dteEnd.MinDate = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            this.dteEnd.Name = "dteEnd";
            this.dteEnd.Size = new System.Drawing.Size(288, 29);
            this.dteEnd.TabIndex = 1;
            this.dteEnd.Value = new System.DateTime(2023, 9, 11, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Start";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 95);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(31, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "End";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dteStart);
            this.groupBox2.Controls.Add(this.dteEnd);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(55, 215);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(347, 169);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Days Worked";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 476);
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payroll System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbEmployeeStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.DateTimePicker dteStart;
        private System.Windows.Forms.DateTimePicker dteEnd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}