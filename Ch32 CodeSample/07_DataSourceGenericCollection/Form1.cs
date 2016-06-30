using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DataSourceGenericCollection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void getData_Click(object sender, EventArgs e)
        {
            PersonList people = new PersonList();

            people.Add(new Person("Fred", Sex.Male, new DateTime(1970, 12, 14)));
            people.Add(new Person("Bill", Sex.Male, new DateTime(1976, 10, 29)));
            people.Add(new Person("Jack", Sex.Male, new DateTime(1945, 5, 17)));
            people.Add(new Person("Jane", Sex.Female, new DateTime(1982, 1, 3)));

            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = people;
        }
    }
}