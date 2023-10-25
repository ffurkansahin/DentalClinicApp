using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using BusinessLayer.Validator;
using DataAccessLayer.Abstract;
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
            Users userAdd = new Users
            {
                Username = SignUpUsernameTextBox.Text,
                Password = SignUpPasswordAgainTextBox.Text,
                Phone = signUpPhoneTextBox.Text
            };
            UserValidator validationRules = new UserValidator();
            ValidationResult validationResult = validationRules.Validate(userAdd);
            if (validationResult.IsValid)
            {
                if (users.Find(i => i.Username == userAdd.Username) == null)
                {
                    userManager.Insert(userAdd);
                    MessageBox.Show("User added succesfully");
                }
                else
                {
                    MessageBox.Show("This username already in use");
                }

            }
            else
            {
                foreach(var item in validationResult.Errors) 
                {
                    MessageBox.Show(item.ErrorMessage);
                }
            }
        }
    }
}
