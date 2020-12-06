using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TodoLibrary;


namespace TodoUI
{
    public partial class TodoUI : Form
    {
        TodoList _todoList = new TodoList();

        public TodoUI()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Load interface
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TodoUI_Load(object sender, EventArgs e)
        {
            RefreshTodos();
        }
        /// <summary>
        /// Refresh todos
        /// </summary>
        void RefreshTodos()
        {
            _todoList = TodoList.GetTodoList();
            //todoListBindingSource.DataSource = null;
            todoListBindingSource.DataSource = _todoList;
        }

        private void addNewTodoButton_Click(object sender, EventArgs e)
        {
            TodoEditForm newTodoEditForm = new TodoEditForm();
            newTodoEditForm.ShowDialog();
            RefreshTodos();
        }

        private void removeTodoButton_Click(object sender, EventArgs e)
        {
            int todoID = (int)todoListDataGridView.SelectedRows[0].Cells[0].Value;

            foreach (TodoInfo todo in _todoList)
            {
                if(todo.TodoID == todoID)
                {
                    todo.DeleteTodo();
                }
                RefreshTodos();
            }
        }

        private void editTodoButton_Click(object sender, EventArgs e)
        {
            int todoID = (int)todoListDataGridView.SelectedRows[0].Cells[0].Value;
            TodoEditForm todoEditForm = new TodoEditForm();
            foreach (TodoInfo todo in _todoList)
            {
                if (todo.TodoID == todoID)
                {
                    todo.GetTodo(todoID);
                    todoEditForm._newTodo = todo;
                }
                
               
            }
            todoEditForm.ShowDialog();
            RefreshTodos();
        }
    }
}
