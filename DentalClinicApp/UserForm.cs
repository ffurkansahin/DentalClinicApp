using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalClinicApp
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void userSaveButton_Click(object sender, EventArgs e)
        {
            UserManager userManager = new UserManager(new EfUserDAL());
            List<Users> users = userManager.GetListAll();

            Users users1 = users.Find(i => i.Username == userUsernameTextBox.Text);
            if (users1 != null)
            {
                users1.Password = userPasswordTextBox.Text;
                users1.Username = userUsernameTextBox.Text;
                users1.Phone = userPhoneTextBox.Text;
                userManager.Update(users1);
                MessageBox.Show("Updated successfuly");
            }
            else
            {
                MessageBox.Show("Invalid username");
            }
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            UserManager userManager = new UserManager(new EfUserDAL());
            List<Users> users = userManager.GetListAll();

            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Username", typeof(string));
            table.Columns.Add("Phone Number", typeof(string));

            foreach (var item in users)
            {
                table.Rows.Add(item.Id, item.Username, item.Phone);
            }

            dataGridView1.DataSource = table;

        }
    }
}
