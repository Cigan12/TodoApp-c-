using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoLibrary
{

    public class ImportanceList : List<ImportanceInfo>
    {
        public static ImportanceList GetDefaultImportanceList()
        {
            ImportanceList myList = new ImportanceList();
            try
            {
                string connectionString = "Data Source=DESKTOP-0OSLSBL\\SQLEXPRESS;Initial Catalog=Todo;Integrated Security=True";
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = connectionString;
                connection.Open();

                SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "GetImportanceList";
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    ImportanceInfo importance = new ImportanceInfo();

                    importance.ImportanceID = (int)dataReader["ImportanceID"];
                    importance.ImportanceName = dataReader["ImportanceName"].ToString();


                    myList.Add(importance);
                }

                connection.Close();

            }
            catch (Exception msg)
            {
                Console.WriteLine(msg);
                throw;
            }
            return myList;
        }
    }
}
