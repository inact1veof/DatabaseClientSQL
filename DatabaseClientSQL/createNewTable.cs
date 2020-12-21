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
    public partial class createNewTable : Form
    {
        public createNewTable()
        {
            InitializeComponent();
        }

        public bool check;
        public int tableIndex;
        public string tableName, tableDescription;
        private void button1_Click(object sender, EventArgs e)
        {
            check = true;
            tableIndex = Convert.ToInt32(textBox1.Text);
            tableName = textBox2.Text;
            tableDescription = textBox3.Text;
            try
            {
                using (ConnectToDatabase.conn)
                {
                    SqlCommand createTableString = new SqlCommand("INSERT INTO [Tables] (TableID, TableName, TableDescription) VALUES (@TableID, @TableName, @TableDescription)", ConnectToDatabase.conn);
                    createTableString.Parameters.AddWithValue("TableID", tableIndex);
                    createTableString.Parameters.AddWithValue("TableName", tableName);
                    createTableString.Parameters.AddWithValue("TableDescription", tableDescription);
                    createTableString.ExecuteNonQuery();
                    ConnectToDatabase.conn.Close();

                    SqlCommand createTable = new SqlCommand();
                    createTable.CommandText = $@"CREATE TABLE {tableName} Tables ()";
                    try
                    {
                        ConnectToDatabase.conn.Open();
                        createTable.ExecuteNonQuery();
                        ConnectToDatabase.conn.Close();
                        System.Windows.Forms.MessageBox.Show("Таблица создана");
                    }
                    catch { check = false; }
                }
            }
            catch { check = false; };
        }
    }
}
