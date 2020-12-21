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
    public partial class FormCreateQuery : Form
    {
        public static string query;
        public static string NameOfQuery;
        public FormCreateQuery()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NameOfQuery = textBoxQueryName.Text;
            if (ConnectToDatabase.connectionString != null)
            {
                ConnectToDatabase.conn = new SqlConnection(ConfigurationManager.ConnectionStrings[ConnectToDatabase.connectionString].ConnectionString);
                using (ConnectToDatabase.conn)
                {
                    SqlCommand sqlCom = new SqlCommand();
                    SqlDataReader reader;
                    reader = sqlCom.ExecuteReader();
                    sqlCom.CommandText = $"INSERT INTO 'Queries' VALUES ({NameOfQuery}, {query});";
                    try
                    {
                        ConnectToDatabase.conn.Open();
                        sqlCom.ExecuteNonQuery();
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBoxForSQL.Visible = false;
            label2.Visible = true;
            label3.Visible = true;
            listBoxAtrArr.Visible = true;
            listBoxTablesArr.Visible = true;
        }

        private void buttonUsingSQL_Click(object sender, EventArgs e)
        {
            textBoxForSQL.Visible = true;
            label2.Visible = false;
            label3.Visible = false;
            listBoxAtrArr.Visible = false;
            listBoxTablesArr.Visible = false;
        }

        private void FormCreateQuery_Load(object sender, EventArgs e)
        {
            if (ConnectToDatabase.connectionString != null)
            {
                ConnectToDatabase.conn = new SqlConnection(ConfigurationManager.ConnectionStrings[ConnectToDatabase.connectionString].ConnectionString);
                using (ConnectToDatabase.conn)
                {
                    SqlCommand sqlCom = new SqlCommand();
                    SqlDataReader reader;
                    reader = sqlCom.ExecuteReader();
                    sqlCom.CommandText = @"SELECT 'Tables.TableName' FROM 'Tables';";
                    try
                    {
                        ConnectToDatabase.conn.Open();

                        sqlCom.ExecuteNonQuery();
                        while (reader.Read())
                        {
                            listBoxTablesArr.Items.Add(reader[0].ToString());
                        }
                        reader.Close();
                        ConnectToDatabase.conn.Close();
                        ;
                    }
                    catch { System.Windows.Forms.MessageBox.Show("Вы не подключились к БД"); }
                    SqlCommand sqlCom1 = new SqlCommand();
                    SqlDataReader reader1;
                    reader1 = sqlCom.ExecuteReader();
                    sqlCom1.CommandText = @"SELECT 'Attributes.AttributeName' FROM 'Attributes';";
                    try
                    {
                        ConnectToDatabase.conn.Open();

                        sqlCom1.ExecuteNonQuery();
                        while (reader1.Read())
                        {
                            listBoxTablesArr.Items.Add(reader1[0].ToString());
                        }
                        reader1.Close();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
