using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _2_DataSourceArray
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void getData_Click(object sender, EventArgs e)
        {
            // Uncomment to see what happens with strings...
            //string[] items = new string[] { "One", "Two", "Three" };

            Item[] items = new Item[] { new Item ( "One" ) , 
										 new Item ( "Two" ) , 
										 new Item ( "Three" ) };

            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = items;
        }

        protected class Item
        {
            public Item(string text)
            {
                m_text = text;
            }

            public string Text
            {
                get { return m_text; }
            }

            private string m_text;
        }

    }
}