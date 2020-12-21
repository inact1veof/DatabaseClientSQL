using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace DatabaseClientSQL
{
    public partial class ShowQueryResult : Form
    {
        public ShowQueryResult()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ShowQueryResult_Load(object sender, EventArgs e)
        {
            if (ConnectToDatabase.connectionString != null)
            {
                ConnectToDatabase.conn = new SqlConnection(ConfigurationManager.ConnectionStrings[ConnectToDatabase.connectionString].ConnectionString);
                using (ConnectToDatabase.conn)
                {
                    SqlCommand sqlCom = new SqlCommand();
                    sqlCom.CommandText = @"SELECT 'Queries.QueryText' FROM 'Queries'";
                    try
                    {
                        ConnectToDatabase.conn.Open();

                        sqlCom.ExecuteNonQuery();
                        SqlDataAdapter Adapter = new SqlDataAdapter(sqlCom);
                        DataTable tbl = new DataTable();
                        Adapter.Fill(tbl);
                        dataGridView1.DataSource = tbl;
                        ConnectToDatabase.conn.Close();
                        ;
                    }
                    catch { System.Windows.Forms.MessageBox.Show("Вы не подключились к БД"); }
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Вы не подключились к БД");
            }
        }
    }
}
