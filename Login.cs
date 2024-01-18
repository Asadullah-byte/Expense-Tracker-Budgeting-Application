using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;
using System.Data.SqlTypes;


namespace Expense_Tracker
{
    public partial class Login : Form
    {
        string sqlStr = "";
        SqlConnection Conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=B:\\SCD\\Database1.mdf;Integrated Security=True");

        string usernamePattern = @"^[a-zA-Z0-9_]{4,}$";
        string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{3,}$";
        string passwordpattern = @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*\W).{5,}$";
        private const string PHT_username = "name@example.com";
        private const string PHT_password = "Atleast 8 letter long";
        private const char PHT_Passchar = '•';
        public Login()
        {
            InitializeComponent();
            txtUsername.Text = PHT_username;
            txtUsername.ForeColor = SystemColors.GrayText;

            txtPass.Text = PHT_password;
            txtPass.ForeColor = SystemColors.GrayText;
            txtPass.PasswordChar = '\0';
        }
        
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPass.Text = "";
            txtUsername.Focus();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            sqlStr = "Select *  from [Table] where username ='" + txtUsername.Text + "' and  password='" + txtPass.Text + "'";
            Conn.Open();
            SqlCommand cmd1 = new SqlCommand(sqlStr, Conn);
            SqlDataReader dr1 = cmd1.ExecuteReader();
            if (dr1.Read())
            {

                MessageBox.Show("login Successfull");
               
            }
            else
            {
                MessageBox.Show("invalidID ");
            }
            Conn.Close();
            //if (txtUsername.Text == "" || txtPass.Text == "" )
            //{
              //  MessageBox.Show("Username Or Password Field Empty", "Login Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //txtUsername.Text = "";
            //txtPass.Text = "";
            //txtUsername.Focus();

        }

        private void shwPass_CheckedChanged(object sender, EventArgs e)
        {
            if (shwPass.Checked)
            {

                txtPass.PasswordChar = '\0';
                
            }
            else
            {

                txtPass.PasswordChar = PHT_Passchar;
               
            }
        }

        

        private void ConPass_Label_Click(object sender, EventArgs e)
        {

        }

        private void Pass_Label_Click(object sender, EventArgs e)
        {

        }

        private void UN_Label_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtConPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            if (txtPass.Text == PHT_password)
            {
                txtPass.ForeColor = SystemColors.WindowText;
            }
           
        }

         private void txtUsername_Enter(object sender, EventArgs e)
            {
                if (txtUsername.Text == PHT_username)
                {

                    txtUsername.Text = "";  // Empty string (Before == "name@example")
                    txtUsername.ForeColor = SystemColors.WindowText; //window.text == Black color

                }
            }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (!(Regex.IsMatch(txtUsername.Text, emailPattern))) //Regex == Text validation
               
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

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

      
        private void SIGNUP_Click(object sender, EventArgs e)
        {
            new Signup().Show();
            this.Hide();
        }


        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtPass.Text, passwordpattern) == false)
            {
                txtPass.Focus();
                errorProvider2.SetError(this.txtPass, "Uppercase, lowercase and Symbol + Numbers combintion for Password!");
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
    }
}
