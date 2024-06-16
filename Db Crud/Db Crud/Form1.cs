using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Db_Crud
{
    public partial class Form1 : Form
    {
        private User? selectedUser;
        public List<User> DataBaseUsers { get; private set; }

        public Form1()
        {
            InitializeComponent();
            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            DatabaseFacade facade = new DatabaseFacade(new DataContext());
            facade.EnsureCreated();

            Read(); // Load initial data
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                
                selectedUser = dataGridView1.SelectedRows[0].DataBoundItem as User;
                if (selectedUser != null)
                {
                    textBox_name.Text = selectedUser.Name;
                    textBox_address.Text = selectedUser.Address;
                }
            }
        }

        public void Create()
        {
            using (DataContext context = new DataContext())
            {
                var name = textBox_name.Text;
                var address = textBox_address.Text;

                if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(address))
                {
                    context.Users.Add(new User() { Name = name, Address = address });
                    context.SaveChanges();
                    Read(); // Refresh the data grid view
                }
            }
        }

        public void Read()
        {
            using (DataContext context = new DataContext())
            {
                DataBaseUsers = context.Users.ToList();

                // Bind the list to the DataGridView
                dataGridView1.DataSource = null; // Reset the data source
                dataGridView1.DataSource = DataBaseUsers;
            }
        }

        public void Update()
        {
            if (selectedUser == null)
                return;

            using (DataContext context = new DataContext())
            {
                var userToUpdate = context.Users.Find(selectedUser.Id);
                if (userToUpdate != null)
                {
                    userToUpdate.Name = textBox_name.Text;
                    userToUpdate.Address = textBox_address.Text;
                    context.SaveChanges();
                    Read(); // Refresh the data grid view
                }
            }
        }

        public void Delete()
        {
            if (selectedUser == null)
                return;

            using (DataContext context = new DataContext())
            {
                var userToDelete = context.Users.Find(selectedUser.Id);
                if (userToDelete != null)
                {
                    context.Users.Remove(userToDelete);
                    context.SaveChanges();
                    Read(); // Refresh the data grid view
                }
            }
        }

        private void Button_Add_Click(object sender, EventArgs e)
        {
            Create();
        }

        private void Button_Read_Click(object sender, EventArgs e)
        {
            Read();
        }

        private void Button_Update_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void Button_Delete_Click(object sender, EventArgs e)
        {
            Delete();
        }
    }
}
