using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseClientSQL
{
    public partial class Form1 : Form
    {
        public string[][] tables = new string[0][];
        public string[][] tempTables;
        public Form1()
        {
            InitializeComponent();
            comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainFormShowQueries form = new MainFormShowQueries();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormToConnect form = new FormToConnect();
            form.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void createTable_Click_1(object sender, EventArgs e)
        {
            createNewTable createNewTable = new createNewTable();
            createNewTable.ShowDialog();
            tempTables = new string[tables.Length + 1][];
            for (int i = 0; i < tables.Length; i++)
            {
                tempTables[i] = new string[tables[i].Length];
                tables[i].CopyTo(tempTables[i], 0);
            }
            tempTables[tempTables.Length - 1] = new string[2];
            tempTables[tempTables.Length - 1][0] = Convert.ToString(createNewTable.tableIndex);
            tempTables[tempTables.Length - 1][1] = createNewTable.tableName;



            tables = new string[tempTables.Length][];
            for (int i = 0; i < tables.Length; i++)
            {
                tables[i] = new string[tempTables[i].Length];
                tempTables[i].CopyTo(tables[i], 0);
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            createAtr createAtr = new createAtr();
            createAtr.ShowDialog();
            string[] temp = new string[tables[createAtr.tableID - 1].Length + 1];
            tables[createAtr.tableID - 1].CopyTo(temp, 0);
            tables[createAtr.tableID - 1] = new string[temp.Length + 1];
            temp.CopyTo(tables[createAtr.tableID - 1], 0);
            tables[createAtr.tableID - 1][tables[createAtr.tableID - 1].Length - 1] = createAtr.attributeName;
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonUpdate_Click_1(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            string[] mas = new string[tables.Length];
            for (int i = 0; i < mas.Length; i++)
                mas[i] = tables[i][1];
            comboBox1.Items.AddRange(mas);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            string s = "";
            for (int i = 0; i < tables[comboBox1.SelectedIndex].Length; i++)
                s += tables[comboBox1.SelectedIndex][i] + "\n";
            MessageBox.Show(s, tables[comboBox1.SelectedIndex][1]);
        }

        private void btnForms_Click(object sender, EventArgs e)
        {
            WondowForms newForm = new WondowForms();
            newForm.ShowDialog();
        }
    }
}
