using BusinessLogic.IService;
using Models;
using Repository.IRepo;
using Repository.Repo;

namespace BusinessLogic.Service
{
    public class OrderService : IOrderService
    {
        private IOrderRepo repo;
        public OrderService()
        {
            repo = new OrderRepo();
        }
        public async Task<List<Order>> AcceptedOrder(string userID) => await repo.AcceptedOrder(userID);

        public async Task<bool> AcceptOrder(string orderID) => await repo.AcceptOrder(orderID);

        public async Task<bool> AddOrder(Order order) => await repo.AddOrder(order);

        public async Task<bool> DeleteOrder(string orderID) => await repo.DeleteOrder(orderID);

        public async Task<List<Order>> DeliveredOrder(string userID) => await repo.DeliveredOrder(userID);

        public async Task<bool> DeliverOrder(string orderID) => await repo.DeliverOrder(orderID);

        public async Task<Order?> GetOrder(string orderID) => await repo.GetOrder(orderID);

        public async Task<List<Order>> HistoryOrder(string userID) => await repo.HistoryOrder(userID);

        public async Task<List<Order>> ListOrders() => await repo.ListOrders();

        public async Task<List<Order>> ReceivedOrder(string userID) => await repo.ReceivedOrder(userID);

        public async Task<bool> ReceiveOrder(string orderID) => await repo.ReceiveOrder(orderID);
    }
}
