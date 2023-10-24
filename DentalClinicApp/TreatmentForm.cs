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
    public partial class TreatmentForm : Form
    {
        TreatmentManager treatmentManager = new TreatmentManager(new EfTreatmentDAL());

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

            foreach (var item in treatments)
            {
                dt.Rows.Add(item.Id, item.Name, item.Cost, item.Description);
            }
            dataGridView1.DataSource = dt;
        }

    }
}
