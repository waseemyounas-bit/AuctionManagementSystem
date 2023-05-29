using AMSModels;
using DataAccess.Data;
using DataAccess.GenericRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.UnitOfWork
{
	public class UOW : IUOW, IDisposable
	{
		private DataContext _context;
		public UOW(DataContext context)
		{
			_context = context;
		}

		
		public GenericRepository<User> UserRepository()
		{
			return new GenericRepository<User>(_context);
		}
        public GenericRepository<AddVehicle> AddVehicle()
        {
            return new GenericRepository<AddVehicle>(_context);
        }
        public GenericRepository<VehicleImages> AddVehicleImage()
        {
            return new GenericRepository<VehicleImages>(_context);
        }
        public User Authentication(string UserName, string password)
		{
			Dictionary<Guid, string> dic = new Dictionary<Guid, string>();
			User user = _context.Users.Where(x => x.FullName == UserName && x.Password == password && x.IsApproved==1).FirstOrDefault();
			return user;
		}
		
		public void Save()
		{
			_context.SaveChanges();
		}
		
        public bool ExecuteJob()
        {
            try
            {
                return true;
            }
            catch
            {

                return false;
            }
        }
        public void Dispose()
		{
			_context.Dispose();
		}

        public bool ApproveCompany(Guid Id, int flag)
        {
            throw new NotImplementedException();
        }

        public bool GetByEmail(string email)
        {
            throw new NotImplementedException();
        }
    }
}
