using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalClinicApp
{
    public partial class PatientForm : Form
    {
        PatientManager patientManager = new PatientManager(new EfPatientDAL());

        public PatientForm()
        {
            InitializeComponent();
        }

        private void PatientForm_Load(object sender, EventArgs e)
        {
            FillDataGrid();
        }

        public void FillDataGrid()
        {
            List<Patient> patients = patientManager.GetListAll();

            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Address", typeof(string));
            dt.Columns.Add("Phone Number", typeof(string));
            dt.Columns.Add("Gender", typeof(string));
            dt.Columns.Add("Allergies", typeof(string));
            foreach (var item in patients)
            {
                dt.Rows.Add(item.Id, item.Name, item.Address, item.PhoneNumber, item.Gender, item.Allergies);
            }

            dataGridView1.DataSource = dt;
        }

        private void patientSaveButton_Click(object sender, EventArgs e)
        {
            List<Patient> patients = patientManager.GetListAll();

            if (patients.Find(i => i.Name == patientNameTextBox.Text) == null)
            {
                Patient patient = new Patient
                {
                    Name = patientNameTextBox.Text,
                    Address = patientAddressTextBox.Text,
                    Allergies = patientAllergiesTextBox.Text,
                    BirthDate = patientBirthDateTimePicker.Value,
                    Gender = patientGenderTextBox.Text,
                    PhoneNumber = patientPhoneTextBox.Text,
                };
                patientManager.Insert(patient);
            }
            else
            {
                Patient patientUpdate = patients.Find(i => i.Name == patientNameTextBox.Text);
                patientUpdate.Name = patientNameTextBox.Text;
                patientUpdate.Address = patientAddressTextBox.Text;
                patientUpdate.Allergies = patientAllergiesTextBox.Text;
                patientUpdate.BirthDate = patientBirthDateTimePicker.Value;
                patientUpdate.Gender = patientGenderTextBox.Text;
                patientUpdate.PhoneNumber = patientPhoneTextBox.Text;

                patientManager.Update(patientUpdate);
            }
            FillDataGrid();
        }
    }
}
