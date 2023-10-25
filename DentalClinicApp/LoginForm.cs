using BusinessLayer.Concrete;
using BusinessLayer.Validator;
using DataAccessLayer.EntityFramework;
using EntityLayer.Entities;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UIDentalClinicApp;

namespace DentalClinicApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.ShowDialog();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            UserManager userManager = new UserManager(new EfUserDAL());
            List<Users> users = userManager.GetListAll();
            Users loginUser = users.Find(i => i.Username == usernameTextBox.Text);

            UserValidator validations = new UserValidator();
            if (loginUser != null)
            {
                ValidationResult result = validations.Validate(loginUser);
            }
            else
            {
                MessageBox.Show("Invalid user entry");
            }

            if (validations.Validate(loginUser).IsValid)
            {
                if (loginUser.Password != passwordTextBox.Text)
                {
                    MessageBox.Show("Invalid user entry");
                }
                else
                {
                    AppointmentForm appointment = new AppointmentForm();
                    appointment.Show();
                }
            }
            else
            {
                foreach (var item in validations.Validate(loginUser).Errors)
                {
                    MessageBox.Show(item.ErrorMessage);
                }
            }


        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
