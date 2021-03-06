using BuissnesLayer;
using BuissnesLayer.Implemenation;
using DataLayer;
using ViewLayer.Models;

namespace ViewLayer.Service
{
    public class OrderService
    {
        private DataManager _dataManager;
        private EFOrderRepository _order;

        public OrderService(DataManager dataManager)
        {
            _dataManager = dataManager;
        }

        public int SaveOrderModelToDB(OrderViewModel newOrderViewModel)
        {
            Order order = new Order();
            order.AdressOfRecepient = newOrderViewModel.AdressOfRecepient;
            order.AdressOfSender = newOrderViewModel.AdressOfSender;
            order.CityOfRecepient = newOrderViewModel.CityOfRecepient;
            order.CityOfSender = newOrderViewModel.CityOfSender;
            order.DeliveryDate = newOrderViewModel.DeliveryDate;
            order.GoodsWeight = newOrderViewModel.GoodsWeight;

            return _dataManager.Order.AddOrder(order);
        }

        public List<OrderViewModel> GetOrderVMToList()
        {
            var orders = _dataManager.Order.GetOrders();
            return CustomMapper.GetInstance().Map<List<OrderViewModel>>(orders);
        }

    }
}
