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
    public class TreatmentManager : ITreatmentService
    {
        private readonly ITreatmentDAL treatmentDAL;

        public TreatmentManager(ITreatmentDAL treatmentDAL)
        {
            this.treatmentDAL = treatmentDAL;
        }

        public void Delete(Treatment t)
        {
            treatmentDAL.Delete(t);
        }

        public Treatment GetById(int id)
        {
            return treatmentDAL.GetByID(id);
        }

        public List<Treatment> GetListAll()
        {
            return treatmentDAL.GetAll();
        }

        public void Insert(Treatment t)
        {
            treatmentDAL.Insert(t);
        }

        public void Update(Treatment t)
        {
            treatmentDAL.Update(t);
        }
    }
}
