using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuissnesLayer.Interfaces
{
    public interface IOrderRepository
    {
        //IEnumerable<Order> GetAllOrders();
        //Order GetOrderById(int directoryId, bool includeMaterials = false);
        //void DeleteOrder(Order achieve);
        int AddOrder(Order achieve);
    }
}
