using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Expense_Tracker
{
    public partial class Income : Form
    {
        public Income()
        {
            InitializeComponent();
            GetTotlIncome();
        }

        private void Total_Income_Dashboard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Incm_Trans_Click(object sender, EventArgs e)
        {

        }

        private void Incm_Date_Click(object sender, EventArgs e)
        {

        }

        private void Amt_Income_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void BtnReport_Click(object sender, EventArgs e)
        {
            new View().Show();
            this.Hide();
        }

        private void BtnIncome_Click(object sender, EventArgs e)
        {

        }

        private void BtnExpense_Click(object sender, EventArgs e)
        {
            new Expense().Show();
            this.Hide();
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Income_Load(object sender, EventArgs e)
        {

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        SqlConnection Con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|ExpenseDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void Clear()
        {
            IncNameTb.Text = "";
            IncAmtTb.Text = "";
            IncCatCb.SelectedIndex = 0;
            IncDescTb.Text = "";
        }

        private void GetTotlIncome()
        {
            Con.Open();
            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|ExpenseDB.mdf;Integrated Security=True;Connect Timeout=30"))
            {


                SqlDataAdapter sda = new SqlDataAdapter("SELECT Sum(IncAmt) FROM [IncomeTbl] WHERE IncUser= '" + LoginCls.User + "'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                TotlInc.Text = "RS " + dt.Rows[0][0].ToString();
                Con.Close();
            }
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            if(IncNameTb.Text == "" || IncAmtTb.Text == "" || IncDescTb.Text == "" || IncCatCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information!");
            }
            else
            {

                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[IncomeTbl]([IncName],[IncAmt],[IncCat],[IncDate],[IncDesc],[IncUser]) VALUES (@IN,@IA,@IC,@ID,@IDe,@IU)",Con);
                    cmd.Parameters.AddWithValue("@IN", IncNameTb.Text);
                    cmd.Parameters.AddWithValue("@IA", IncAmtTb.Text);
                    cmd.Parameters.AddWithValue("@IC", IncCatCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@ID", IncDate.Value.Date);
                    cmd.Parameters.AddWithValue("@IDe",IncDescTb.Text);
                    cmd.Parameters.AddWithValue("@IU", LoginCls.User);
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    Clear();
                }
                catch (Exception ex) 
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
