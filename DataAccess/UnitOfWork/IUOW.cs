﻿using AMSModels;
using DataAccess.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.UnitOfWork
{
    public interface IUOW
    {
        GenericRepository<User> UserRepository();
        GenericRepository<AddVehicleView> AddVehicle();
        GenericRepository<VehicleImages> AddVehicleImage();
        bool ApproveCompany(Guid Id,int flag);
        void Save();
        User Authentication(string UserName, string password);
        bool GetByEmail(string email);
        public bool ExecuteJob();
        void Dispose();
       
    }
}
