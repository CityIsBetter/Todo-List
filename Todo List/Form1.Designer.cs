namespace Todo_List
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            taskField = new TextBox();
            descField = new TextBox();
            label2 = new Label();
            label3 = new Label();
            Add = new Button();
            Delete = new Button();
            Edit = new Button();
            Save = new Button();
            todoListView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)todoListView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Bradley Hand ITC", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(1041, 197);
            label1.TabIndex = 0;
            label1.Text = "To Do List";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // taskField
            // 
            taskField.BorderStyle = BorderStyle.FixedSingle;
            taskField.Cursor = Cursors.IBeam;
            taskField.Location = new Point(289, 191);
            taskField.Name = "taskField";
            taskField.Size = new Size(494, 35);
            taskField.TabIndex = 1;
            // 
            // descField
            // 
            descField.BorderStyle = BorderStyle.FixedSingle;
            descField.Cursor = Cursors.IBeam;
            descField.Location = new Point(289, 285);
            descField.Name = "descField";
            descField.Size = new Size(494, 35);
            descField.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(289, 158);
            label2.Name = "label2";
            label2.Size = new Size(107, 30);
            label2.TabIndex = 3;
            label2.Text = "Task to do";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(289, 252);
            label3.Name = "label3";
            label3.Size = new Size(118, 30);
            label3.TabIndex = 4;
            label3.Text = "Description";
            // 
            // Add
            // 
            Add.Cursor = Cursors.Hand;
            Add.Location = new Point(204, 361);
            Add.Name = "Add";
            Add.Size = new Size(141, 70);
            Add.TabIndex = 5;
            Add.Text = "New";
            Add.UseVisualStyleBackColor = true;
            Add.Click += Add_Click;
            // 
            // Delete
            // 
            Delete.Cursor = Cursors.Hand;
            Delete.Location = new Point(361, 361);
            Delete.Name = "Delete";
            Delete.Size = new Size(141, 70);
            Delete.TabIndex = 6;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += Delete_Click;
            // 
            // Edit
            // 
            Edit.Cursor = Cursors.Hand;
            Edit.Location = new Point(521, 361);
            Edit.Name = "Edit";
            Edit.Size = new Size(141, 70);
            Edit.TabIndex = 7;
            Edit.Text = "Edit";
            Edit.UseVisualStyleBackColor = true;
            Edit.Click += Edit_Click;
            // 
            // Save
            // 
            Save.Cursor = Cursors.Hand;
            Save.Location = new Point(684, 361);
            Save.Name = "Save";
            Save.Size = new Size(141, 70);
            Save.TabIndex = 8;
            Save.Text = "Save";
            Save.UseVisualStyleBackColor = true;
            Save.Click += Save_Click;
            // 
            // todoListView
            // 
            todoListView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            todoListView.BackgroundColor = SystemColors.ActiveCaption;
            todoListView.BorderStyle = BorderStyle.None;
            todoListView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            todoListView.Location = new Point(12, 450);
            todoListView.Name = "todoListView";
            todoListView.RowHeadersWidth = 72;
            todoListView.Size = new Size(1041, 394);
            todoListView.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1065, 856);
            Controls.Add(todoListView);
            Controls.Add(Save);
            Controls.Add(Edit);
            Controls.Add(Delete);
            Controls.Add(Add);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(descField);
            Controls.Add(taskField);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Todo List";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)todoListView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox taskField;
        private TextBox descField;
        private Label label2;
        private Label label3;
        private Button Add;
        private Button Delete;
        private Button Edit;
        private Button Save;
        private DataGridView todoListView;
    }
}
