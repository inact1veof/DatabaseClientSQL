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

namespace DatabaseClientSQL
{
    public partial class WondowForms : Form
    {
        static int count = 1;

        public WondowForms()
        {
            InitializeComponent();
        }

        private void WondowForms_Load(object sender, EventArgs e)
        {
            string sqlExpression = "SELECT * FROM Tables";
            using (ConnectToDatabase.conn)
            {
                ConnectToDatabase.conn.Open();
                SqlCommand command = new SqlCommand(sqlExpression, ConnectToDatabase.conn);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        comboBox1.Items.Add(reader.GetValue(1));
                    }
                }
                reader.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tableName = comboBox1.SelectedItem.ToString();
            string tableID = "";
            string sqlExpression1 = "SELECT * FROM Tables";
            using (ConnectToDatabase.conn)
            {
                ConnectToDatabase.conn.Open();
                SqlCommand command = new SqlCommand(sqlExpression1, ConnectToDatabase.conn);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows) // если есть данные
                {
                    while (reader.Read()) // построчно считываем данные
                    {
                        if (reader.GetString(1) == tableName)
                        {
                            tableID = reader.GetString(0);
                        }
                    }
                }

                reader.Close();
            }

            string sqlExpression2 = "SELECT * FROM Attributes";
            using (ConnectToDatabase.conn)
            {
                ConnectToDatabase.conn.Open();
                SqlCommand command = new SqlCommand(sqlExpression2, ConnectToDatabase.conn);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if(tableID == reader.GetValue(5).ToString())
                        {
                            lbAttribute.Text = reader.GetString(5);
                        }
                    }
                }
                reader.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> attribures = new List<string>();
            string tableName = comboBox1.SelectedItem.ToString();
            string tableID = "";
            string sqlExpression1 = "SELECT * FROM Tables";
            using (ConnectToDatabase.conn)
            {
                ConnectToDatabase.conn.Open();
                SqlCommand command = new SqlCommand(sqlExpression1, ConnectToDatabase.conn);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows) // если есть данные
                {
                    while (reader.Read()) // построчно считываем данные
                    {
                        if (reader.GetString(1) == tableName)
                        {
                            tableID = reader.GetString(0);
                        }
                    }
                }

                reader.Close();
            }
            
            textBox1.Clear();
            string sqlExpression2 = "SELECT Attributes.TableID FROM Attributes";
            using (ConnectToDatabase.conn)
            {
                ConnectToDatabase.conn.Open();
                SqlCommand command = new SqlCommand(sqlExpression2, ConnectToDatabase.conn);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if (tableID == reader.GetValue(5).ToString())
                        {
                            attribures.Add(reader.GetString(5));
                        }
                    }
                }
                reader.Close();
            }
            lbAttribute.Text = attribures[count];
            string sqlExpression3 = $"INSERT INTO [{tableName}] VALUES ({textBox1.Text})";
            using (ConnectToDatabase.conn)
            {
                ConnectToDatabase.conn.Open();
                SqlCommand command = new SqlCommand(sqlExpression3, ConnectToDatabase.conn);
            }
        }
    }
}
