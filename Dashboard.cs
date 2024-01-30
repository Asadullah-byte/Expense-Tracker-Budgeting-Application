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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
           GetTotlIncome();
            GetIncTrans();
            LstIncTrans();
            GetTotlExp();
            GetExpTrans();
            LstExpTrans();
            MaxIncome();
            MinIncome();
            lstInc();
            MinExpense();
            MaxExpense();
           
           TtlBalance();
        }

      

       

        private void button4_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Amt_budget_Click(object sender, EventArgs e)
        {

        }

        private void BtnExpense_Click_1(object sender, EventArgs e)
        {

            new Expense().Show();
            this.Hide();
        }

        private void BtnIncome_Click(object sender, EventArgs e)
        {
            new Income().Show();
            this.Hide();
        }

        private void BtnView_Click_1(object sender, EventArgs e)
        {
            new View().Show();
            this.Hide();
        }
        SqlConnection Con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|ExpenseDB.mdf;Integrated Security=True;Connect Timeout=30");
        int Inc, Exp;
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

        private void GetIncTrans()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM [IncomeTbl] WHERE IncUser= '" + LoginCls.User + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            IncTrans.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }
        private void LstIncTrans()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT MAX(IncDate) FROM [IncomeTbl] WHERE IncUser= '" + LoginCls.User + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            LstIncDate.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }
        private void GetTotlExp()
        {
           Con.Open();
           SqlDataAdapter sda = new SqlDataAdapter("SELECT Sum(ExpAmt) FROM [ExpenseTbl] WHERE ExpUser= '" + LoginCls.User + "'", Con);
            DataTable dt = new DataTable();
            
            sda.Fill(dt);
            TotlExp.Text = "RS " + dt.Rows[0][0].ToString();
            Con.Close();
        }

        private void GetExpTrans()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM [ExpenseTbl] WHERE ExpUser= '" + LoginCls.User + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            ExpTrans.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }
        private void LstExpTrans()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT MAX(ExpDate) FROM [ExpenseTbl] WHERE ExpUser= '" + LoginCls.User + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            LstExpDate.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }

        private void MaxIncome()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT MAX(IncAmt) FROM [IncomeTbl] WHERE IncUser= '" + LoginCls.User + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            MaxInc.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }
        private void MinIncome()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT MIN(IncAmt) FROM [IncomeTbl] WHERE IncUser= '" + LoginCls.User + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            MinInc.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }

        private void lstInc()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT TOP 1 [IncAmt]  FROM [IncomeTbl] WHERE IncUser = '" + LoginCls.User + "' ORDER BY IncDate DESC", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            LstInc.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }

        private void TtlBalance()
        {
           

                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT (SELECT ISNULL(SUM(IncAmt), 0) FROM [IncomeTbl] WHERE IncUser= '" + LoginCls.User + "') - (SELECT ISNULL(SUM(ExpAmt), 0) FROM [ExpenseTbl] WHERE ExpUser= '" + LoginCls.User + "') AS CurrentBalance", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Balance.Text = "Rs" +  dt.Rows[0][0].ToString();
            Con.Close();

        }

        private void MinExpense()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT MIN(ExpAmt) from [Expensetbl] WHERE ExpUser= '" + LoginCls.User + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            MinExp.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }

        private void MaxExpense()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT MAX(ExpAmt) FROM [ExpenseTbl] WHERE ExpUser= '" + LoginCls.User + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            MaxExp.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }

    }
   
}
