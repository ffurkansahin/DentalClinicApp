﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfTreatmentDAL:GenericRepository<Treatment>,ITreatmentDAL
    {
    }
}
