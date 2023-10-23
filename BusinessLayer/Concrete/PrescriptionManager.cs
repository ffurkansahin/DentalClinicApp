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
    public class PrescriptionManager : IPrescriptionService
    {
        private readonly IPrescriptionDAL prescriptionDAL;

        public PrescriptionManager(IPrescriptionDAL prescriptionDAL)
        {
            this.prescriptionDAL = prescriptionDAL;
        }

        public void Delete(Prescription t)
        {
            prescriptionDAL.Delete(t);
        }

        public Prescription GetById(int id)
        {
            return prescriptionDAL.GetByID(id);
        }

        public List<Prescription> GetListAll()
        {
            return prescriptionDAL.GetAll();
        }

        public void Insert(Prescription t)
        {
            prescriptionDAL.Insert(t);
        }

        public void Update(Prescription t)
        {
            prescriptionDAL.Update(t);
        }
    }
}
