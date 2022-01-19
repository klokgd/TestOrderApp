using BuissnesLayer.Interfaces;

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
