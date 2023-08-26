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
    public class OrderRepository : GenericRepository<Order>, IOrderRepository
    {
        public OrderRepository(DBContext context) : base(context)
        {

        }
        public IQueryable GetOrdersByUserId(int id)
        {
            var orders = GetAll().Where(order => order.CustomerID == id);
            return orders;
        }
    }
}
