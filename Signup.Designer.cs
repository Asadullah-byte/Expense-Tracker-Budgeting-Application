namespace Expense_Tracker
{
    partial class Signup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signup));
            this.button1 = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UN_Label = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.Pass_Label = new System.Windows.Forms.Label();
            this.txtConPass = new System.Windows.Forms.TextBox();
            this.ConPass_Label = new System.Windows.Forms.Label();
            this.shwPass = new System.Windows.Forms.CheckBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.sendotp = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.LOGIN = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.verifyotp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.verifybutton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.LightGray;
            this.button1.Location = new System.Drawing.Point(417, 12);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.Gainsboro;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(41, 244);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(391, 39);
            this.txtUsername.TabIndex = 2;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            this.txtUsername.Enter += new System.EventHandler(this.txtUsername_Enter);
            this.txtUsername.Leave += new System.EventHandler(this.txtUsername_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lexend SemiBold", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.GreenYellow;
            this.label1.Location = new System.Drawing.Point(124, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 58);
            this.label1.TabIndex = 7;
            this.label1.Text = "Get Started";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // UN_Label
            // 
            this.UN_Label.AutoSize = true;
            this.UN_Label.Font = new System.Drawing.Font("Lexend SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UN_Label.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.UN_Label.Location = new System.Drawing.Point(37, 213);
            this.UN_Label.Name = "UN_Label";
            this.UN_Label.Size = new System.Drawing.Size(64, 29);
            this.UN_Label.TabIndex = 8;
            this.UN_Label.Text = "Email";
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.Gainsboro;
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPass.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(41, 324);
            this.txtPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPass.Multiline = true;
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '•';
            this.txtPass.Size = new System.Drawing.Size(391, 42);
            this.txtPass.TabIndex = 3;
            this.txtPass.TextChanged += new System.EventHandler(this.txtPass_TextChanged);
            this.txtPass.Enter += new System.EventHandler(this.txtPass_Enter);
            this.txtPass.Leave += new System.EventHandler(this.txtPass_Leave);
            // 
            // Pass_Label
            // 
            this.Pass_Label.AutoSize = true;
            this.Pass_Label.Font = new System.Drawing.Font("Lexend SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pass_Label.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Pass_Label.Location = new System.Drawing.Point(37, 292);
            this.Pass_Label.Name = "Pass_Label";
            this.Pass_Label.Size = new System.Drawing.Size(101, 29);
            this.Pass_Label.TabIndex = 8;
            this.Pass_Label.Text = "Password";
            // 
            // txtConPass
            // 
            this.txtConPass.BackColor = System.Drawing.Color.Gainsboro;
            this.txtConPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConPass.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConPass.Location = new System.Drawing.Point(42, 413);
            this.txtConPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtConPass.Multiline = true;
            this.txtConPass.Name = "txtConPass";
            this.txtConPass.PasswordChar = '•';
            this.txtConPass.Size = new System.Drawing.Size(391, 40);
            this.txtConPass.TabIndex = 4;
            this.txtConPass.TextChanged += new System.EventHandler(this.txtConPass_TextChanged);
            this.txtConPass.Enter += new System.EventHandler(this.txtConPass_Enter);
            this.txtConPass.Leave += new System.EventHandler(this.txtConPass_Leave);
            // 
            // ConPass_Label
            // 
            this.ConPass_Label.AutoSize = true;
            this.ConPass_Label.Font = new System.Drawing.Font("Lexend SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConPass_Label.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ConPass_Label.Location = new System.Drawing.Point(38, 382);
            this.ConPass_Label.Name = "ConPass_Label";
            this.ConPass_Label.Size = new System.Drawing.Size(179, 29);
            this.ConPass_Label.TabIndex = 8;
            this.ConPass_Label.Text = "Confirm Password";
            // 
            // shwPass
            // 
            this.shwPass.AutoSize = true;
            this.shwPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shwPass.Font = new System.Drawing.Font("Lexend SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shwPass.ForeColor = System.Drawing.Color.White;
            this.shwPass.Location = new System.Drawing.Point(263, 457);
            this.shwPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.shwPass.Name = "shwPass";
            this.shwPass.Size = new System.Drawing.Size(173, 33);
            this.shwPass.TabIndex = 5;
            this.shwPass.Text = "Show Password";
            this.shwPass.UseVisualStyleBackColor = true;
            this.shwPass.CheckedChanged += new System.EventHandler(this.shwPass_CheckedChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            this.errorProvider2.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider2.Icon")));
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            this.errorProvider3.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider3.Icon")));
            // 
            // sendotp
            // 
            this.sendotp.BackColor = System.Drawing.Color.GreenYellow;
            this.sendotp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sendotp.FlatAppearance.BorderSize = 0;
            this.sendotp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendotp.Font = new System.Drawing.Font("Lexend SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendotp.ForeColor = System.Drawing.Color.White;
            this.sendotp.Location = new System.Drawing.Point(107, 496);
            this.sendotp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sendotp.Name = "sendotp";
            this.sendotp.Size = new System.Drawing.Size(260, 59);
            this.sendotp.TabIndex = 6;
            this.sendotp.Text = "SEND OTP";
            this.sendotp.UseVisualStyleBackColor = false;
            this.sendotp.Click += new System.EventHandler(this.sendotp_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lexend SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(114, 799);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Already have an account?";
            // 
            // LOGIN
            // 
            this.LOGIN.AutoSize = true;
            this.LOGIN.BackColor = System.Drawing.Color.Transparent;
            this.LOGIN.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LOGIN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LOGIN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LOGIN.Font = new System.Drawing.Font("Lexend SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LOGIN.ForeColor = System.Drawing.Color.GreenYellow;
            this.LOGIN.Location = new System.Drawing.Point(205, 839);
            this.LOGIN.Name = "LOGIN";
            this.LOGIN.Size = new System.Drawing.Size(74, 29);
            this.LOGIN.TabIndex = 8;
            this.LOGIN.Text = "LOGIN\r\n";
            this.LOGIN.Click += new System.EventHandler(this.LOGIN_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.Ivory;
            this.clearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearButton.FlatAppearance.BorderColor = System.Drawing.Color.GreenYellow;
            this.clearButton.FlatAppearance.BorderSize = 3;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Font = new System.Drawing.Font("Lexend SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.ForeColor = System.Drawing.Color.GreenYellow;
            this.clearButton.Location = new System.Drawing.Point(107, 737);
            this.clearButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(260, 60);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "CLEAR";
            this.clearButton.UseVisualStyleBackColor = false;
            // 
            // verifyotp
            // 
            this.verifyotp.BackColor = System.Drawing.Color.Gainsboro;
            this.verifyotp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.verifyotp.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verifyotp.Location = new System.Drawing.Point(41, 604);
            this.verifyotp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.verifyotp.Multiline = true;
            this.verifyotp.Name = "verifyotp";
            this.verifyotp.PasswordChar = '•';
            this.verifyotp.Size = new System.Drawing.Size(391, 40);
            this.verifyotp.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lexend SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(36, 573);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 29);
            this.label3.TabIndex = 10;
            this.label3.Text = "OTP";
            // 
            // verifybutton
            // 
            this.verifybutton.BackColor = System.Drawing.Color.GreenYellow;
            this.verifybutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.verifybutton.FlatAppearance.BorderSize = 0;
            this.verifybutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.verifybutton.Font = new System.Drawing.Font("Lexend SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verifybutton.ForeColor = System.Drawing.Color.White;
            this.verifybutton.Location = new System.Drawing.Point(107, 663);
            this.verifybutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.verifybutton.Name = "verifybutton";
            this.verifybutton.Size = new System.Drawing.Size(260, 59);
            this.verifybutton.TabIndex = 11;
            this.verifybutton.Text = "VERIFY";
            this.verifybutton.UseVisualStyleBackColor = false;
            this.verifybutton.Click += new System.EventHandler(this.verifybutton_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Expense_Tracker.Properties.Resources.icons8_budget_641;
            this.pictureBox1.Location = new System.Drawing.Point(181, 34);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(472, 877);
            this.Controls.Add(this.verifybutton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.verifyotp);
            this.Controls.Add(this.LOGIN);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.sendotp);
            this.Controls.Add(this.shwPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ConPass_Label);
            this.Controls.Add(this.Pass_Label);
            this.Controls.Add(this.UN_Label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtConPass);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.Silver;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Signup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label UN_Label;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label Pass_Label;
        private System.Windows.Forms.TextBox txtConPass;
        private System.Windows.Forms.Label ConPass_Label;
        private System.Windows.Forms.CheckBox shwPass;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.Button sendotp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LOGIN;
        private System.Windows.Forms.Button verifybutton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox verifyotp;
        private System.Windows.Forms.Button clearButton;
    }
}

