using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Configuration;
using System.Data.SqlClient;

namespace ScrollingDataBinding
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void retrieve_Click(object sender, EventArgs e)
        {
            retrieve.Enabled = false;

            ds = CreateDataSet();

            textName.DataBindings.Add("Text", ds, "Products.ProductName");
            textQuan.DataBindings.Add("Text", ds, "Products.QuantityPerUnit");

            trackBar.Minimum = 0;
            trackBar.Maximum = this.BindingContext[ds, "Products"].Count - 1;

            textName.Enabled = true;
            textQuan.Enabled = true;
            trackBar.Enabled = true;
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

        private void trackBar_Scroll(object sender, EventArgs e)
        {
            this.BindingContext[ds, "Products"].Position = trackBar.Value;
        }

        private DataSet ds;
    }
}