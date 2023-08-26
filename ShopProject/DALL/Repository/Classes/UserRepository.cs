using DAL.Context;
using DAL.Entities;
using DAL.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.Classes
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(DBContext context) : base(context)
        {

        }

        public IQueryable GetUserByOrderId(int id)
        {
            var users = GetAll().Where(user => user.Orders.Any(order => order.Id == id));
            return users;
        }

        public IQueryable GetUserByLogin(string login)
        {
            var users = GetAll().Where(user => user.login == login);
            return users;
        }
    }
}
