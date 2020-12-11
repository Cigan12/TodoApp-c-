
namespace TodoUI
{
    partial class TodoEditForm
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
            System.Windows.Forms.Label todoNameLabel;
            System.Windows.Forms.Label todoPlainDateLabel;
            System.Windows.Forms.Label todoIsCompletedLabel;
            System.Windows.Forms.Label todoCategoryIDLabel;
            System.Windows.Forms.Label todoImportanceIDLabel;
            this.todoNameTextBox = new System.Windows.Forms.TextBox();
            this.todoInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.todoPlainDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.todoIsCompletedCheckBox = new System.Windows.Forms.CheckBox();
            this.saveTodoButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.todoCategoryIDComboBox = new System.Windows.Forms.ComboBox();
            this.categoryListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.todoImportanceIDComboBox = new System.Windows.Forms.ComboBox();
            this.importanceListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            todoNameLabel = new System.Windows.Forms.Label();
            todoPlainDateLabel = new System.Windows.Forms.Label();
            todoIsCompletedLabel = new System.Windows.Forms.Label();
            todoCategoryIDLabel = new System.Windows.Forms.Label();
            todoImportanceIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.todoInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.importanceListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // todoNameLabel
            // 
            todoNameLabel.AutoSize = true;
            todoNameLabel.Location = new System.Drawing.Point(54, 57);
            todoNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            todoNameLabel.Name = "todoNameLabel";
            todoNameLabel.Size = new System.Drawing.Size(104, 13);
            todoNameLabel.TabIndex = 1;
            todoNameLabel.Text = "Что нужно сделать";
            // 
            // todoPlainDateLabel
            // 
            todoPlainDateLabel.AutoSize = true;
            todoPlainDateLabel.Location = new System.Drawing.Point(54, 104);
            todoPlainDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            todoPlainDateLabel.Name = "todoPlainDateLabel";
            todoPlainDateLabel.Size = new System.Drawing.Size(37, 13);
            todoPlainDateLabel.TabIndex = 3;
            todoPlainDateLabel.Text = "Когда";
            // 
            // todoIsCompletedLabel
            // 
            todoIsCompletedLabel.AutoSize = true;
            todoIsCompletedLabel.Location = new System.Drawing.Point(54, 150);
            todoIsCompletedLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            todoIsCompletedLabel.Name = "todoIsCompletedLabel";
            todoIsCompletedLabel.Size = new System.Drawing.Size(56, 13);
            todoIsCompletedLabel.TabIndex = 4;
            todoIsCompletedLabel.Text = "Сделано?";
            // 
            // todoCategoryIDLabel
            // 
            todoCategoryIDLabel.AutoSize = true;
            todoCategoryIDLabel.Location = new System.Drawing.Point(58, 194);
            todoCategoryIDLabel.Name = "todoCategoryIDLabel";
            todoCategoryIDLabel.Size = new System.Drawing.Size(94, 13);
            todoCategoryIDLabel.TabIndex = 8;
            todoCategoryIDLabel.Text = "Todo Category ID:";
            // 
            // todoImportanceIDLabel
            // 
            todoImportanceIDLabel.AutoSize = true;
            todoImportanceIDLabel.Location = new System.Drawing.Point(67, 232);
            todoImportanceIDLabel.Name = "todoImportanceIDLabel";
            todoImportanceIDLabel.Size = new System.Drawing.Size(105, 13);
            todoImportanceIDLabel.TabIndex = 10;
            todoImportanceIDLabel.Text = "Todo Importance ID:";
            // 
            // todoNameTextBox
            // 
            this.todoNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.todoInfoBindingSource, "TodoName", true));
            this.todoNameTextBox.Location = new System.Drawing.Point(184, 56);
            this.todoNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.todoNameTextBox.Name = "todoNameTextBox";
            this.todoNameTextBox.Size = new System.Drawing.Size(204, 20);
            this.todoNameTextBox.TabIndex = 2;
            // 
            // todoInfoBindingSource
            // 
            this.todoInfoBindingSource.DataSource = typeof(TodoLibrary.TodoInfo);
            // 
            // todoPlainDateDateTimePicker
            // 
            this.todoPlainDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.todoInfoBindingSource, "TodoPlainDate", true));
            this.todoPlainDateDateTimePicker.Location = new System.Drawing.Point(184, 100);
            this.todoPlainDateDateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.todoPlainDateDateTimePicker.Name = "todoPlainDateDateTimePicker";
            this.todoPlainDateDateTimePicker.Size = new System.Drawing.Size(204, 20);
            this.todoPlainDateDateTimePicker.TabIndex = 4;
            // 
            // todoIsCompletedCheckBox
            // 
            this.todoIsCompletedCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.todoInfoBindingSource, "TodoIsCompleted", true));
            this.todoIsCompletedCheckBox.Location = new System.Drawing.Point(184, 147);
            this.todoIsCompletedCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.todoIsCompletedCheckBox.Name = "todoIsCompletedCheckBox";
            this.todoIsCompletedCheckBox.Size = new System.Drawing.Size(78, 20);
            this.todoIsCompletedCheckBox.TabIndex = 5;
            this.todoIsCompletedCheckBox.UseVisualStyleBackColor = true;
            // 
            // saveTodoButton
            // 
            this.saveTodoButton.Location = new System.Drawing.Point(50, 269);
            this.saveTodoButton.Margin = new System.Windows.Forms.Padding(2);
            this.saveTodoButton.Name = "saveTodoButton";
            this.saveTodoButton.Size = new System.Drawing.Size(73, 35);
            this.saveTodoButton.TabIndex = 6;
            this.saveTodoButton.Text = "Сохранить";
            this.saveTodoButton.UseVisualStyleBackColor = true;
            this.saveTodoButton.Click += new System.EventHandler(this.saveTodoButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(153, 269);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(74, 35);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // todoCategoryIDComboBox
            // 
            this.todoCategoryIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.todoInfoBindingSource, "TodoCategoryID", true));
            this.todoCategoryIDComboBox.DataSource = this.categoryListBindingSource;
            this.todoCategoryIDComboBox.DisplayMember = "CategoryName";
            this.todoCategoryIDComboBox.FormattingEnabled = true;
            this.todoCategoryIDComboBox.Location = new System.Drawing.Point(184, 186);
            this.todoCategoryIDComboBox.Name = "todoCategoryIDComboBox";
            this.todoCategoryIDComboBox.Size = new System.Drawing.Size(204, 21);
            this.todoCategoryIDComboBox.TabIndex = 9;
            this.todoCategoryIDComboBox.ValueMember = "CategoryID";
            // 
            // categoryListBindingSource
            // 
            this.categoryListBindingSource.DataSource = typeof(TodoLibrary.CategoryList);
            // 
            // todoImportanceIDComboBox
            // 
            this.todoImportanceIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.todoInfoBindingSource, "TodoImportanceID", true));
            this.todoImportanceIDComboBox.DataSource = this.importanceListBindingSource;
            this.todoImportanceIDComboBox.DisplayMember = "ImportanceName";
            this.todoImportanceIDComboBox.FormattingEnabled = true;
            this.todoImportanceIDComboBox.Location = new System.Drawing.Point(184, 229);
            this.todoImportanceIDComboBox.Name = "todoImportanceIDComboBox";
            this.todoImportanceIDComboBox.Size = new System.Drawing.Size(204, 21);
            this.todoImportanceIDComboBox.TabIndex = 11;
            this.todoImportanceIDComboBox.ValueMember = "ImportanceID";
            // 
            // importanceListBindingSource
            // 
            this.importanceListBindingSource.DataSource = typeof(TodoLibrary.ImportanceList);
            // 
            // TodoEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 384);
            this.Controls.Add(todoImportanceIDLabel);
            this.Controls.Add(this.todoImportanceIDComboBox);
            this.Controls.Add(todoCategoryIDLabel);
            this.Controls.Add(this.todoCategoryIDComboBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveTodoButton);
            this.Controls.Add(todoIsCompletedLabel);
            this.Controls.Add(this.todoIsCompletedCheckBox);
            this.Controls.Add(todoPlainDateLabel);
            this.Controls.Add(this.todoPlainDateDateTimePicker);
            this.Controls.Add(todoNameLabel);
            this.Controls.Add(this.todoNameTextBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TodoEditForm";
            this.Text = "Edit form";
            this.Load += new System.EventHandler(this.TodoEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.todoInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.importanceListBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource todoInfoBindingSource;
        private System.Windows.Forms.TextBox todoNameTextBox;
        private System.Windows.Forms.DateTimePicker todoPlainDateDateTimePicker;
        private System.Windows.Forms.CheckBox todoIsCompletedCheckBox;
        private System.Windows.Forms.Button saveTodoButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ComboBox todoCategoryIDComboBox;
        private System.Windows.Forms.BindingSource categoryListBindingSource;
        private System.Windows.Forms.ComboBox todoImportanceIDComboBox;
        private System.Windows.Forms.BindingSource importanceListBindingSource;
    }
}