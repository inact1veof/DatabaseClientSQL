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
    public partial class MainFormShowQueries : Form
    {
        public MainFormShowQueries()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCreateQuery form = new FormCreateQuery();
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                ListQueries.Items.Add(FormCreateQuery.NameOfQuery);
            }
        }

        private void ListQueries_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MainFormShowQueries_Load(object sender, EventArgs e)
        {
            if (ConnectToDatabase.connectionString != null)
            {
                ConnectToDatabase.conn = new SqlConnection(ConfigurationManager.ConnectionStrings[ConnectToDatabase.connectionString].ConnectionString);
                using (ConnectToDatabase.conn)
                {
                    SqlCommand sqlCom = new SqlCommand();
                    SqlDataReader reader;
                    reader = sqlCom.ExecuteReader();
                    sqlCom.CommandText = @"SELECT 'Query.QueryName' FROM 'Queries'";
                    try
                    {
                        ConnectToDatabase.conn.Open();

                        sqlCom.ExecuteNonQuery();
                        while (reader.Read())
                        {
                            ListQueries.Items.Add(reader[0].ToString());
                        }
                        reader.Close();
                        ConnectToDatabase.conn.Close();
                        ;
                    }
                    catch { System.Windows.Forms.MessageBox.Show("Вы не подключились к БД"); }
                }
            }
            else {
                System.Windows.Forms.MessageBox.Show("Вы не подключились к БД");  
            }
        }

        private void ButtonDeleteQuery_Click(object sender, EventArgs e)
        {
            ListQueries.Items.Remove(ListQueries.SelectedItem);
        }

        private void ListQueries_DoubleClick(object sender, EventArgs e)
        {
            ShowQueryResult form = new ShowQueryResult();
            form.ShowDialog();
        }
    }
}
