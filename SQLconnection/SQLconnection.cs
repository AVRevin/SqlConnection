using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLconnection
{
    public class SQLconnection
    {
        static string open = "Data Source=tsoop.c6oo9thiejqr.us-east-1.rds.amazonaws.com;Initial" +
             " Catalog=TSOOPEX;User ID=admin;Password=Geirby1799";
        public SqlConnection connection = new SqlConnection(open);

        public SQLconnection()
        {
          
        }

        public void Execute (string text,Form1 form)
        {

            SqlDataAdapter SqlAdapter = new SqlDataAdapter(text, open);

            DataSet setData = new DataSet();
            SqlAdapter.Fill(setData);
            form.dataGridView1.DataSource = setData.Tables[0];

            connection.Close();

        }
    }
}
