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
    public partial class createAtr : Form
    {
        public createAtr()
        {
            InitializeComponent();
        }
        public bool check;
        public int attributeID, tableID;
        public string attributeName, attributeLimitation, attributeType;
        private void button1_Click(object sender, EventArgs e)
        {
            check = true;
            attributeID = Convert.ToInt32(textBox1.Text);
            attributeName = textBox2.Text;
            attributeLimitation = textBox3.Text;
            attributeType = textBox4.Text;
            tableID = Convert.ToInt32(textBox5.Text);
            try
            {
                using (ConnectToDatabase.conn)
                {
                    SqlCommand createAttributeString = new SqlCommand("INSERT INTO [Attributes] (AttributeID, AttributeName, AttributeLimitation, AttributeType, TableID) VALUES (@AttributeID, @AttributeName, @AttributeLimitation, @AttributeType, @TableID)", ConnectToDatabase.conn);
                    createAttributeString.Parameters.AddWithValue("AttributeID", attributeID);
                    createAttributeString.Parameters.AddWithValue("AttributeName", attributeName);
                    createAttributeString.Parameters.AddWithValue("AttributeLimitation", attributeLimitation);
                    createAttributeString.Parameters.AddWithValue("AttributeType", attributeType);
                    createAttributeString.Parameters.AddWithValue("TableID", tableID);
                    createAttributeString.ExecuteNonQuery();
                    ConnectToDatabase.conn.Close();

                    SqlCommand createTable = new SqlCommand();
                    createTable.CommandText = $@"ALTER TABLE {tableID} ADD {attributeID} INT NULL, {attributeID} VARCHAR(20) NULL, {attributeName} VARCHAR(20) NULL, {attributeLimitation} VARCHAR(20) NULL, {attributeType} VARCHAR(20) NULL, {tableID} INT NULL";
                    try
                    {
                        ConnectToDatabase.conn.Open();
                        createTable.ExecuteNonQuery();
                        ConnectToDatabase.conn.Close();
                        System.Windows.Forms.MessageBox.Show("Атрибут добавлен");
                    }
                    catch { check = false; }
                }
            }
            catch {check = false; };
        }
    }
}
