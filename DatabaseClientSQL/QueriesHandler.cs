using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace DatabaseClientSQL
{
    public static class QueriesHandler
    {
        static string[] KeyWords = new string[] { "SELECT", "WHERE", "GROUP BY" };
        public static void MakeQuery(string InputStringQuery) //оправляем готовый запрос к бд [fixme]: небоходимо добавить обработку результата
        {
            using (ConnectToDatabase.conn)
            {
                SqlCommand command = new SqlCommand();
                command.CommandText = InputStringQuery;
                try
                {
                    ConnectToDatabase.conn.Open();

                    command.ExecuteNonQuery();

                    ConnectToDatabase.conn.Close();

                    System.Windows.Forms.MessageBox.Show("Запрос выполнен");
                }
                catch { System.Windows.Forms.MessageBox.Show("Запрос не выполнен"); }
            }
        }

        public static string MakeStringQuery(int[] TableIDs, int[] AtrIDs) //формирование строки запроса
        {
            string query = "";


            return query;
        }
        public static string ConcatStrins(int[] TableIDs, int[] AtrIDs)
        {
            string result = "";
            return result;
        }
    }
}
