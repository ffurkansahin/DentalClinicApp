using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
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

namespace UIDentalClinicApp
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            UserManager userManager = new UserManager(new EfUserDAL());
            List<Users> users = userManager.GetListAll();

            if ((users.Find(i => i.Username == SignUpUsernameTextBox.Text)) == null)
            {
                if (SignUpPasswordTextBox.Text == SignUpPasswordAgainTextBox.Text)
                {
                    Users user = new Users { Username = SignUpUsernameTextBox.Text, Password = SignUpPasswordAgainTextBox.Text, Phone = signUpPhoneTextBox.Text };
                    userManager.Insert(user);
                    MessageBox.Show("Success");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Passwords should be match");
                }
            }
            else
            {
                MessageBox.Show("This username has taken");
            }



        }
    }
}
