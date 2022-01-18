using BuissnesLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuissnesLayer
{
    public class DataManager
    {
        private IOrderRepository _orderRepository;
        public DataManager(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public IOrderRepository Order { get { return _orderRepository; } }
    }
}
