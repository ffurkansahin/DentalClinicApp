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
    public partial class PrescriptionForm : Form
    {
        PrescriptionManager prescriptionManager = new PrescriptionManager(new EfPrescriptionDAL());
        PatientManager PatientManager = new PatientManager(new EfPatientDAL());

        public PrescriptionForm()
        {
            InitializeComponent();


        }
        private void PrescriptionForm_Load(object sender, EventArgs e)
        {
            foreach (var item in PatientManager.GetListAll())
            {
                prescriptionPatientComboBox.Items.Add(item.Name);
            }
            FillDataGrid();
        }

        private void prescriptionSaveButton_Click(object sender, EventArgs e)
        {
            List<Prescription> prescriptions = prescriptionManager.GetListAll();

            if (prescriptions.Find(i => i.Name == prescriptionNameTextBox.Text) == null)
            {
                Prescription prescription = new Prescription();
                prescription.Name = prescriptionNameTextBox.Text;
                prescription.Cost = decimal.Parse(prescriptionCostTextBox.Text);
                prescription.Patient = prescriptionPatientComboBox.Text;
                prescription.Treatment = prescriptionTreatmentTextBox.Text;
                prescription.Quantity = int.Parse(prescriptionQuantityTextBox.Text);
                prescription.Medicines = prescriptionMedicinesTextBox.Text;

                prescriptionManager.Insert(prescription);
            }
            else
            {
                Prescription prescriptionUpdate = prescriptions.Find(i => i.Name == prescriptionNameTextBox.Text);
                prescriptionUpdate.Name = prescriptionNameTextBox.Text;
                prescriptionUpdate.Cost = decimal.Parse(prescriptionCostTextBox.Text);
                prescriptionUpdate.Patient = prescriptionPatientComboBox.Text;
                prescriptionUpdate.Treatment = prescriptionTreatmentTextBox.Text;
                prescriptionUpdate.Quantity = int.Parse(prescriptionQuantityTextBox.Text);
                prescriptionUpdate.Medicines = prescriptionMedicinesTextBox.Text;

                prescriptionManager.Update(prescriptionUpdate);
            }

            FillDataGrid();
        }

        private void FillDataGrid()
        {
            List<Prescription> prescriptions = prescriptionManager.GetListAll();

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID", typeof(int));
            dataTable.Columns.Add("Name", typeof(string));
            dataTable.Columns.Add("Patient", typeof(string));
            dataTable.Columns.Add("Treatment", typeof(string));
            dataTable.Columns.Add("Medicines", typeof(string));
            dataTable.Columns.Add("Cost", typeof(decimal));
            dataTable.Columns.Add("Quantity", typeof(int));

            foreach (DataColumn column in dataTable.Columns)
            {
                column.ReadOnly = true;
            }

            foreach (var item in prescriptions)
            {
                dataTable.Rows.Add(item.Id, item.Name, item.Patient, item.Treatment, item.Medicines, item.Cost, item.Quantity);
            }
            dataGridView1.DataSource = dataTable;

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            prescriptionNameTextBox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            prescriptionPatientComboBox.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            prescriptionTreatmentTextBox.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            prescriptionMedicinesTextBox.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            prescriptionCostTextBox.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            prescriptionQuantityTextBox.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        private void prescriptionLeftMenuPatientClickLabel_Click(object sender, EventArgs e)
        {
            PatientForm patientForm = new PatientForm();
            patientForm.Show();
            this.Close();
        }

        private void prescriptionLeftMenuTreatmentClickLabel_Click(object sender, EventArgs e)
        {
            TreatmentForm treatmentForm = new TreatmentForm();
            treatmentForm.Show();
            this.Close();
        }

        private void prescriptionLeftMenuAppointmentClickLabel_Click(object sender, EventArgs e)
        {
            AppointmentForm appointmentForm = new AppointmentForm();
            appointmentForm.Show();
            this.Close();
        }

        private void prescriptionLeftMenuUserClickLabel_Click(object sender, EventArgs e)
        {
            UserForm userForm = new UserForm();
            userForm.Show();
            this.Close();
        }

        private void prescriptionLeftMenuLogoutClickLabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void prescriptionDeleteButton_Click(object sender, EventArgs e)
        {
            List<Prescription> prescriptions =prescriptionManager.GetListAll(); 
            Prescription prescriptionDelete = prescriptions.Find(i=>i.Name==prescriptionNameTextBox.Text);
            if (prescriptionDelete != null) 
            {
                prescriptionManager.Delete(prescriptionDelete);
                FillDataGrid();
            }
            else
            {
                MessageBox.Show("There is no prescription named " + prescriptionNameTextBox.Text);
            }
        }
    }
}
