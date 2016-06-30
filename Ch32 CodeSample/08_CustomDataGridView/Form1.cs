using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Configuration;
using System.Data.SqlClient;

namespace CustomDataGridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void getData_Click(object sender, EventArgs e)
        {
            getData.Enabled = false;

            // Select data from the employee table
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["northwind"].ConnectionString))
            {
                string select = "SELECT EmployeeID, FirstName, LastName, Photo, IsNull(ReportsTo,0) as ReportsTo FROM Employees";

                SqlDataAdapter da = new SqlDataAdapter(select, con);

                DataSet ds = new DataSet();

                da.Fill(ds, "Employees");

                select = "SELECT EmployeeID, FirstName + ' ' + LastName as Name FROM Employees union select 0,'(None)'";

                da = new SqlDataAdapter(select, con);
                da.Fill(ds, "Managers");

                // Construct the columns in the grid view
                SetupColumns(ds);

                // Then setup the datasource
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = ds.Tables["Employees"];

                // Now auto-size the rows
                dataGridView1.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
            }
        }


        private void SetupColumns(DataSet ds)
        {
            DataGridViewTextBoxColumn forenameColumn = new DataGridViewTextBoxColumn();
            forenameColumn.DataPropertyName = "FirstName";
            forenameColumn.HeaderText = "Forename";
            forenameColumn.ValueType = typeof(string);
            forenameColumn.Frozen = true;
            dataGridView1.Columns.Add(forenameColumn);

            DataGridViewTextBoxColumn surnameColumn = new DataGridViewTextBoxColumn();
            surnameColumn.DataPropertyName = "LastName";
            surnameColumn.HeaderText = "Surname";
            surnameColumn.Frozen = true;
            surnameColumn.ValueType = typeof(string);
            dataGridView1.Columns.Add(surnameColumn);

            DataGridViewImageColumn photoColumn = new DataGridViewImageColumn();
            photoColumn.DataPropertyName = "Photo";
            photoColumn.Width = 200;
            photoColumn.HeaderText = "Image";
            photoColumn.ReadOnly = true;
            photoColumn.ImageLayout = DataGridViewImageCellLayout.Normal;
            dataGridView1.Columns.Add(photoColumn);

            DataGridViewComboBoxColumn reportsToColumn = new DataGridViewComboBoxColumn();
            reportsToColumn.HeaderText = "Reports To";
            reportsToColumn.DataSource = ds.Tables["Managers"];
            reportsToColumn.DisplayMember = "Name";
            reportsToColumn.ValueMember = "EmployeeID";
            reportsToColumn.DataPropertyName = "ReportsTo";
            dataGridView1.Columns.Add(reportsToColumn);

        }
    }
}