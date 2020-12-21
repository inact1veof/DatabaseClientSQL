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
    public partial class FormToConnect : Form
    {
        public static string addres;
        public static string database;
        public static string user;
        public static string password;
        public FormToConnect()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FormToConnect_Load(object sender, EventArgs e)
        {

        }

        private void buttonStartConnect_Click(object sender, EventArgs e)
        {
            addres = textBoxAdress.Text;
            database = textBoxDatabase.Text;
            user = textBoxUser.Text;
            password = textBoxUserPassword.Text;
            ConnectToDatabase.Connect();
        }
    }
}
