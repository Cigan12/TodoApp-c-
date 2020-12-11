using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoLibrary
{
    public class TodoInfo
    {
        private int _todoID = 0;
        private string _todoName = "";
        private DateTime _todoPlainDate = DateTime.Today;
        private bool _todoIsCompleted = false;
        private int _todoCategoryID = 0;
        private string _categoryName = "";
        private int _todoImportanceID = 0;
        private string _importanceName = "";

        public int TodoImportanceID
        {
            get
            {
                return _todoImportanceID;
            }
            set
            {
                _todoImportanceID = value;
            }
        }

        public string ImportanceName
        {
            get
            {
                return _importanceName;

            }
            set
            {
                _importanceName = value;
            }
        }

        public int TodoCategoryID
        {
            get
            {
                return _todoCategoryID;
            }
            set
            {
                _todoCategoryID = value;
            }
        }

        public string CategoryName
        {
            get
            {
                return _categoryName;
            }
            set
            {

                _categoryName = value;
            }
        }

        public int TodoID {
            get {
                return _todoID;
            } 
            set {
                _todoID = value;
            } 
        }

        public string TodoName
        {
            get
            {
                return _todoName;
            }
            set
            {
                _todoName = value;
            }
        }

        public DateTime TodoPlainDate
        {
            get
            {
                return _todoPlainDate;
            }
            set
            {
                _todoPlainDate = value;
            }
        }

        public bool TodoIsCompleted
        {
            get
            {
                return _todoIsCompleted;
            }
            set
            {
                _todoIsCompleted = value;
            }
        }



        public void InsertNewTodo()
        {
  
            try
            {
                string connectionString = "Data Source=DESKTOP-0OSLSBL\\SQLEXPRESS;Initial Catalog=Todo;Integrated Security=True";
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = connectionString;
                connection.Open();

                SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "InsertIntoTodos";

                command.Parameters.Add(new SqlParameter("@TodoName", _todoName));
                command.Parameters.Add(new SqlParameter("@TodoPlainDate", _todoPlainDate));
                command.Parameters.Add(new SqlParameter("@TodoIsCompleted", _todoIsCompleted));
                command.Parameters.Add(new SqlParameter("@CategoryID", _todoCategoryID));
                command.Parameters.Add(new SqlParameter("@ImportanceID", _todoImportanceID));

                command.ExecuteNonQuery();

                connection.Close();

            }
            catch (Exception msg)
            {
                Console.WriteLine(msg);
                throw;
            }
        }

        public void DeleteTodo()
        {

            try
            {
                string connectionString = "Data Source=DESKTOP-0OSLSBL\\SQLEXPRESS;Initial Catalog=Todo;Integrated Security=True";
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = connectionString;
                connection.Open();

                SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "DeleteTodos";

                command.Parameters.Add(new SqlParameter("@TodoID", _todoID));

                command.ExecuteNonQuery();

                connection.Close();

            }
            catch (Exception msg)
            {
                Console.WriteLine(msg);
                throw;
            }
        }


        public void UpdateTodo()
        {

            try
            {
                string connectionString = "Data Source=DESKTOP-0OSLSBL\\SQLEXPRESS;Initial Catalog=Todo;Integrated Security=True";
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = connectionString;
                connection.Open();

                SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "UpdateTodo";


                command.Parameters.Add(new SqlParameter("@TodoID", _todoID));
                command.Parameters.Add(new SqlParameter("@TodoName", _todoName));
                command.Parameters.Add(new SqlParameter("@TodoPlainDate", _todoPlainDate));
                command.Parameters.Add(new SqlParameter("@TodoIsCompleted", _todoIsCompleted));
                command.Parameters.Add(new SqlParameter("@CategoryID", _todoCategoryID));
                command.Parameters.Add(new SqlParameter("@ImportanceID", _todoImportanceID));

                command.ExecuteNonQuery();

                connection.Close();

            }
            catch (Exception msg)
            {
                Console.WriteLine(msg);
                throw;
            }
        }

        public void GetTodo(int TodoID)
        {

            try
            {
                string connectionString = "Data Source=DESKTOP-0OSLSBL\\SQLEXPRESS;Initial Catalog=Todo;Integrated Security=True";
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = connectionString;
                connection.Open();

                SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "GetTodo";


                command.Parameters.Add(new SqlParameter("@TodoID", _todoID));

                SqlDataReader dataReader = command.ExecuteReader();

                while(dataReader.Read())
                {
                    _todoID = (int)dataReader["TodoID"];
                    _todoName = dataReader["TodoName"].ToString();
                    _todoPlainDate = (DateTime)dataReader["TodoPlainDate"];
                    _todoIsCompleted = (bool)dataReader["TodoIsCompleted"];

                }


                connection.Close();

            }
            catch (Exception msg)
            {
                Console.WriteLine(msg);
                throw;
            }
        }
    }
}
