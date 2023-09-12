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
            this.components = new System.ComponentModel.Container();
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
            this.chkNonWorkDays = new System.Windows.Forms.CheckedListBox();
            this.lblExcludeDays = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblNetPay = new System.Windows.Forms.Label();
            this.lblDeduction = new System.Windows.Forms.Label();
            this.lblGrossPay = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNetPay = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblPeso2 = new System.Windows.Forms.Label();
            this.txtDeduction = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblPeso1 = new System.Windows.Forms.Label();
            this.txtGrossPay = new System.Windows.Forms.TextBox();
            this.tipDaysExcluded = new System.Windows.Forms.ToolTip(this.components);
            this.lblAccount = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblDaysWorked = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtWorkDays = new System.Windows.Forms.TextBox();
            this.boxDaysOfWork = new System.Windows.Forms.RichTextBox();
            this.lblDaysOfWork = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMessage.Font = new System.Drawing.Font("Segoe UI Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(0, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Padding = new System.Windows.Forms.Padding(50, 20, 0, 0);
            this.lblMessage.Size = new System.Drawing.Size(191, 60);
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
            this.panel1.Size = new System.Drawing.Size(286, 41);
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
            this.cmbEmployeeStatus.Size = new System.Drawing.Size(274, 29);
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
            this.lblFullName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblFullName.Location = new System.Drawing.Point(569, 4);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblFullName.Size = new System.Drawing.Size(142, 25);
            this.lblFullName.TabIndex = 4;
            this.lblFullName.Text = "Full name here ";
            this.lblFullName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(44, 114);
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
            this.btnCompute.Location = new System.Drawing.Point(43, 524);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(348, 43);
            this.btnCompute.TabIndex = 6;
            this.btnCompute.Text = "Compute";
            this.btnCompute.UseVisualStyleBackColor = false;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // dteStart
            // 
            this.dteStart.Checked = false;
            this.dteStart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dteStart.Location = new System.Drawing.Point(24, 52);
            this.dteStart.MaxDate = new System.DateTime(2024, 12, 31, 0, 0, 0, 0);
            this.dteStart.MinDate = new System.DateTime(2022, 1, 20, 0, 0, 0, 0);
            this.dteStart.Name = "dteStart";
            this.dteStart.Size = new System.Drawing.Size(288, 29);
            this.dteStart.TabIndex = 1;
            this.dteStart.Value = new System.DateTime(2023, 9, 11, 0, 0, 0, 0);
            this.dteStart.ValueChanged += new System.EventHandler(this.dteStart_ValueChanged);
            // 
            // dteEnd
            // 
            this.dteEnd.Checked = false;
            this.dteEnd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dteEnd.Location = new System.Drawing.Point(24, 114);
            this.dteEnd.MaxDate = new System.DateTime(2025, 12, 31, 0, 0, 0, 0);
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
            this.label2.Location = new System.Drawing.Point(27, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Start:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "End:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkNonWorkDays);
            this.groupBox2.Controls.Add(this.lblExcludeDays);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dteStart);
            this.groupBox2.Controls.Add(this.dteEnd);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(44, 232);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(347, 270);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Days Worked";
            // 
            // chkNonWorkDays
            // 
            this.chkNonWorkDays.BackColor = System.Drawing.SystemColors.Control;
            this.chkNonWorkDays.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chkNonWorkDays.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.chkNonWorkDays.FormattingEnabled = true;
            this.chkNonWorkDays.HorizontalScrollbar = true;
            this.chkNonWorkDays.Location = new System.Drawing.Point(24, 186);
            this.chkNonWorkDays.MultiColumn = true;
            this.chkNonWorkDays.Name = "chkNonWorkDays";
            this.chkNonWorkDays.Size = new System.Drawing.Size(288, 60);
            this.chkNonWorkDays.TabIndex = 7;
            // 
            // lblExcludeDays
            // 
            this.lblExcludeDays.AutoSize = true;
            this.lblExcludeDays.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExcludeDays.Location = new System.Drawing.Point(27, 162);
            this.lblExcludeDays.Name = "lblExcludeDays";
            this.lblExcludeDays.Size = new System.Drawing.Size(139, 17);
            this.lblExcludeDays.TabIndex = 3;
            this.lblExcludeDays.Text = "Workdays to exclude:";
            this.tipDaysExcluded.SetToolTip(this.lblExcludeDays, "Sunday is excluded by default");
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.boxDaysOfWork);
            this.groupBox3.Controls.Add(this.lblDaysOfWork);
            this.groupBox3.Controls.Add(this.lblDaysWorked);
            this.groupBox3.Controls.Add(this.btnReset);
            this.groupBox3.Controls.Add(this.lblNetPay);
            this.groupBox3.Controls.Add(this.lblDeduction);
            this.groupBox3.Controls.Add(this.lblGrossPay);
            this.groupBox3.Controls.Add(this.panel5);
            this.groupBox3.Controls.Add(this.panel4);
            this.groupBox3.Controls.Add(this.panel3);
            this.groupBox3.Controls.Add(this.panel2);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(429, 114);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(323, 453);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Payroll Summary";
            // 
            // lblNetPay
            // 
            this.lblNetPay.AutoSize = true;
            this.lblNetPay.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetPay.Location = new System.Drawing.Point(29, 182);
            this.lblNetPay.Name = "lblNetPay";
            this.lblNetPay.Size = new System.Drawing.Size(56, 17);
            this.lblNetPay.TabIndex = 3;
            this.lblNetPay.Text = "Net Pay";
            // 
            // lblDeduction
            // 
            this.lblDeduction.AutoSize = true;
            this.lblDeduction.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeduction.Location = new System.Drawing.Point(29, 103);
            this.lblDeduction.Name = "lblDeduction";
            this.lblDeduction.Size = new System.Drawing.Size(70, 17);
            this.lblDeduction.TabIndex = 3;
            this.lblDeduction.Text = "Deduction";
            // 
            // lblGrossPay
            // 
            this.lblGrossPay.AutoSize = true;
            this.lblGrossPay.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrossPay.Location = new System.Drawing.Point(29, 28);
            this.lblGrossPay.Name = "lblGrossPay";
            this.lblGrossPay.Size = new System.Drawing.Size(68, 17);
            this.lblGrossPay.TabIndex = 3;
            this.lblGrossPay.Text = "Gross Pay";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gainsboro;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.txtNetPay);
            this.panel4.Location = new System.Drawing.Point(27, 202);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(10, 6, 10, 5);
            this.panel4.Size = new System.Drawing.Size(269, 43);
            this.panel4.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "₱";
            // 
            // txtNetPay
            // 
            this.txtNetPay.BackColor = System.Drawing.Color.Gainsboro;
            this.txtNetPay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNetPay.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtNetPay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNetPay.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNetPay.Location = new System.Drawing.Point(10, 6);
            this.txtNetPay.MaxLength = 50;
            this.txtNetPay.Name = "txtNetPay";
            this.txtNetPay.ReadOnly = true;
            this.txtNetPay.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtNetPay.Size = new System.Drawing.Size(245, 26);
            this.txtNetPay.TabIndex = 4;
            this.txtNetPay.TabStop = false;
            this.txtNetPay.Text = "0.00";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.lblPeso2);
            this.panel3.Controls.Add(this.txtDeduction);
            this.panel3.Location = new System.Drawing.Point(27, 123);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(10, 6, 10, 5);
            this.panel3.Size = new System.Drawing.Size(269, 43);
            this.panel3.TabIndex = 2;
            // 
            // lblPeso2
            // 
            this.lblPeso2.AutoSize = true;
            this.lblPeso2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeso2.Location = new System.Drawing.Point(6, 8);
            this.lblPeso2.Name = "lblPeso2";
            this.lblPeso2.Size = new System.Drawing.Size(18, 20);
            this.lblPeso2.TabIndex = 3;
            this.lblPeso2.Text = "₱";
            // 
            // txtDeduction
            // 
            this.txtDeduction.BackColor = System.Drawing.Color.Gainsboro;
            this.txtDeduction.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDeduction.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtDeduction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDeduction.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeduction.Location = new System.Drawing.Point(10, 6);
            this.txtDeduction.MaxLength = 50;
            this.txtDeduction.Name = "txtDeduction";
            this.txtDeduction.ReadOnly = true;
            this.txtDeduction.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDeduction.Size = new System.Drawing.Size(245, 26);
            this.txtDeduction.TabIndex = 4;
            this.txtDeduction.TabStop = false;
            this.txtDeduction.Text = "0.00";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lblPeso1);
            this.panel2.Controls.Add(this.txtGrossPay);
            this.panel2.Location = new System.Drawing.Point(27, 48);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10, 6, 10, 5);
            this.panel2.Size = new System.Drawing.Size(269, 43);
            this.panel2.TabIndex = 2;
            // 
            // lblPeso1
            // 
            this.lblPeso1.AutoSize = true;
            this.lblPeso1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeso1.Location = new System.Drawing.Point(6, 8);
            this.lblPeso1.Name = "lblPeso1";
            this.lblPeso1.Size = new System.Drawing.Size(18, 20);
            this.lblPeso1.TabIndex = 3;
            this.lblPeso1.Text = "₱";
            // 
            // txtGrossPay
            // 
            this.txtGrossPay.BackColor = System.Drawing.Color.Gainsboro;
            this.txtGrossPay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGrossPay.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtGrossPay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGrossPay.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrossPay.Location = new System.Drawing.Point(10, 6);
            this.txtGrossPay.MaxLength = 50;
            this.txtGrossPay.Name = "txtGrossPay";
            this.txtGrossPay.ReadOnly = true;
            this.txtGrossPay.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtGrossPay.Size = new System.Drawing.Size(245, 26);
            this.txtGrossPay.TabIndex = 4;
            this.txtGrossPay.TabStop = false;
            this.txtGrossPay.Text = "0.00";
            // 
            // tipDaysExcluded
            // 
            this.tipDaysExcluded.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tipDaysExcluded.ToolTipTitle = "Excluding Dates";
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Location = new System.Drawing.Point(700, 41);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblAccount.Size = new System.Drawing.Size(54, 17);
            this.lblAccount.TabIndex = 7;
            this.lblAccount.Text = "Account";
            this.lblAccount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblFullName, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(44, 55);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(714, 34);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // lblDaysWorked
            // 
            this.lblDaysWorked.AutoSize = true;
            this.lblDaysWorked.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDaysWorked.Location = new System.Drawing.Point(173, 262);
            this.lblDaysWorked.Name = "lblDaysWorked";
            this.lblDaysWorked.Size = new System.Drawing.Size(111, 17);
            this.lblDaysWorked.TabIndex = 3;
            this.lblDaysWorked.Text = "No. of work days";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gainsboro;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.txtWorkDays);
            this.panel5.Location = new System.Drawing.Point(171, 285);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(10, 6, 10, 5);
            this.panel5.Size = new System.Drawing.Size(125, 43);
            this.panel5.TabIndex = 2;
            // 
            // txtWorkDays
            // 
            this.txtWorkDays.BackColor = System.Drawing.Color.Gainsboro;
            this.txtWorkDays.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtWorkDays.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtWorkDays.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtWorkDays.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWorkDays.Location = new System.Drawing.Point(10, 6);
            this.txtWorkDays.MaxLength = 50;
            this.txtWorkDays.Name = "txtWorkDays";
            this.txtWorkDays.ReadOnly = true;
            this.txtWorkDays.Size = new System.Drawing.Size(101, 26);
            this.txtWorkDays.TabIndex = 4;
            this.txtWorkDays.TabStop = false;
            this.txtWorkDays.Text = "0";
            // 
            // boxDaysOfWork
            // 
            this.boxDaysOfWork.BackColor = System.Drawing.Color.Gainsboro;
            this.boxDaysOfWork.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.boxDaysOfWork.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxDaysOfWork.Location = new System.Drawing.Point(27, 285);
            this.boxDaysOfWork.Name = "boxDaysOfWork";
            this.boxDaysOfWork.ReadOnly = true;
            this.boxDaysOfWork.Size = new System.Drawing.Size(135, 142);
            this.boxDaysOfWork.TabIndex = 4;
            this.boxDaysOfWork.Text = "";
            // 
            // lblDaysOfWork
            // 
            this.lblDaysOfWork.AutoSize = true;
            this.lblDaysOfWork.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDaysOfWork.Location = new System.Drawing.Point(29, 262);
            this.lblDaysOfWork.Name = "lblDaysOfWork";
            this.lblDaysOfWork.Size = new System.Drawing.Size(90, 17);
            this.lblDaysOfWork.TabIndex = 3;
            this.lblDaysOfWork.Text = "Days of Work";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Goldenrod;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(171, 384);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(125, 43);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Visible = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 582);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lblAccount);
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
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
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblGrossPay;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtGrossPay;
        private System.Windows.Forms.Label lblPeso1;
        private System.Windows.Forms.Label lblDeduction;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblPeso2;
        private System.Windows.Forms.TextBox txtDeduction;
        private System.Windows.Forms.Label lblNetPay;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNetPay;
        private System.Windows.Forms.CheckedListBox chkNonWorkDays;
        private System.Windows.Forms.Label lblExcludeDays;
        private System.Windows.Forms.ToolTip tipDaysExcluded;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblDaysWorked;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtWorkDays;
        private System.Windows.Forms.RichTextBox boxDaysOfWork;
        private System.Windows.Forms.Label lblDaysOfWork;
        private System.Windows.Forms.Button btnReset;
    }
}