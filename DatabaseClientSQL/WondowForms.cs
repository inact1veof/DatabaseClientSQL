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
            string sqlExpression = "SELECT * FROM Attributes";
            using (ConnectToDatabase.conn)
            {
                ConnectToDatabase.conn.Open();
                SqlCommand command = new SqlCommand(sqlExpression, ConnectToDatabase.conn);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if()
                    }
                }
                reader.Close();
            }
        }
    }
}
