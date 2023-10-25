using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
    public partial class TreatmentForm : Form
    {
        TreatmentManager treatmentManager = new TreatmentManager(new EfTreatmentDAL());
        UserManager userManager = new UserManager(new EfUserDAL());

        public TreatmentForm()
        {
            InitializeComponent();
        }

        private void TreatmentForm_Load(object sender, EventArgs e)
        {
            FillDataGrid();

        }

        private void treatmentSaveButton_Click(object sender, EventArgs e)
        {
            List<Treatment> treatments = treatmentManager.GetListAll();
            if (treatments.Find(i => i.Name == treatmentNameTextBox.Text) == null)
            {
                Treatment treatment = new Treatment
                {
                    Name = treatmentNameTextBox.Text,
                    Cost = decimal.Parse(treatmentCostTextBox.Text),
                    Description = treatmentDescriptionTextBox.Text

                };
                treatmentManager.Insert(treatment);
                MessageBox.Show("Added successfully");
            }
            else
            {
                Treatment treatmentUpdate = treatments.Find(i => i.Name == treatmentNameTextBox.Text);

                treatmentUpdate.Name = treatmentNameTextBox.Text;
                treatmentUpdate.Cost = decimal.Parse(treatmentCostTextBox.Text);
                treatmentUpdate.Description = treatmentDescriptionTextBox.Text;
                MessageBox.Show("Updated successfully");
            }

            FillDataGrid();
        }

        public void FillDataGrid()
        {
            List<Treatment> treatments = treatmentManager.GetListAll();

            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Cost", typeof(decimal));
            dt.Columns.Add("Description", typeof(string));

            foreach (DataColumn column in dt.Columns)
            {
                column.ReadOnly = true;
            }

            foreach (var item in treatments)
            {
                dt.Rows.Add(item.Id, item.Name, item.Cost, item.Description);
            }
            dataGridView1.DataSource = dt;
        }

        private void treatmentLeftMenuPatientClickLabel_Click(object sender, EventArgs e)
        {
            PatientForm patientForm = new PatientForm();
            patientForm.Show();
            this.Close();
        }

        private void treatmentLeftMenuAppointmentClickLabel_Click(object sender, EventArgs e)
        {
            AppointmentForm appointmentForm = new AppointmentForm();
            appointmentForm.Show();
            this.Close();
        }

        private void treatmentLeftMenuPrescriptionClickLabel_Click(object sender, EventArgs e)
        {
            PrescriptionForm prescriptionForm = new PrescriptionForm();
            prescriptionForm.Show();
            this.Close();
        }

        private void treatmentLeftMenuUserClickLabel_Click(object sender, EventArgs e)
        {
            UserForm userForm = new UserForm();
            userForm.Show();
            this.Close();
        }

        private void treatmentLeftMenuLogoutClickLabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            treatmentNameTextBox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            treatmentCostTextBox.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            treatmentDescriptionTextBox.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void treatmentsDeleteButton_Click(object sender, EventArgs e)
        {
            List<Treatment> treatments = treatmentManager.GetListAll();
            Treatment treatmentsDelete= treatments.Find(i => i.Name == treatmentNameTextBox.Text);
            if(treatmentsDelete != null)
            {
                treatmentManager.Delete(treatmentsDelete);
                FillDataGrid();
            }
            else
            {
                MessageBox.Show("There is no treatment named " + treatmentNameTextBox.Text);
            }
        }
    }
}
