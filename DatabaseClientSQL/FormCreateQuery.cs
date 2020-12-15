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
    public partial class FormCreateQuery : Form
    {
        public FormCreateQuery()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int CountTables = 10;
            int CountAtr = 10;
            int[] tables = new int[CountTables];
            int[] att = new int[CountAtr];
            string query = null;
            query = QueriesHandler.MakeStringQuery(tables, att);
            QueriesHandler.MakeQuery(query);
            this.Close();
        }
    }
}
