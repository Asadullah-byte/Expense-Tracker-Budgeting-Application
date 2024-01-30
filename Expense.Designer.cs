namespace Expense_Tracker
{
    partial class Expense
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnView = new System.Windows.Forms.Button();
            this.BtnIncome = new System.Windows.Forms.Button();
            this.BtnExpense = new System.Windows.Forms.Button();
            this.BtnDashboard = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LblWelcome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Amt_budget = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Ttl_Spend = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.U_Owe = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Btn_submit = new System.Windows.Forms.Button();
            this.ExpDate = new System.Windows.Forms.DateTimePicker();
            this.ExpCatCb = new System.Windows.Forms.ComboBox();
            this.ExpDescTb = new System.Windows.Forms.TextBox();
            this.ExpAmtTb = new System.Windows.Forms.TextBox();
            this.ExpNameTb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Activites = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel8 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.button4);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1444, 50);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Image = global::Expense_Tracker.Properties.Resources.closebtn22;
            this.button4.Location = new System.Drawing.Point(1381, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(60, 47);
            this.button4.TabIndex = 6;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.DashboardBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.BtnView);
            this.panel1.Controls.Add(this.BtnIncome);
            this.panel1.Controls.Add(this.BtnExpense);
            this.panel1.Controls.Add(this.BtnDashboard);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 800);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // BtnView
            // 
            this.BtnView.BackColor = System.Drawing.Color.Transparent;
            this.BtnView.FlatAppearance.BorderSize = 0;
            this.BtnView.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtnView.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnView.Font = new System.Drawing.Font("Lexend SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnView.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnView.Image = global::Expense_Tracker.Properties.Resources.pie_chart;
            this.BtnView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnView.Location = new System.Drawing.Point(3, 537);
            this.BtnView.Name = "BtnView";
            this.BtnView.Size = new System.Drawing.Size(231, 64);
            this.BtnView.TabIndex = 11;
            this.BtnView.Text = "View";
            this.BtnView.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnView.UseVisualStyleBackColor = false;
            this.BtnView.Click += new System.EventHandler(this.BtnView_Click);
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
            this.BtnIncome.TabIndex = 12;
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
            this.BtnExpense.ForeColor = System.Drawing.Color.GreenYellow;
            this.BtnExpense.Image = global::Expense_Tracker.Properties.Resources.expenses;
            this.BtnExpense.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnExpense.Location = new System.Drawing.Point(3, 317);
            this.BtnExpense.Name = "BtnExpense";
            this.BtnExpense.Size = new System.Drawing.Size(231, 64);
            this.BtnExpense.TabIndex = 13;
            this.BtnExpense.Text = "Expenses";
            this.BtnExpense.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnExpense.UseVisualStyleBackColor = false;
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
            this.BtnDashboard.TabIndex = 14;
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
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
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
            // LblWelcome
            // 
            this.LblWelcome.AutoSize = true;
            this.LblWelcome.Font = new System.Drawing.Font("Lexend SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblWelcome.ForeColor = System.Drawing.Color.Black;
            this.LblWelcome.Location = new System.Drawing.Point(268, 79);
            this.LblWelcome.Name = "LblWelcome";
            this.LblWelcome.Size = new System.Drawing.Size(156, 45);
            this.LblWelcome.TabIndex = 3;
            this.LblWelcome.Text = "Welcome ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lexend SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(270, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hi";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.Amt_budget);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(276, 143);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(213, 100);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Amt_budget
            // 
            this.Amt_budget.AutoSize = true;
            this.Amt_budget.BackColor = System.Drawing.Color.Gainsboro;
            this.Amt_budget.Font = new System.Drawing.Font("Lexend SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amt_budget.Location = new System.Drawing.Point(59, 30);
            this.Amt_budget.Name = "Amt_budget";
            this.Amt_budget.Size = new System.Drawing.Size(89, 45);
            this.Amt_budget.TabIndex = 0;
            this.Amt_budget.Text = "1000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gainsboro;
            this.label3.Font = new System.Drawing.Font("Lexend SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 27);
            this.label3.TabIndex = 0;
            this.label3.Text = "Total Budget\r\n";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Controls.Add(this.Ttl_Spend);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(511, 143);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(205, 100);
            this.panel3.TabIndex = 4;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // Ttl_Spend
            // 
            this.Ttl_Spend.AutoSize = true;
            this.Ttl_Spend.BackColor = System.Drawing.Color.Gainsboro;
            this.Ttl_Spend.Font = new System.Drawing.Font("Lexend SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ttl_Spend.Location = new System.Drawing.Point(66, 30);
            this.Ttl_Spend.Name = "Ttl_Spend";
            this.Ttl_Spend.Size = new System.Drawing.Size(72, 45);
            this.Ttl_Spend.TabIndex = 0;
            this.Ttl_Spend.Text = "300";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Gainsboro;
            this.label4.Font = new System.Drawing.Font("Lexend SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 27);
            this.label4.TabIndex = 0;
            this.label4.Text = "Total Spend";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gainsboro;
            this.panel4.Controls.Add(this.U_Owe);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(738, 143);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(205, 100);
            this.panel4.TabIndex = 4;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // U_Owe
            // 
            this.U_Owe.AutoSize = true;
            this.U_Owe.BackColor = System.Drawing.Color.Gainsboro;
            this.U_Owe.Font = new System.Drawing.Font("Lexend SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.U_Owe.Location = new System.Drawing.Point(66, 30);
            this.U_Owe.Name = "U_Owe";
            this.U_Owe.Size = new System.Drawing.Size(72, 45);
            this.U_Owe.TabIndex = 0;
            this.U_Owe.Text = "500";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Gainsboro;
            this.label6.Font = new System.Drawing.Font("Lexend SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 27);
            this.label6.TabIndex = 0;
            this.label6.Text = "You Owe";
            this.label6.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lexend SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 27);
            this.label5.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gainsboro;
            this.panel5.Controls.Add(this.Btn_submit);
            this.panel5.Controls.Add(this.ExpDate);
            this.panel5.Controls.Add(this.ExpCatCb);
            this.panel5.Controls.Add(this.ExpDescTb);
            this.panel5.Controls.Add(this.ExpAmtTb);
            this.panel5.Controls.Add(this.ExpNameTb);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.Activites);
            this.panel5.Location = new System.Drawing.Point(967, 143);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(446, 676);
            this.panel5.TabIndex = 4;
            // 
            // Btn_submit
            // 
            this.Btn_submit.BackColor = System.Drawing.Color.YellowGreen;
            this.Btn_submit.FlatAppearance.BorderSize = 0;
            this.Btn_submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_submit.Font = new System.Drawing.Font("Lexend SemiBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_submit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Btn_submit.Location = new System.Drawing.Point(135, 594);
            this.Btn_submit.Name = "Btn_submit";
            this.Btn_submit.Size = new System.Drawing.Size(167, 46);
            this.Btn_submit.TabIndex = 38;
            this.Btn_submit.Text = "Add Income";
            this.Btn_submit.UseVisualStyleBackColor = false;
            this.Btn_submit.Click += new System.EventHandler(this.Btn_submit_Click);
            // 
            // ExpDate
            // 
            this.ExpDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ExpDate.Location = new System.Drawing.Point(22, 330);
            this.ExpDate.Name = "ExpDate";
            this.ExpDate.Size = new System.Drawing.Size(181, 32);
            this.ExpDate.TabIndex = 37;
            // 
            // ExpCatCb
            // 
            this.ExpCatCb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ExpCatCb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpCatCb.ForeColor = System.Drawing.Color.Black;
            this.ExpCatCb.FormattingEnabled = true;
            this.ExpCatCb.Items.AddRange(new object[] {
            "House",
            "Groceries",
            "Shopping",
            "Friends",
            "Health/Medics",
            "Travel",
            "Vehicle",
            "Others.."});
            this.ExpCatCb.Location = new System.Drawing.Point(244, 112);
            this.ExpCatCb.Name = "ExpCatCb";
            this.ExpCatCb.Size = new System.Drawing.Size(181, 31);
            this.ExpCatCb.TabIndex = 36;
            // 
            // ExpDescTb
            // 
            this.ExpDescTb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ExpDescTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ExpDescTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpDescTb.ForeColor = System.Drawing.Color.Black;
            this.ExpDescTb.Location = new System.Drawing.Point(22, 428);
            this.ExpDescTb.Multiline = true;
            this.ExpDescTb.Name = "ExpDescTb";
            this.ExpDescTb.Size = new System.Drawing.Size(388, 133);
            this.ExpDescTb.TabIndex = 33;
            // 
            // ExpAmtTb
            // 
            this.ExpAmtTb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ExpAmtTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ExpAmtTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpAmtTb.ForeColor = System.Drawing.Color.Black;
            this.ExpAmtTb.Location = new System.Drawing.Point(22, 224);
            this.ExpAmtTb.Multiline = true;
            this.ExpAmtTb.Name = "ExpAmtTb";
            this.ExpAmtTb.Size = new System.Drawing.Size(181, 40);
            this.ExpAmtTb.TabIndex = 34;
            // 
            // ExpNameTb
            // 
            this.ExpNameTb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ExpNameTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ExpNameTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpNameTb.ForeColor = System.Drawing.Color.Black;
            this.ExpNameTb.Location = new System.Drawing.Point(25, 112);
            this.ExpNameTb.Multiline = true;
            this.ExpNameTb.Name = "ExpNameTb";
            this.ExpNameTb.Size = new System.Drawing.Size(181, 40);
            this.ExpNameTb.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Gainsboro;
            this.label7.Font = new System.Drawing.Font("Lexend SemiBold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 395);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 30);
            this.label7.TabIndex = 28;
            this.label7.Text = "Description";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Gainsboro;
            this.label9.Font = new System.Drawing.Font("Lexend SemiBold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(17, 298);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 30);
            this.label9.TabIndex = 29;
            this.label9.Text = "Date";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Gainsboro;
            this.label10.Font = new System.Drawing.Font("Lexend SemiBold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(20, 184);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 30);
            this.label10.TabIndex = 30;
            this.label10.Text = "Amount";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Gainsboro;
            this.label11.Font = new System.Drawing.Font("Lexend SemiBold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(239, 70);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 30);
            this.label11.TabIndex = 31;
            this.label11.Text = "Categories";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Gainsboro;
            this.label12.Font = new System.Drawing.Font("Lexend SemiBold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(25, 70);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(153, 30);
            this.label12.TabIndex = 32;
            this.label12.Text = "Expense Name";
            // 
            // Activites
            // 
            this.Activites.BackColor = System.Drawing.Color.Gainsboro;
            this.Activites.FlatAppearance.BorderSize = 0;
            this.Activites.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Activites.Font = new System.Drawing.Font("Lexend SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Activites.ForeColor = System.Drawing.Color.Black;
            this.Activites.Location = new System.Drawing.Point(3, 3);
            this.Activites.Name = "Activites";
            this.Activites.Size = new System.Drawing.Size(188, 48);
            this.Activites.TabIndex = 4;
            this.Activites.Text = "Add Expense";
            this.Activites.UseVisualStyleBackColor = false;
            this.Activites.MouseHover += new System.EventHandler(this.BtnDashboard_MouseHover);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel6.Controls.Add(this.chart1);
            this.panel6.Location = new System.Drawing.Point(276, 265);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(667, 283);
            this.panel6.TabIndex = 4;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Gainsboro;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(667, 283);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            title1.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title1.Font = new System.Drawing.Font("Lexend SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "Expense Statistics";
            this.chart1.Titles.Add(title1);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Gainsboro;
            this.panel8.Controls.Add(this.dataGridView2);
            this.panel8.Controls.Add(this.button1);
            this.panel8.Location = new System.Drawing.Point(276, 570);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(667, 249);
            this.panel8.TabIndex = 4;
            this.panel8.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // dataGridView2
            // 
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(20, 47);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(626, 186);
            this.dataGridView2.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Lexend SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 48);
            this.button1.TabIndex = 4;
            this.button1.Text = "Friends";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.MouseHover += new System.EventHandler(this.BtnDashboard_MouseHover);
            // 
            // Expense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1444, 850);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblWelcome);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Expense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblWelcome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button Activites;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label Amt_budget;
        private System.Windows.Forms.Label Ttl_Spend;
        private System.Windows.Forms.Label U_Owe;
        private System.Windows.Forms.Button Btn_submit;
        private System.Windows.Forms.DateTimePicker ExpDate;
        private System.Windows.Forms.ComboBox ExpCatCb;
        private System.Windows.Forms.TextBox ExpDescTb;
        private System.Windows.Forms.TextBox ExpAmtTb;
        private System.Windows.Forms.TextBox ExpNameTb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button BtnView;
        private System.Windows.Forms.Button BtnIncome;
        private System.Windows.Forms.Button BtnExpense;
        private System.Windows.Forms.Button BtnDashboard;
    }
}