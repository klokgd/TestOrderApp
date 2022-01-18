using BuissnesLayer.Interfaces;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuissnesLayer.Implemenation
{
    internal class EFOrderRepository : IOrderRepository
    {
        private EFDBContext _context;

        public EFOrderRepository(EFDBContext context)
        {
            _context = context;
        }

        public int AddOrder(Order order)
        {
            _context.Order.Add(order);
            _context.SaveChanges();
            return order.Id;
        }

    }
}
