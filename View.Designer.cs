namespace Expense_Tracker
{
    partial class View
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
            this.Catogries = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Total_Income_Dashboard = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Incm_Trans = new System.Windows.Forms.Label();
            this.Incm_Date = new System.Windows.Forms.Label();
            this.Amt_Income = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnReport = new System.Windows.Forms.Button();
            this.BtnIncome = new System.Windows.Forms.Button();
            this.BtnExpense = new System.Windows.Forms.Button();
            this.BtnDashboard = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.IncomeDGV = new System.Windows.Forms.DataGridView();
            this.Btn_submit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ExpenseDGV = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.Total_Income_Dashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IncomeDGV)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExpenseDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // Catogries
            // 
            this.Catogries.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Catogries.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Catogries.ForeColor = System.Drawing.Color.Black;
            this.Catogries.FormattingEnabled = true;
            this.Catogries.Location = new System.Drawing.Point(591, 308);
            this.Catogries.Name = "Catogries";
            this.Catogries.Size = new System.Drawing.Size(220, 40);
            this.Catogries.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Silver;
            this.label8.Font = new System.Drawing.Font("Lexend SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(430, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(220, 45);
            this.label8.TabIndex = 27;
            this.label8.Text = "Income Detail";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(270, 310);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(221, 38);
            this.textBox1.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Lexend SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(83, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "ExTracker ";
            // 
            // Total_Income_Dashboard
            // 
            this.Total_Income_Dashboard.BackColor = System.Drawing.Color.Gainsboro;
            this.Total_Income_Dashboard.Controls.Add(this.pictureBox2);
            this.Total_Income_Dashboard.Controls.Add(this.Incm_Trans);
            this.Total_Income_Dashboard.Controls.Add(this.Incm_Date);
            this.Total_Income_Dashboard.Controls.Add(this.Amt_Income);
            this.Total_Income_Dashboard.Controls.Add(this.label3);
            this.Total_Income_Dashboard.Location = new System.Drawing.Point(259, 66);
            this.Total_Income_Dashboard.Name = "Total_Income_Dashboard";
            this.Total_Income_Dashboard.Size = new System.Drawing.Size(1142, 90);
            this.Total_Income_Dashboard.TabIndex = 35;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Expense_Tracker.Properties.Resources.money;
            this.pictureBox2.Location = new System.Drawing.Point(981, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(158, 71);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // Incm_Trans
            // 
            this.Incm_Trans.AutoSize = true;
            this.Incm_Trans.BackColor = System.Drawing.Color.Gainsboro;
            this.Incm_Trans.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Incm_Trans.Location = new System.Drawing.Point(356, 47);
            this.Incm_Trans.Name = "Incm_Trans";
            this.Incm_Trans.Size = new System.Drawing.Size(126, 23);
            this.Incm_Trans.TabIndex = 0;
            this.Incm_Trans.Text = "Transaction:";
            // 
            // Incm_Date
            // 
            this.Incm_Date.AutoSize = true;
            this.Incm_Date.BackColor = System.Drawing.Color.Gainsboro;
            this.Incm_Date.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Incm_Date.Location = new System.Drawing.Point(701, 47);
            this.Incm_Date.Name = "Incm_Date";
            this.Incm_Date.Size = new System.Drawing.Size(62, 23);
            this.Incm_Date.TabIndex = 0;
            this.Incm_Date.Text = "Date:";
            // 
            // Amt_Income
            // 
            this.Amt_Income.AutoSize = true;
            this.Amt_Income.BackColor = System.Drawing.Color.Gainsboro;
            this.Amt_Income.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amt_Income.Location = new System.Drawing.Point(17, 47);
            this.Amt_Income.Name = "Amt_Income";
            this.Amt_Income.Size = new System.Drawing.Size(145, 23);
            this.Amt_Income.TabIndex = 0;
            this.Amt_Income.Text = "AmountinPKR:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gainsboro;
            this.label3.Font = new System.Drawing.Font("Lexend SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 45);
            this.label3.TabIndex = 0;
            this.label3.Text = "Total Income";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.BtnReport);
            this.panel1.Controls.Add(this.BtnIncome);
            this.panel1.Controls.Add(this.BtnExpense);
            this.panel1.Controls.Add(this.BtnDashboard);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 807);
            this.panel1.TabIndex = 34;
            // 
            // BtnReport
            // 
            this.BtnReport.BackColor = System.Drawing.Color.Transparent;
            this.BtnReport.FlatAppearance.BorderSize = 0;
            this.BtnReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtnReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReport.Font = new System.Drawing.Font("Lexend SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReport.ForeColor = System.Drawing.Color.GreenYellow;
            this.BtnReport.Image = global::Expense_Tracker.Properties.Resources.pie_chart__1_;
            this.BtnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnReport.Location = new System.Drawing.Point(3, 537);
            this.BtnReport.Name = "BtnReport";
            this.BtnReport.Size = new System.Drawing.Size(231, 64);
            this.BtnReport.TabIndex = 7;
            this.BtnReport.Text = "View";
            this.BtnReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnReport.UseVisualStyleBackColor = false;
            // 
            // BtnIncome
            // 
            this.BtnIncome.BackColor = System.Drawing.Color.Transparent;
            this.BtnIncome.FlatAppearance.BorderSize = 0;
            this.BtnIncome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtnIncome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtnIncome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIncome.Font = new System.Drawing.Font("Lexend SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIncome.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnIncome.Image = global::Expense_Tracker.Properties.Resources.income_growth;
            this.BtnIncome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnIncome.Location = new System.Drawing.Point(3, 426);
            this.BtnIncome.Name = "BtnIncome";
            this.BtnIncome.Size = new System.Drawing.Size(231, 64);
            this.BtnIncome.TabIndex = 8;
            this.BtnIncome.Text = "Income";
            this.BtnIncome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnIncome.UseVisualStyleBackColor = false;
            // 
            // BtnExpense
            // 
            this.BtnExpense.BackColor = System.Drawing.Color.Transparent;
            this.BtnExpense.FlatAppearance.BorderSize = 0;
            this.BtnExpense.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtnExpense.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtnExpense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExpense.Font = new System.Drawing.Font("Lexend SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExpense.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnExpense.Image = global::Expense_Tracker.Properties.Resources.expenses;
            this.BtnExpense.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnExpense.Location = new System.Drawing.Point(3, 317);
            this.BtnExpense.Name = "BtnExpense";
            this.BtnExpense.Size = new System.Drawing.Size(231, 64);
            this.BtnExpense.TabIndex = 9;
            this.BtnExpense.Text = "Expenses";
            this.BtnExpense.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnExpense.UseVisualStyleBackColor = false;
            this.BtnExpense.Click += new System.EventHandler(this.BtnExpense_Click);
            // 
            // BtnDashboard
            // 
            this.BtnDashboard.BackColor = System.Drawing.Color.Transparent;
            this.BtnDashboard.FlatAppearance.BorderSize = 0;
            this.BtnDashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtnDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDashboard.Font = new System.Drawing.Font("Lexend SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDashboard.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnDashboard.Image = global::Expense_Tracker.Properties.Resources.dashboard__1_;
            this.BtnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDashboard.Location = new System.Drawing.Point(3, 207);
            this.BtnDashboard.Name = "BtnDashboard";
            this.BtnDashboard.Size = new System.Drawing.Size(231, 64);
            this.BtnDashboard.TabIndex = 10;
            this.BtnDashboard.Text = "Dashboard";
            this.BtnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnDashboard.UseVisualStyleBackColor = false;
            this.BtnDashboard.Click += new System.EventHandler(this.BtnDashboard_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Expense_Tracker.Properties.Resources.icons8_budget_64;
            this.pictureBox1.Location = new System.Drawing.Point(21, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Lexend SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(263, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 37);
            this.label1.TabIndex = 30;
            this.label1.Text = "Income Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Silver;
            this.label6.Font = new System.Drawing.Font("Lexend SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(584, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 37);
            this.label6.TabIndex = 31;
            this.label6.Text = "Categories";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Silver;
            this.flowLayoutPanel1.Controls.Add(this.CancelBtn);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1444, 50);
            this.flowLayoutPanel1.TabIndex = 33;
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.Color.Transparent;
            this.CancelBtn.FlatAppearance.BorderSize = 0;
            this.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelBtn.Image = global::Expense_Tracker.Properties.Resources.closebtn22;
            this.CancelBtn.Location = new System.Drawing.Point(1387, 3);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(54, 47);
            this.CancelBtn.TabIndex = 6;
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.IncomeDGV);
            this.panel2.Location = new System.Drawing.Point(270, 394);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(541, 277);
            this.panel2.TabIndex = 40;
            // 
            // IncomeDGV
            // 
            this.IncomeDGV.AllowUserToAddRows = false;
            this.IncomeDGV.AllowUserToDeleteRows = false;
            this.IncomeDGV.BackgroundColor = System.Drawing.Color.White;
            this.IncomeDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IncomeDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IncomeDGV.Location = new System.Drawing.Point(2, 3);
            this.IncomeDGV.Name = "IncomeDGV";
            this.IncomeDGV.ReadOnly = true;
            this.IncomeDGV.RowHeadersWidth = 51;
            this.IncomeDGV.RowTemplate.Height = 24;
            this.IncomeDGV.Size = new System.Drawing.Size(536, 271);
            this.IncomeDGV.TabIndex = 0;
            // 
            // Btn_submit
            // 
            this.Btn_submit.BackColor = System.Drawing.Color.YellowGreen;
            this.Btn_submit.FlatAppearance.BorderSize = 0;
            this.Btn_submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_submit.Font = new System.Drawing.Font("Lexend SemiBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_submit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Btn_submit.Location = new System.Drawing.Point(438, 711);
            this.Btn_submit.Name = "Btn_submit";
            this.Btn_submit.Size = new System.Drawing.Size(221, 58);
            this.Btn_submit.TabIndex = 27;
            this.Btn_submit.Text = "Search Income";
            this.Btn_submit.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Silver;
            this.label4.Font = new System.Drawing.Font("Lexend SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1187, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 37);
            this.label4.TabIndex = 31;
            this.label4.Text = "Categories";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Silver;
            this.label5.Font = new System.Drawing.Font("Lexend SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(866, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 37);
            this.label5.TabIndex = 30;
            this.label5.Text = "Expense Name";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Black;
            this.textBox2.Location = new System.Drawing.Point(873, 310);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(221, 38);
            this.textBox2.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Silver;
            this.label7.Font = new System.Drawing.Font("Lexend SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1033, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(228, 45);
            this.label7.TabIndex = 27;
            this.label7.Text = "Expense Detail";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.Black;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(1194, 308);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(220, 40);
            this.comboBox1.TabIndex = 39;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ExpenseDGV);
            this.panel3.Location = new System.Drawing.Point(873, 394);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(541, 277);
            this.panel3.TabIndex = 40;
            // 
            // ExpenseDGV
            // 
            this.ExpenseDGV.BackgroundColor = System.Drawing.Color.White;
            this.ExpenseDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ExpenseDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ExpenseDGV.Location = new System.Drawing.Point(2, 3);
            this.ExpenseDGV.Name = "ExpenseDGV";
            this.ExpenseDGV.RowHeadersWidth = 51;
            this.ExpenseDGV.RowTemplate.Height = 24;
            this.ExpenseDGV.Size = new System.Drawing.Size(536, 271);
            this.ExpenseDGV.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.YellowGreen;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Lexend SemiBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(1041, 711);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(230, 58);
            this.button1.TabIndex = 27;
            this.button1.Text = "Search Expense";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1444, 857);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Btn_submit);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Catogries);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Total_Income_Dashboard);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "View";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Total_Income_Dashboard.ResumeLayout(false);
            this.Total_Income_Dashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IncomeDGV)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ExpenseDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox Catogries;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel Total_Income_Dashboard;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label Incm_Trans;
        private System.Windows.Forms.Label Incm_Date;
        private System.Windows.Forms.Label Amt_Income;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnReport;
        private System.Windows.Forms.Button BtnIncome;
        private System.Windows.Forms.Button BtnExpense;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnDashboard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView IncomeDGV;
        private System.Windows.Forms.Button Btn_submit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView ExpenseDGV;
        private System.Windows.Forms.Button button1;
    }
}