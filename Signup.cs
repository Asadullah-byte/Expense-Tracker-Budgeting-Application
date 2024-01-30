using System;
using System.Drawing;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Expense_Tracker
{
    public partial class Signup : Form
    {
        string randomCode;
        public static String to;

        string usernamePattern = @"^[a-zA-Z0-9_]{4,}$";
        string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{3,}$";
        string passwordpattern = @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*\W).{5,}$";
        private const string PHT_username = "name@example.com";
        private const string PHT_password = "Atleast 8 letter long";
        private const string PHT_conpassword = "Enter Above Password";
        private const char PHT_Passchar = '•';

        public Signup()
        {
            InitializeComponent();
            txtUsername.Text = PHT_username;
            txtUsername.ForeColor = SystemColors.GrayText;

            txtPass.Text = PHT_password;
            txtPass.ForeColor = SystemColors.GrayText;
            txtPass.PasswordChar = '\0';

            txtConPass.Text = PHT_conpassword;
            txtConPass.ForeColor = SystemColors.GrayText;
            txtConPass.PasswordChar = '\0';
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == PHT_username)
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = SystemColors.WindowText;
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (!(Regex.IsMatch(txtUsername.Text, usernamePattern) || Regex.IsMatch(txtUsername.Text, emailPattern)))
            {
                txtUsername.Focus();
                errorProvider1.SetError(this.txtUsername, "Enter Username of Email to proceed");
            }
            else
            {
                errorProvider1.Clear();
                if (string.IsNullOrEmpty(txtUsername.Text))
                {
                    txtUsername.Text = PHT_username;
                    txtUsername.ForeColor = SystemColors.GrayText;
                }
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if (txtUsername.Text == PHT_username)
            {
                txtUsername.ForeColor = SystemColors.WindowText;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtPass.Text, passwordpattern) == false)
            {
                txtPass.Focus();
                errorProvider2.SetError(this.txtPass, "Uppercase, lowercase and Symbol + Numbers combination for Password!");
            }
            else
            {
                errorProvider2.Clear();
                if (string.IsNullOrEmpty(txtPass.Text))
                {
                    txtPass.Text = PHT_password;
                    txtPass.ForeColor = SystemColors.GrayText;
                    txtPass.PasswordChar = '\0';
                }
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == PHT_password)
            {
                txtPass.Text = "";
                txtPass.ForeColor = SystemColors.WindowText;
                txtPass.PasswordChar = PHT_Passchar;
            }
        }

       

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            if (txtPass.Text == PHT_password)
            {
                txtPass.ForeColor = SystemColors.WindowText;
            }
        }

        private void txtConPass_Enter(object sender, EventArgs e)
        {
            if (txtConPass.Text == PHT_conpassword)
            {
                txtConPass.Text = "";
                txtConPass.ForeColor = SystemColors.WindowText;
                txtConPass.PasswordChar = PHT_Passchar;
            }
        }

        private void txtConPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text != txtConPass.Text)
            {
                errorProvider3.SetError(this.txtConPass, "Mismatch Password!");
            }
            else
            {
                errorProvider3.Clear();
                if (string.IsNullOrEmpty(txtConPass.Text))
                {
                    txtConPass.Text = PHT_conpassword;
                    txtConPass.ForeColor = SystemColors.GrayText;
                    txtConPass.PasswordChar = '\0';
                }
            }
        }

        private void txtConPass_TextChanged(object sender, EventArgs e)
        {
            if (txtConPass.Text == PHT_conpassword)
            {
                txtConPass.ForeColor = SystemColors.WindowText;
            }
        }

        private void shwPass_CheckedChanged(object sender, EventArgs e)
        {
            if (shwPass.Checked)
            {
                txtPass.PasswordChar = '\0';
                txtConPass.PasswordChar = '\0';
            }
            else
            {
                txtPass.PasswordChar = PHT_Passchar;
                txtConPass.PasswordChar = PHT_Passchar;
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            txtUsername.Text = PHT_username;
            txtPass.Text = PHT_password;
            txtConPass.Text = PHT_conpassword;
            verifyotp.Text = "";

            txtUsername.Focus();
        }
        private void sendotp_Click_1(object sender, EventArgs e)
        {
           
            // Generate a random 6-digit code as an OTP
            Random random = new Random();
            randomCode = random.Next(100000, 999999).ToString();

            // Ensure that 'to' is not empty before attempting to send the email
            if (!string.IsNullOrEmpty(txtUsername.Text))
            {
                to = txtUsername.Text;

                try
                {
                    String from = "badarbinniaz@gmail.com"; // Replace with your email
                    String pass = "luft rwtu xodc dfqx";   // Replace with your email password
                    String messageBody = "Your OTP code is " + randomCode;

                    MailMessage message = new MailMessage();
                    message.To.Add(to);
                    message.From = new MailAddress(from);
                    message.Body = messageBody;
                    message.Subject = "OTP for verifying";

                    SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                    smtp.EnableSsl = true;
                    smtp.Port = 587;
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.Credentials = new NetworkCredential(from, pass);

                    smtp.Send(message);

                    MessageBox.Show("Code Send Successfully");

                    var result = MessageBox.Show("Code Sent Successfully. Do you want to enter the OTP now?", "OTP Sent", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        // Enable controls for entering OTP
                        verifyotp.Enabled = true;
                        verifybutton.Enabled = true;
                    }
                    else
                    {
                        // Clear fields if the user chooses not to enter OTP immediately
                        ClearFields();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid email address.");
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {
            // Additional code for label2 click event
        }

        private void LOGIN_Click(object sender, EventArgs e)
        {
            new LoginCls().Show();
            this.Hide();
        }

        private void verifybutton_Click_1(object sender, EventArgs e)
        {
            if (randomCode == verifyotp.Text)
            {
                MessageBox.Show("Verification Successful! You can now proceed with registration.");
                // Additional code for successful verification
                SqlConnection Con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|ExpenseDB.mdf;Integrated Security=True;Connect Timeout=30");
                SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[UserTbl]([username],[password]) VALUES ('" + txtUsername.Text + "','" + txtPass.Text + "')", Con);
                Con.Open();
                cmd.ExecuteNonQuery();
                Con.Close();
                MessageBox.Show("Register Successfully");
                ClearFields();
            }
            else
            {
                MessageBox.Show("Wrong Code");
            }
        }
        private void ClearFields()
        {
            // Clear all input fields and disable OTP-related controls
            txtUsername.Text = "";
            txtPass.Text = "";
            txtConPass.Text = "";
            verifyotp.Text = "";
            verifyotp.Enabled = false;
            verifybutton.Enabled = false;
            txtUsername.Focus();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
    }
    



