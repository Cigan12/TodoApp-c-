
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
            this.todoNameTextBox = new System.Windows.Forms.TextBox();
            this.todoPlainDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.todoIsCompletedCheckBox = new System.Windows.Forms.CheckBox();
            this.saveTodoButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.todoInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            todoNameLabel = new System.Windows.Forms.Label();
            todoPlainDateLabel = new System.Windows.Forms.Label();
            todoIsCompletedLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.todoInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // todoNameLabel
            // 
            todoNameLabel.AutoSize = true;
            todoNameLabel.Location = new System.Drawing.Point(72, 70);
            todoNameLabel.Name = "todoNameLabel";
            todoNameLabel.Size = new System.Drawing.Size(134, 17);
            todoNameLabel.TabIndex = 1;
            todoNameLabel.Text = "Что нужно сделать";
            // 
            // todoNameTextBox
            // 
            this.todoNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.todoInfoBindingSource, "TodoName", true));
            this.todoNameTextBox.Location = new System.Drawing.Point(246, 69);
            this.todoNameTextBox.Name = "todoNameTextBox";
            this.todoNameTextBox.Size = new System.Drawing.Size(271, 22);
            this.todoNameTextBox.TabIndex = 2;
            // 
            // todoPlainDateLabel
            // 
            todoPlainDateLabel.AutoSize = true;
            todoPlainDateLabel.Location = new System.Drawing.Point(72, 128);
            todoPlainDateLabel.Name = "todoPlainDateLabel";
            todoPlainDateLabel.Size = new System.Drawing.Size(46, 17);
            todoPlainDateLabel.TabIndex = 3;
            todoPlainDateLabel.Text = "Когда";
            // 
            // todoPlainDateDateTimePicker
            // 
            this.todoPlainDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.todoInfoBindingSource, "TodoPlainDate", true));
            this.todoPlainDateDateTimePicker.Location = new System.Drawing.Point(246, 123);
            this.todoPlainDateDateTimePicker.Name = "todoPlainDateDateTimePicker";
            this.todoPlainDateDateTimePicker.Size = new System.Drawing.Size(271, 22);
            this.todoPlainDateDateTimePicker.TabIndex = 4;
            // 
            // todoIsCompletedLabel
            // 
            todoIsCompletedLabel.AutoSize = true;
            todoIsCompletedLabel.Location = new System.Drawing.Point(72, 184);
            todoIsCompletedLabel.Name = "todoIsCompletedLabel";
            todoIsCompletedLabel.Size = new System.Drawing.Size(73, 17);
            todoIsCompletedLabel.TabIndex = 4;
            todoIsCompletedLabel.Text = "Сделано?";
            // 
            // todoIsCompletedCheckBox
            // 
            this.todoIsCompletedCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.todoInfoBindingSource, "TodoIsCompleted", true));
            this.todoIsCompletedCheckBox.Location = new System.Drawing.Point(246, 181);
            this.todoIsCompletedCheckBox.Name = "todoIsCompletedCheckBox";
            this.todoIsCompletedCheckBox.Size = new System.Drawing.Size(104, 24);
            this.todoIsCompletedCheckBox.TabIndex = 5;
            this.todoIsCompletedCheckBox.UseVisualStyleBackColor = true;
            // 
            // saveTodoButton
            // 
            this.saveTodoButton.Location = new System.Drawing.Point(66, 331);
            this.saveTodoButton.Name = "saveTodoButton";
            this.saveTodoButton.Size = new System.Drawing.Size(97, 43);
            this.saveTodoButton.TabIndex = 6;
            this.saveTodoButton.Text = "Сохранить";
            this.saveTodoButton.UseVisualStyleBackColor = true;
            this.saveTodoButton.Click += new System.EventHandler(this.saveTodoButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(204, 331);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(99, 43);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // todoInfoBindingSource
            // 
            this.todoInfoBindingSource.DataSource = typeof(TodoLibrary.TodoInfo);
            // 
            // TodoEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 472);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveTodoButton);
            this.Controls.Add(todoIsCompletedLabel);
            this.Controls.Add(this.todoIsCompletedCheckBox);
            this.Controls.Add(todoPlainDateLabel);
            this.Controls.Add(this.todoPlainDateDateTimePicker);
            this.Controls.Add(todoNameLabel);
            this.Controls.Add(this.todoNameTextBox);
            this.Name = "TodoEditForm";
            this.Text = "Edit form";
            this.Load += new System.EventHandler(this.TodoEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.todoInfoBindingSource)).EndInit();
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
    }
}