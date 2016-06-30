using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Configuration;
using System.Data.SqlClient;

namespace DataSourceDataSet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void getData_Click(object sender, EventArgs e)
        {
            string orders = "SELECT * FROM Orders";
            string customers = "SELECT * FROM Customers";

            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["northwind"].ConnectionString))
            {
                DataSet ds = new DataSet();

                SqlDataAdapter da = new SqlDataAdapter(customers, con);
                da.Fill(ds, "Customers");

                da = new SqlDataAdapter(orders, con);
                da.Fill(ds, "Orders");

                ds.Relations.Add("CustomerOrders",
                    ds.Tables["Customers"].Columns["CustomerID"],
                    ds.Tables["Orders"].Columns["CustomerID"]);

                dataGrid1.SetDataBinding(ds, "Customers");
            }
        }
    }
}