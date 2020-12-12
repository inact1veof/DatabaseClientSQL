using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace DatabaseClientSQL
{
    class ConnectToDatabase
    {
        SqlConnection conn;

        void Connect() //коннект к базе данных (fixme), не  хватает отбора данных, поодключается только к текущей локальной бд
        {
            string connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Игорь\Desktop\DatabaseClientSQL\DatabaseClientSQL\DatabaseClientSQL\MainDatabase.mdf; Integrated Security = True;";
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings[connectionString].ConnectionString))
            {
                //создаём таблицу таблиц
                //string query1 = "CREATE TABLE Tables" +
                //"(ID UniqueIdentifier CONSTRAINT PKeyid PRIMARY KEY," + "tableName NVARCHAR(30),  description NVARCHAR(50))";  


                SqlCommand sqlCom1 = new SqlCommand();
                sqlCom1.CommandText = @"CREATE TABLE Tables (
                    [TableID]          UNIQUEIDENTIFIER NOT NULL,
                    [TableName]        NVARCHAR (50)    NULL,
                    [TableDescription] NVARCHAR (MAX)   NULL,
                    PRIMARY KEY CLUSTERED ([TableID] ASC)
                )";
                try
                {
                    conn.Open();

                    sqlCom1.ExecuteNonQuery();

                    conn.Close();

                    System.Windows.Forms.MessageBox.Show("Таблица создана");
                }
                catch { System.Windows.Forms.MessageBox.Show("Таблица не создана"); }

                //создаём таблицу атрибутов
                //String query2 = "CREATE TABLE Attributes" +
                //"(ID UniqueIdentifier CONSTRAINT PKeyID PRIMARY KEY," + "attributeName NVARCHAR(30), tableID UniqueIdentifier, limitation NVARCHAR(30), description NVARCHAR(50))";


                SqlCommand sqlCom2 = new SqlCommand();
                sqlCom2.CommandText = @"CREATE TABLE Attributes (
                    [AttributeID]         UNIQUEIDENTIFIER NOT NULL,
                    [AttributeName]       NVARCHAR (50)    NULL,
                    [AttributeLimitation] NVARCHAR (50)    NULL,
                    [AttributeType]       NVARCHAR (50)    NULL,
                    [TableID]             UNIQUEIDENTIFIER NULL,
                    PRIMARY KEY CLUSTERED ([AttributeID] ASC),
                    CONSTRAINT [FK_Attributes_Tables] FOREIGN KEY ([TableID]) REFERENCES [dbo].[Tables] ([TableID])
                )";

                try
                {
                    conn.Open();

                    sqlCom2.ExecuteNonQuery();

                    conn.Close();

                    System.Windows.Forms.MessageBox.Show("Таблица создана");
                }
                catch { System.Windows.Forms.MessageBox.Show("Таблица не создана"); }


                //создаём таблицу связей
                //String query3 = "CREATE TABLE Attributes" +
                //"(ID UniqueIdentifier CONSTRAINT PKeyID PRIMARY KEY," + "connectionType NVARCHAR(30), firstAttributeID UniqueIdentifier, secondAttributeID UniqueIdentifier, description NVARCHAR(50))";


                SqlCommand sqlCom3 = new SqlCommand();
                sqlCom3.CommandText = @"CREATE TABLE Connections (
                    [ConnectionID]      UNIQUEIDENTIFIER NOT NULL,
                    [FirstAttributeID]  UNIQUEIDENTIFIER NULL,
                    [SecondAttributeID] UNIQUEIDENTIFIER NULL,
                    [ConnectionType]    NVARCHAR (50)    NULL,
                    PRIMARY KEY CLUSTERED ([ConnectionID] ASC),
                    CONSTRAINT [FK_Connections_Attributes] FOREIGN KEY ([FirstAttributeID]) REFERENCES [dbo].[Attributes] ([AttributeID])
                )";
                try
                {
                    conn.Open();

                    sqlCom3.ExecuteNonQuery();

                    conn.Close();

                    System.Windows.Forms.MessageBox.Show("Таблица создана");
                }
                catch { System.Windows.Forms.MessageBox.Show("Таблица не создана"); }

            }
        }
    }
}
