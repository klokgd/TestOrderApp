using BuissnesLayer.Interfaces;
using DataLayer;

namespace BuissnesLayer.Implemenation
{
    public class EFOrderRepository : IOrderRepository
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
