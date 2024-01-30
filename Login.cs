
// Document Level Comment:
// This code represents the login functionality of an Expense Tracker application.
// It includes user authentication against a database and provides UI interactions for login.

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

// Class Level Comment:
// The Login class represents the main form for user authentication and login in the Expense Tracker application.
namespace Expense_Tracker
{
    

    public partial class LoginCls : Form
    {
        // Connection to the database
        string sqlStr = "";
        SqlConnection Con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\ExpenseDB.mdf" +
            ";Integrated Security=True;Connect Timeout=30");

        // Placeholder texts for username and password & Place holder Pattern to validte and ensure .
        string usernamePattern = @"^[a-zA-Z0-9_]{4,}$";
        string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{3,}$";
        string passwordpattern = @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*\W).{5,}$";
        private const string PHT_username = "name@example.com";
        private const string PHT_password = "Atleast 8 letter long";
        private const char PHT_Passchar = '•';
        public LoginCls()
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
        //Clears the fields data on click
        private void clearButton_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPass.Text = "";
            txtUsername.Focus();
        }
        //User mathod to fetch user email
        public static string User;
        private bool Dashboardloads;

        public void loginButton_Click(object sender, EventArgs e)
        {
            // SQL query to check user credentials from Username # password filed in DB table
            sqlStr = "Select *  from [UserTbl] where username ='" + txtUsername.Text + "' and  password='" + txtPass.Text + "'";
            Con.Open();
            SqlCommand cmd1 = new SqlCommand(sqlStr, Con);
            SqlDataReader dr1 = cmd1.ExecuteReader();
            
            if (dr1.Read())
            {
                
                User = txtUsername.Text;
                Dashboardloads = true;
                Dashboard obj =new Dashboard();
                obj.Show();
                this.Hide();
                
              
            }
            else
            {
                //If invalid message popup
                Dashboardloads = false;
                MessageBox.Show("invalidID ");
                txtUsername.Text = "";
                txtPass.Text = "";

            }
            Con.Close();
            //if (txtUsername.Text == "" || txtPass.Text == "" )
            //{
              //  MessageBox.Show("Username Or Password Field Empty", "Login Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //txtUsername.Text = "";
            //txtPass.Text = "";
            //txtUsername.Focus();

        }
        public bool GetDashboardloads()
        {
            return Dashboardloads;
        }

        //password field dot and number showpasword functionanlity
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
        //text changed to show gray color 
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
        // onleave functionlity to check email and password pattern for end to end 
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

        public bool loginButton_Click()
        {
            throw new NotImplementedException();
        }
    }
}
