using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace TodoLibrary
{
    public class TodoList: List<TodoInfo>
    {
    
        public static TodoList GetTodoList()
        {
            TodoList todoList = new TodoList();
            try
            {
                string connectionString = "Data Source=DESKTOP-0OSLSBL\\SQLEXPRESS;Initial Catalog=Todo;Integrated Security=True";
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = connectionString;
                connection.Open();

                SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "GetAllTodos";
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    TodoInfo newTodo = new TodoInfo();

                    newTodo.TodoID = (int)dataReader["TodoID"];
                    newTodo.TodoName = dataReader["TodoName"].ToString();
                    newTodo.TodoPlainDate = (DateTime)dataReader["TodoPlainDate"];
                    newTodo.TodoIsCompleted = (bool)dataReader["TodoIsCompleted"];

                    todoList.Add(newTodo);
                }

                connection.Close();

            }
            catch (Exception msg)
            {
                Console.WriteLine(msg);
                throw;
            }
            return todoList;
        }
    }
}
