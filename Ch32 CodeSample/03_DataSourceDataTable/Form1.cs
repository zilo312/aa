using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Configuration;
using System.Data.SqlClient;

namespace _3_DataSourceDataTable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void getData_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["northwind"].ConnectionString))
            {
                string select = "SELECT * FROM products";

                SqlDataAdapter da = new SqlDataAdapter(select, con);

                DataSet ds = new DataSet();

                da.Fill(ds, "Products");

                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = ds.Tables["Products"];
            }
        }
    }
}