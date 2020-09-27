using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLconnection
{
    public partial class Form1 : Form
    {
        SQLconnection sqlconnection = new SQLconnection();
        public Form1()
        {
            InitializeComponent();

        }      
        private void button1_Click(object sender, EventArgs e)
        {
            sqlconnection.Execute("SELECT TOP (1000) [AddressID],[AddressLine1],[AddressLine2]" +
                ",[City],[StateProvinceID],[PostalCode],[rowguid],[ModifiedDate] FROM[TSOOPEX].[Person].[Address]", this);

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataBaseConnectionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            sqlconnection.Execute("SELECT TOP (1000) [BusinessEntityID],[EmailAddressID],[EmailAddress],[rowguid],[ModifiedDate] FROM[TSOOPEX].[Person].[EmailAddress]", this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sqlconnection.Execute("SELECT TOP (1000) [ContactTypeID],[Name],[ModifiedDate] FROM[TSOOPEX].[Person].[ContactType]", this);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sqlconnection.Execute("SELECT TOP (1000) [PhoneNumberTypeID],[Name],[ModifiedDate] FROM[TSOOPEX].[Person].[PhoneNumberType]", this);
        }
    }
}
