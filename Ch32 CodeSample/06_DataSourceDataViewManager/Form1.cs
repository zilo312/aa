using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Configuration;
using System.Data.SqlClient;

namespace DataSourceDataViewManager
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

                SqlDataAdapter da = new SqlDataAdapter(orders, con);

                DataSet ds = new DataSet();

                da.Fill(ds, "Orders");

                da = new SqlDataAdapter(customers, con);

                da.Fill(ds, "Customers");

                ds.Relations.Add("CustomerOrders",
                    ds.Tables["Customers"].Columns["CustomerID"],
                    ds.Tables["Orders"].Columns["CustomerID"]);

                DataViewManager dvm = new DataViewManager(ds);

                dvm.DataViewSettings["Customers"].RowFilter = "Country='UK'";

                dataGrid1.SetDataBinding(dvm, "Customers");
            }
        }
    }
}