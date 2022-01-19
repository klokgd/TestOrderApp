using BuissnesLayer;
using ViewLayer.Service;

namespace ViewLayer
{
    public class ServicesManager
    {
        DataManager _dataManager;
        private OrderService _orderService;
        public ServicesManager(DataManager dataManager)
        {
            _dataManager = dataManager;
            _orderService = new OrderService(_dataManager);
        }
        public OrderService Order { get { return _orderService; } }
    }

}