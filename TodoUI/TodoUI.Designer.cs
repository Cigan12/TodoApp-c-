
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
            this.todoListDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.todoListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.todoListDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.todoListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // addNewTodoButton
            // 
            this.addNewTodoButton.Location = new System.Drawing.Point(78, 292);
            this.addNewTodoButton.Name = "addNewTodoButton";
            this.addNewTodoButton.Size = new System.Drawing.Size(75, 23);
            this.addNewTodoButton.TabIndex = 0;
            this.addNewTodoButton.Text = "add";
            this.addNewTodoButton.UseVisualStyleBackColor = true;
            this.addNewTodoButton.Click += new System.EventHandler(this.addNewTodoButton_Click);
            // 
            // editTodoButton
            // 
            this.editTodoButton.Location = new System.Drawing.Point(185, 292);
            this.editTodoButton.Name = "editTodoButton";
            this.editTodoButton.Size = new System.Drawing.Size(75, 23);
            this.editTodoButton.TabIndex = 1;
            this.editTodoButton.Text = "edit";
            this.editTodoButton.UseVisualStyleBackColor = true;
            this.editTodoButton.Click += new System.EventHandler(this.editTodoButton_Click);
            // 
            // removeTodoButton
            // 
            this.removeTodoButton.Location = new System.Drawing.Point(294, 292);
            this.removeTodoButton.Name = "removeTodoButton";
            this.removeTodoButton.Size = new System.Drawing.Size(75, 23);
            this.removeTodoButton.TabIndex = 2;
            this.removeTodoButton.Text = "remove";
            this.removeTodoButton.UseVisualStyleBackColor = true;
            this.removeTodoButton.Click += new System.EventHandler(this.removeTodoButton_Click);
            // 
            // todoListDataGridView
            // 
            this.todoListDataGridView.AllowUserToAddRows = false;
            this.todoListDataGridView.AllowUserToDeleteRows = false;
            this.todoListDataGridView.AutoGenerateColumns = false;
            this.todoListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.todoListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewCheckBoxColumn1});
            this.todoListDataGridView.DataSource = this.todoListBindingSource;
            this.todoListDataGridView.Location = new System.Drawing.Point(36, 45);
            this.todoListDataGridView.Name = "todoListDataGridView";
            this.todoListDataGridView.ReadOnly = true;
            this.todoListDataGridView.RowHeadersWidth = 51;
            this.todoListDataGridView.RowTemplate.Height = 24;
            this.todoListDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.todoListDataGridView.Size = new System.Drawing.Size(598, 220);
            this.todoListDataGridView.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TodoID";
            this.dataGridViewTextBoxColumn1.HeaderText = "TodoID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TodoName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Что сделать";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TodoPlainDate";
            this.dataGridViewTextBoxColumn3.HeaderText = "Планируемая дата";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "TodoIsCompleted";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Выполнено";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Width = 125;
            // 
            // todoListBindingSource
            // 
            this.todoListBindingSource.DataSource = typeof(TodoLibrary.TodoInfo);
            // 
            // TodoUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 676);
            this.Controls.Add(this.todoListDataGridView);
            this.Controls.Add(this.removeTodoButton);
            this.Controls.Add(this.editTodoButton);
            this.Controls.Add(this.addNewTodoButton);
            this.Name = "TodoUI";
            this.Text = "Todo Form";
            this.Load += new System.EventHandler(this.TodoUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.todoListDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.todoListBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addNewTodoButton;
        private System.Windows.Forms.Button editTodoButton;
        private System.Windows.Forms.Button removeTodoButton;
        private System.Windows.Forms.BindingSource todoListBindingSource;
        private System.Windows.Forms.DataGridView todoListDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
    }
}