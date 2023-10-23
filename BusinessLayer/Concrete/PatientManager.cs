using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class PatientManager : IPatientService
    {
        private readonly IPatientDAL patientDAL;

        public PatientManager(IPatientDAL patientDAL)
        {
            this.patientDAL = patientDAL;
        }
        public void Delete(Patient t)
        {
            patientDAL.Delete(t);
        }

        public Patient GetById(int id)
        {
            return patientDAL.GetByID(id);
        }

        public List<Patient> GetListAll()
        {
            return patientDAL.GetAll();
        }

        public void Insert(Patient t)
        {
            patientDAL.Insert(t);
        }

        public void Update(Patient t)
        {
            patientDAL.Update(t);
        }
    }
}
