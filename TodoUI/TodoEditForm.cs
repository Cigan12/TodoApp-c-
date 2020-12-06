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
    public partial class TodoEditForm : Form
    {
        public TodoInfo _newTodo = new TodoInfo();
        public TodoEditForm()
        {
            InitializeComponent();
        }

        private void TodoEditForm_Load(object sender, EventArgs e)
        {
            todoInfoBindingSource.DataSource = _newTodo;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveTodoButton_Click(object sender, EventArgs e)
        {
            if(_newTodo.TodoID > 0)
            {
                _newTodo.UpdateTodo();
            } else
            {
                _newTodo.InsertNewTodo();
            }
            Close();
        }
    }
}
