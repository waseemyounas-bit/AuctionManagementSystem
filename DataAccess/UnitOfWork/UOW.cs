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

		
		public Dictionary<Guid, string> Authentication(string UserName, string password)
		{
			Dictionary<Guid, string> dic = new Dictionary<Guid, string>();
			User user = _context.Users.Where(x => x.FullName == UserName && x.Password == password).FirstOrDefault();
			if (user != null)
				dic.Add(user.Id, "Admin");
			//Company compnay = _context.Companies.Where(x => x.Email == email && x.Password == password).FirstOrDefault();
			//if (compnay != null)
			//	dic.Add(compnay.CompanyId, "Company");
			//Employee employee = _context.Employees.Where(x => x.Email == email && x.Password == password).FirstOrDefault();
			//if (employee != null)
			//	dic.Add(employee.Id, "Employee");
			return dic;
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
