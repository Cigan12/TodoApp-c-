using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoLibrary
{
    public class CategoryList : List<CategoryInfo>
    {
        public static CategoryList GetDefaultCategoryList()
        {
            CategoryList myList = new CategoryList();
            try
            {
                string connectionString = "Data Source=DESKTOP-0OSLSBL\\SQLEXPRESS;Initial Catalog=Todo;Integrated Security=True";
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = connectionString;
                connection.Open();

                SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "GetCategoryList";
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    CategoryInfo category= new CategoryInfo();

                    category.CategoryID = (int)dataReader["CategoryID"];
                    category.CategoryName = dataReader["CategoryName"].ToString();


                    myList.Add(category);
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
