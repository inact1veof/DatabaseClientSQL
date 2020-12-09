using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DatabaseClientSQL
{
    class ConnectToDatabase
    {
        SqlConnection database;

        void Connect() //коннект к базе данных (fixme), не  хватает отбора данных, поодключается только к текущей локальной бд
        {
            string connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Игорь\Desktop\DatabaseClientSQL\DatabaseClientSQL\DatabaseClientSQL\MainDatabase.mdf; Integrated Security = True;";
            database = new SqlConnection(connectionString);

        }
    }
}
