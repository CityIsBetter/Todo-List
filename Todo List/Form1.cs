using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Todo_List
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataTable todoList = new DataTable();

        bool isEditing = false;
        private void Form1_Load(object sender, EventArgs e)
        {
            todoList.Columns.Add("Title");
            todoList.Columns.Add("Description");

            todoListView.DataSource = todoList;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            taskField.Text = "";
            descField.Text = "";
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            isEditing = true;
            taskField.Text = todoList.Rows[todoListView.CurrentCell.RowIndex].ItemArray[0].ToString();
            descField.Text = todoList.Rows[todoListView.CurrentCell.RowIndex].ItemArray[1].ToString();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                todoList.Rows[todoListView.CurrentCell.RowIndex].Delete();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (isEditing) {
                todoList.Rows[todoListView.CurrentCell.RowIndex]["Title"] = taskField.Text;
                todoList.Rows[todoListView.CurrentCell.RowIndex]["Description"] = descField.Text;
            }
            else
            {
                todoList.Rows.Add(taskField.Text, descField.Text);
            }
            taskField.Text = "";
            descField.Text = "";
            isEditing = false;
        }
    }
}
