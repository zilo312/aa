using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Configuration;
using System.Data.SqlClient;

namespace SimpleDataBinding
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Generate the dataset
            DataSet ds = CreateDataSet();

            // And bind the textbox to the ProductName column
            textBox1.DataBindings.Add("Text", ds.Tables["Products"], "ProductName");
        }

        private DataSet CreateDataSet()
        {
            string customers = "SELECT * FROM Products";
            DataSet ds = new DataSet();

            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["northwind"].ConnectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(customers, con);

                da.Fill(ds, "Products");
            }

            return ds;
        }
    }
}