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
    public partial class AppointmentForm : Form
    {
        PatientManager patientManager = new PatientManager(new EfPatientDAL());
        TreatmentManager treatmentManager = new TreatmentManager(new EfTreatmentDAL());
        AppointmentManager appointmentManager = new AppointmentManager(new EfAppointmentDAL());
        public AppointmentForm()
        {
            InitializeComponent();


        }

        private void AppointmentForm_Load(object sender, EventArgs e)
        {
            List<Patient> patients = patientManager.GetListAll();

            List<Treatment> treatments = treatmentManager.GetListAll();



            foreach (Patient pat in patients)
            {
                patientComboBox.Items.Add(pat.Name);
            }
            foreach (Treatment t in treatments)
            {
                treatmentComboBox.Items.Add(t.Name);
            }

            FillDataGrid();

        }

        private void appointmentsSaveButton_Click(object sender, EventArgs e)
        {
            List<Appointment> appointments = appointmentManager.GetListAll();
            if (appointments.Find(i => i.Patient == patientComboBox.Text) != null)
            {

                Appointment appointment = appointments.Find(i => i.Patient == patientComboBox.Text);

                appointment.Patient = patientComboBox.Text;
                appointment.Treatment = treatmentComboBox.Text;
                appointment.Date = appointmentsDateTimePicker.Value;
                appointment.Time = appointmentsTimePicker.Value.ToString("HH:mm");

                appointmentManager.Update(appointment);

            }

            else
            {
                appointmentManager.Insert(new Appointment
                {
                    Patient = patientComboBox.Text,
                    Treatment = treatmentComboBox.Text,
                    Date = appointmentsDateTimePicker.Value,
                    Time = appointmentsTimePicker.Value.ToString("HH:mm")
                });
            }

            FillDataGrid();
        }
        public void FillDataGrid()
        {
            List<Appointment> appointments = appointmentManager.GetListAll();

            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Patient Name", typeof(string));
            table.Columns.Add("Treatment", typeof(string));
            table.Columns.Add("Date", typeof(DateTime));
            table.Columns.Add("Time", typeof(string));
            appointmentsDataGridView.DataSource = table;

            foreach (DataColumn column in table.Columns)
            {
                column.ReadOnly = true;
            }

            for (int i = 0; i < appointments.Count; i++)
            {
                table.Rows.Add(appointments[i].Id, appointments[i].Patient, appointments[i].Treatment, appointments[i].Date, appointments[i].Time);
            }
        }
        private void appointmentsDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            patientComboBox.Text = appointmentsDataGridView.CurrentRow.Cells[1].Value.ToString();
            treatmentComboBox.Text = appointmentsDataGridView.CurrentRow.Cells[2].Value.ToString();
            appointmentsDateTimePicker.Text = appointmentsDataGridView.CurrentRow.Cells[3].Value.ToString();
            appointmentsTimePicker.Text = appointmentsDataGridView.CurrentRow.Cells[4].Value.ToString();
        }
        private void appointmentsLeftMenuPatientLabel_Click(object sender, EventArgs e)
        {
            PatientForm patientForm = new PatientForm();
            patientForm.Show();
            this.Close();
        }

        private void appointmentsLeftMenuTreatmentLabel_Click(object sender, EventArgs e)
        {
            TreatmentForm treatmentForm = new TreatmentForm();
            treatmentForm.Show();
            this.Close();
        }

        private void appointmentsLeftMenuPrescriptionLabel_Click(object sender, EventArgs e)
        {
            PrescriptionForm prescriptionForm = new PrescriptionForm();
            prescriptionForm.Show();
            this.Close();
        }

        private void appointmentsLeftMenuUserLabel_Click(object sender, EventArgs e)
        {
            UserForm userForm = new UserForm();
            userForm.Show();
            this.Close();
        }

        private void appointmentsLeftMenuLogoutLabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void appointmentDeleteButton_Click(object sender, EventArgs e)
        {
            List<Appointment> appointments = appointmentManager.GetListAll();
            Appointment appointmentDelete = appointments.Find(i => i.Patient == patientComboBox.Text);
            if (appointmentDelete != null) 
            {
                appointmentManager.Delete(appointmentDelete);
                FillDataGrid();
            }
            else
            {
                MessageBox.Show("There is no patient named " + patientComboBox.Text);
            }
        }
    }

}
