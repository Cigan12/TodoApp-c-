
namespace TodoUI
{
    partial class TodoUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.addNewTodoButton = new System.Windows.Forms.Button();
            this.editTodoButton = new System.Windows.Forms.Button();
            this.removeTodoButton = new System.Windows.Forms.Button();
            this.todoListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.todoListDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.todoListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.todoListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // addNewTodoButton
            // 
            this.addNewTodoButton.Location = new System.Drawing.Point(21, 379);
            this.addNewTodoButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addNewTodoButton.Name = "addNewTodoButton";
            this.addNewTodoButton.Size = new System.Drawing.Size(56, 19);
            this.addNewTodoButton.TabIndex = 0;
            this.addNewTodoButton.Text = "add";
            this.addNewTodoButton.UseVisualStyleBackColor = true;
            this.addNewTodoButton.Click += new System.EventHandler(this.addNewTodoButton_Click);
            // 
            // editTodoButton
            // 
            this.editTodoButton.Location = new System.Drawing.Point(102, 379);
            this.editTodoButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.editTodoButton.Name = "editTodoButton";
            this.editTodoButton.Size = new System.Drawing.Size(56, 19);
            this.editTodoButton.TabIndex = 1;
            this.editTodoButton.Text = "edit";
            this.editTodoButton.UseVisualStyleBackColor = true;
            this.editTodoButton.Click += new System.EventHandler(this.editTodoButton_Click);
            // 
            // removeTodoButton
            // 
            this.removeTodoButton.Location = new System.Drawing.Point(183, 379);
            this.removeTodoButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.removeTodoButton.Name = "removeTodoButton";
            this.removeTodoButton.Size = new System.Drawing.Size(56, 19);
            this.removeTodoButton.TabIndex = 2;
            this.removeTodoButton.Text = "remove";
            this.removeTodoButton.UseVisualStyleBackColor = true;
            this.removeTodoButton.Click += new System.EventHandler(this.removeTodoButton_Click);
            // 
            // todoListBindingSource
            // 
            this.todoListBindingSource.DataSource = typeof(TodoLibrary.TodoInfo);
            // 
            // todoListDataGridView
            // 
            this.todoListDataGridView.AllowUserToAddRows = false;
            this.todoListDataGridView.AllowUserToDeleteRows = false;
            this.todoListDataGridView.AutoGenerateColumns = false;
            this.todoListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.todoListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewCheckBoxColumn1});
            this.todoListDataGridView.DataSource = this.todoListBindingSource;
            this.todoListDataGridView.Location = new System.Drawing.Point(12, 22);
            this.todoListDataGridView.Name = "todoListDataGridView";
            this.todoListDataGridView.ReadOnly = true;
            this.todoListDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.todoListDataGridView.Size = new System.Drawing.Size(523, 244);
            this.todoListDataGridView.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TodoID";
            this.dataGridViewTextBoxColumn5.HeaderText = "TodoID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TodoImportanceID";
            this.dataGridViewTextBoxColumn1.HeaderText = "TodoImportanceID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TodoCategoryID";
            this.dataGridViewTextBoxColumn3.HeaderText = "TodoCategoryID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "TodoName";
            this.dataGridViewTextBoxColumn6.HeaderText = "Название";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CategoryName";
            this.dataGridViewTextBoxColumn4.HeaderText = "Категория";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ImportanceName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Степень важности";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "TodoPlainDate";
            this.dataGridViewTextBoxColumn7.HeaderText = "Плановая дата";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "TodoIsCompleted";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Выполнено";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // TodoUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 549);
            this.Controls.Add(this.todoListDataGridView);
            this.Controls.Add(this.removeTodoButton);
            this.Controls.Add(this.editTodoButton);
            this.Controls.Add(this.addNewTodoButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TodoUI";
            this.Text = "Todo Form";
            this.Load += new System.EventHandler(this.TodoUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.todoListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.todoListDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addNewTodoButton;
        private System.Windows.Forms.Button editTodoButton;
        private System.Windows.Forms.Button removeTodoButton;
        private System.Windows.Forms.BindingSource todoListBindingSource;
        private System.Windows.Forms.DataGridView todoListDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
    }
}