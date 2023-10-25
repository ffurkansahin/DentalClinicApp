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
        UserManager userManager = new UserManager(new EfUserDAL());

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
            FillDataGrid();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {

            FillDataGrid();

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            userUsernameTextBox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            userPhoneTextBox.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            userPasswordTextBox.Text = userManager.GetListAll().Find(i=>i.Username==userUsernameTextBox.Text).Password.ToString();


        }

        public void FillDataGrid()
        {
            List<Users> users = userManager.GetListAll();

            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Username", typeof(string));
            table.Columns.Add("Phone Number", typeof(string));

            foreach (DataColumn column in table.Columns)
            {
                column.ReadOnly = true;
            }

            foreach (var item in users)
            {
                table.Rows.Add(item.Id, item.Username, item.Phone);
            }

            dataGridView1.DataSource = table;
        }

        private void userLeftMenuPatientLabelClick_Click(object sender, EventArgs e)
        {
            PatientForm patientForm = new PatientForm();
            patientForm.Show();
            this.Close();
        }

        private void userLeftMenuAppointmentLabelClick_Click(object sender, EventArgs e)
        {
            AppointmentForm appointmentForm = new AppointmentForm();
            appointmentForm.Show();
            this.Close();
        }

        private void userLeftMenuPrescriptionLabelClick_Click(object sender, EventArgs e)
        {
            PrescriptionForm prescriptionForm = new PrescriptionForm();
            prescriptionForm.Show();
            this.Close();
        }

        private void userLeftMenuTreatmentLabelClick_Click(object sender, EventArgs e)
        {
            TreatmentForm treatmentForm = new TreatmentForm();
            treatmentForm.Show();
            this.Close();
        }

        private void userLeftMenuLogoutLabelClick_Click(object sender, EventArgs e)
        {

            this.Close();
        }


    }
}
