using System;
using System.Collections.Generic;
using System.IO;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace test
{
    class SQLData
    {
        public static string connectionString;
        public static SqlConnection connection;
        public static SqlCommand command;    // формирователь запроса / создатель
        public static SqlDataReader reader; // считывалка

        /// <summary>
        ///  Проверка соединения
        /// </summary>
        public static void CheckConnection()
        {
            try
            {
                connectionString = 
                    @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" +
                    Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName) +
                    @"\NFdb.mdf;Integrated Security=True;MultipleActiveResultSets=true";
                connection = new SqlConnection(connectionString);
                connection.Open();
            }
            catch (Exception e)
            {
                
                MessageBox.Show("Невозможно установить соединение с базой данных.\n" + e.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(1); // закрывает программу
            }
        }
    }
}
