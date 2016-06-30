using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Configuration;

namespace DisplayTabularData
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void displayData_Click(object sender, EventArgs e)
        {
            string customers = "SELECT * FROM Customers";

            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["northwind"].ConnectionString))
            {
                DataSet ds = new DataSet();

                SqlDataAdapter da = new SqlDataAdapter(customers, con);

                da.Fill(ds, "Customers");

                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "Customers";
            }
        }
    }
}