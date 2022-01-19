using DataLayer;

namespace BuissnesLayer.Interfaces
{
    public interface IOrderRepository
    {
      
        int AddOrder(Order achieve);
        List<Order> GetOrders();
    }
}
