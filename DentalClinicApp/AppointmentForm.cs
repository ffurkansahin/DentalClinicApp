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
                appointment.Time = appointmentsTimePicker.Value;

                appointmentManager.Update(appointment);

            }

            else
            {
                appointmentManager.Insert(new Appointment
                {
                    Patient = patientComboBox.Text,
                    Treatment = treatmentComboBox.Text,
                    Date = appointmentsDateTimePicker.Value,
                    Time = appointmentsTimePicker.Value
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
            table.Columns.Add("Time", typeof(DateTime));
            appointmentsDataGridView.DataSource = table;
            for (int i = 0; i < appointments.Count; i++)
            {
                table.Rows.Add(appointments[i].Id, appointments[i].Patient, appointments[i].Treatment, appointments[i].Date, appointments[i].Time);
            }
        }

    }

}
