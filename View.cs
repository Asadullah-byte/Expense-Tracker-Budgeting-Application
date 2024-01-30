using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.DirectoryServices.Protocols;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Expense_Tracker
{
    public partial class View : Form
    {
        public View()
        {
            InitializeComponent();
            DisplayIncomes();
            DisplayExpense();
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {

        }

       

        private void Cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DisplayIncomes()
        {
            Con.Open();
            string Query = "SELECT * FROM IncomeTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            IncomeDGV.DataSource = ds.Tables[0];
            Con.Close();

        }
        SqlConnection Con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|ExpenseDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void DisplayExpense()
        {
            Con.Open();
            string Query = "SELECT * FROM ExpenseTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ExpenseDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void BtnExpense_Click(object sender, EventArgs e)
        {
            new Expense().Show();
            this.Hide();
        }
    }
}
