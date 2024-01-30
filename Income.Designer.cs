namespace Expense_Tracker
{
    partial class Income
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.Total_Income_Dashboard = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Incm_Trans = new System.Windows.Forms.Label();
            this.Incm_Date = new System.Windows.Forms.Label();
            this.Amt_Income = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.TotlInc = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnReport = new System.Windows.Forms.Button();
            this.BtnIncome = new System.Windows.Forms.Button();
            this.BtnExpense = new System.Windows.Forms.Button();
            this.BtnDashboard = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.IncNameTb = new System.Windows.Forms.TextBox();
            this.IncAmtTb = new System.Windows.Forms.TextBox();
            this.IncDescTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.IncCatCb = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.IncDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.AddBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Total_Income_Dashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // Total_Income_Dashboard
            // 
            this.Total_Income_Dashboard.BackColor = System.Drawing.Color.Gainsboro;
            this.Total_Income_Dashboard.Controls.Add(this.pictureBox2);
            this.Total_Income_Dashboard.Controls.Add(this.Incm_Trans);
            this.Total_Income_Dashboard.Controls.Add(this.Incm_Date);
            this.Total_Income_Dashboard.Controls.Add(this.Amt_Income);
            this.Total_Income_Dashboard.Controls.Add(this.label3);
            this.Total_Income_Dashboard.Controls.Add(this.label23);
            this.Total_Income_Dashboard.Controls.Add(this.label18);
            this.Total_Income_Dashboard.Controls.Add(this.TotlInc);
            this.Total_Income_Dashboard.Location = new System.Drawing.Point(259, 66);
            this.Total_Income_Dashboard.Name = "Total_Income_Dashboard";
            this.Total_Income_Dashboard.Size = new System.Drawing.Size(1142, 90);
            this.Total_Income_Dashboard.TabIndex = 22;
            this.Total_Income_Dashboard.Paint += new System.Windows.Forms.PaintEventHandler(this.Total_Income_Dashboard_Paint);
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
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
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
            this.Incm_Trans.Click += new System.EventHandler(this.Incm_Trans_Click);
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
            this.Incm_Date.Click += new System.EventHandler(this.Incm_Date_Click);
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
            this.Amt_Income.Click += new System.EventHandler(this.Amt_Income_Click);
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
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Gainsboro;
            this.label23.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(769, 47);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(112, 23);
            this.label23.TabIndex = 2;
            this.label23.Text = "12-12-2020";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Gainsboro;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(497, 47);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(21, 23);
            this.label18.TabIndex = 3;
            this.label18.Text = "0";
            // 
            // TotlInc
            // 
            this.TotlInc.AutoSize = true;
            this.TotlInc.BackColor = System.Drawing.Color.Gainsboro;
            this.TotlInc.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotlInc.Location = new System.Drawing.Point(168, 47);
            this.TotlInc.Name = "TotlInc";
            this.TotlInc.Size = new System.Drawing.Size(93, 23);
            this.TotlInc.TabIndex = 4;
            this.TotlInc.Text = "RS 23000";
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
            this.panel1.Size = new System.Drawing.Size(237, 800);
            this.panel1.TabIndex = 17;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // BtnReport
            // 
            this.BtnReport.BackColor = System.Drawing.Color.Transparent;
            this.BtnReport.FlatAppearance.BorderSize = 0;
            this.BtnReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtnReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReport.Font = new System.Drawing.Font("Lexend SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReport.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnReport.Image = global::Expense_Tracker.Properties.Resources.pie_chart;
            this.BtnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnReport.Location = new System.Drawing.Point(3, 537);
            this.BtnReport.Name = "BtnReport";
            this.BtnReport.Size = new System.Drawing.Size(231, 68);
            this.BtnReport.TabIndex = 7;
            this.BtnReport.Text = "View";
            this.BtnReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnReport.UseVisualStyleBackColor = false;
            this.BtnReport.Click += new System.EventHandler(this.BtnReport_Click);
            // 
            // BtnIncome
            // 
            this.BtnIncome.BackColor = System.Drawing.Color.Transparent;
            this.BtnIncome.FlatAppearance.BorderSize = 0;
            this.BtnIncome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtnIncome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtnIncome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIncome.Font = new System.Drawing.Font("Lexend SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIncome.ForeColor = System.Drawing.Color.GreenYellow;
            this.BtnIncome.Image = global::Expense_Tracker.Properties.Resources.income_growth__1_;
            this.BtnIncome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnIncome.Location = new System.Drawing.Point(3, 426);
            this.BtnIncome.Name = "BtnIncome";
            this.BtnIncome.Size = new System.Drawing.Size(231, 68);
            this.BtnIncome.TabIndex = 8;
            this.BtnIncome.Text = "Income";
            this.BtnIncome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnIncome.UseVisualStyleBackColor = false;
            this.BtnIncome.Click += new System.EventHandler(this.BtnIncome_Click);
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
            this.BtnExpense.Size = new System.Drawing.Size(231, 68);
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
            this.BtnDashboard.Size = new System.Drawing.Size(231, 68);
            this.BtnDashboard.TabIndex = 10;
            this.BtnDashboard.Text = "Dashboard";
            this.BtnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnDashboard.UseVisualStyleBackColor = false;
            this.BtnDashboard.Click += new System.EventHandler(this.BtnDashboard_Click);
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
            this.label2.Click += new System.EventHandler(this.label2_Click);
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
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Silver;
            this.flowLayoutPanel1.Controls.Add(this.ExitBtn);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1444, 50);
            this.flowLayoutPanel1.TabIndex = 16;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.Transparent;
            this.ExitBtn.FlatAppearance.BorderSize = 0;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Image = global::Expense_Tracker.Properties.Resources.closebtn22;
            this.ExitBtn.Location = new System.Drawing.Point(1387, 3);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(54, 47);
            this.ExitBtn.TabIndex = 6;
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // IncNameTb
            // 
            this.IncNameTb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.IncNameTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IncNameTb.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncNameTb.ForeColor = System.Drawing.Color.Black;
            this.IncNameTb.Location = new System.Drawing.Point(38, 128);
            this.IncNameTb.Multiline = true;
            this.IncNameTb.Name = "IncNameTb";
            this.IncNameTb.Size = new System.Drawing.Size(196, 37);
            this.IncNameTb.TabIndex = 23;
            this.IncNameTb.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // IncAmtTb
            // 
            this.IncAmtTb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.IncAmtTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IncAmtTb.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncAmtTb.ForeColor = System.Drawing.Color.Black;
            this.IncAmtTb.Location = new System.Drawing.Point(38, 254);
            this.IncAmtTb.Multiline = true;
            this.IncAmtTb.Name = "IncAmtTb";
            this.IncAmtTb.Size = new System.Drawing.Size(196, 37);
            this.IncAmtTb.TabIndex = 23;
            this.IncAmtTb.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // IncDescTb
            // 
            this.IncDescTb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.IncDescTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IncDescTb.Font = new System.Drawing.Font("Century Gothic", 12.4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncDescTb.ForeColor = System.Drawing.Color.Black;
            this.IncDescTb.Location = new System.Drawing.Point(38, 379);
            this.IncDescTb.Multiline = true;
            this.IncDescTb.Name = "IncDescTb";
            this.IncDescTb.Size = new System.Drawing.Size(445, 132);
            this.IncDescTb.TabIndex = 23;
            this.IncDescTb.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.Font = new System.Drawing.Font("Lexend SemiBold", 12.4F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Income Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Gainsboro;
            this.label4.Font = new System.Drawing.Font("Lexend SemiBold", 12.4F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 33);
            this.label4.TabIndex = 0;
            this.label4.Text = "Amount";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Gainsboro;
            this.label5.Font = new System.Drawing.Font("Lexend SemiBold", 12.4F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 33);
            this.label5.TabIndex = 0;
            this.label5.Text = "Description";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // IncCatCb
            // 
            this.IncCatCb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.IncCatCb.Font = new System.Drawing.Font("Century Gothic", 12.4F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncCatCb.ForeColor = System.Drawing.Color.Black;
            this.IncCatCb.FormattingEnabled = true;
            this.IncCatCb.Items.AddRange(new object[] {
            "Salary",
            "Upraisal",
            "Bounus",
            "Side Hustle",
            "Others"});
            this.IncCatCb.Location = new System.Drawing.Point(309, 128);
            this.IncCatCb.Name = "IncCatCb";
            this.IncCatCb.Size = new System.Drawing.Size(185, 33);
            this.IncCatCb.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Gainsboro;
            this.label6.Font = new System.Drawing.Font("Lexend SemiBold", 12.4F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(303, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 33);
            this.label6.TabIndex = 0;
            this.label6.Text = "Categories";
            // 
            // IncDate
            // 
            this.IncDate.Font = new System.Drawing.Font("Century Gothic", 12.4F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.IncDate.Location = new System.Drawing.Point(309, 250);
            this.IncDate.Name = "IncDate";
            this.IncDate.Size = new System.Drawing.Size(174, 33);
            this.IncDate.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Gainsboro;
            this.label7.Font = new System.Drawing.Font("Lexend SemiBold", 12.4F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(303, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 33);
            this.label7.TabIndex = 0;
            this.label7.Text = "Date";
            this.label7.Click += new System.EventHandler(this.label4_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.YellowGreen;
            this.AddBtn.FlatAppearance.BorderSize = 0;
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBtn.Font = new System.Drawing.Font("Lexend SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.AddBtn.Location = new System.Drawing.Point(168, 544);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(200, 55);
            this.AddBtn.TabIndex = 26;
            this.AddBtn.Text = "Add Income";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Gainsboro;
            this.label8.Font = new System.Drawing.Font("Lexend SemiBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(165, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(198, 40);
            this.label8.TabIndex = 0;
            this.label8.Text = "Income Detail";
            this.label8.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.AddBtn);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.IncDate);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.IncCatCb);
            this.panel2.Controls.Add(this.IncDescTb);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.IncAmtTb);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.IncNameTb);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(905, 178);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(527, 647);
            this.panel2.TabIndex = 27;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Controls.Add(this.chart1);
            this.panel3.Location = new System.Drawing.Point(259, 178);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(625, 333);
            this.panel3.TabIndex = 28;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 3);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(619, 330);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            title1.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            title1.Font = new System.Drawing.Font("Lexend SemiBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "Statistics";
            this.chart1.Titles.Add(title1);
            // 
            // Income
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1444, 850);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Total_Income_Dashboard);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Income";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Income_Load);
            this.Total_Income_Dashboard.ResumeLayout(false);
            this.Total_Income_Dashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnExpense;
        private System.Windows.Forms.Panel Total_Income_Dashboard;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label Incm_Trans;
        private System.Windows.Forms.Label Incm_Date;
        private System.Windows.Forms.Label Amt_Income;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnReport;
        private System.Windows.Forms.Button BtnIncome;
        private System.Windows.Forms.Button BtnDashboard;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox IncNameTb;
        private System.Windows.Forms.TextBox IncAmtTb;
        private System.Windows.Forms.TextBox IncDescTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox IncCatCb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker IncDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label TotlInc;
    }
}