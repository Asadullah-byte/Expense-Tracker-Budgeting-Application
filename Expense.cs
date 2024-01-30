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
    public partial class Expense : Form
    {
        public Expense()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            
        }

    

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void BtnDashboard_MouseHover(object sender, EventArgs e)
        {
          // BtnDashboard.ForeColor = Color.;
        }

       

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void label4_Click(object sender, EventArgs e)
        {

        }

      

        private void DashboardBtn_Click(object sender, EventArgs e)
        {
            new Dashboard().Show();
            this.Hide();
        }

        SqlConnection Con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|ExpenseDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void Clear()
        {
            ExpNameTb.Text = "";
            ExpAmtTb.Text = "";
            ExpCatCb.SelectedIndex = 0;
            ExpDescTb.Text = "";
        }
        private void Btn_submit_Click(object sender, EventArgs e)
        {
            if (ExpNameTb.Text == "" || ExpAmtTb.Text == "" || ExpDescTb.Text == "" || ExpCatCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information!");
            }
            else
            {

                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[ExpenseTbl]([ExpName],[ExpAmt],[ExpCat],[ExpDate],[ExpDesc],[ExpUser]) VALUES (@EN,@EA,@EC,@ED,@EDe,@EU)", Con);
                    cmd.Parameters.AddWithValue("@EN", ExpNameTb.Text);
                    cmd.Parameters.AddWithValue("@EA", ExpAmtTb.Text);
                    cmd.Parameters.AddWithValue("@EC", ExpCatCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@ED", ExpDate.Value.Date);
                    cmd.Parameters.AddWithValue("@EDe", ExpDescTb.Text);
                    cmd.Parameters.AddWithValue("@EU", LoginCls.User);
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

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            new Dashboard().Show();
            this.Hide();
        }

        private void BtnIncome_Click(object sender, EventArgs e)
        {
            new Income().Show();
            this.Hide();
        }

        private void BtnView_Click(object sender, EventArgs e)
        {
            new View().Show();
            this.Hide();    
        }
    }
}
