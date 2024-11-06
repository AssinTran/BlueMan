using DataAccess.DAO;
using Models;
using Repository.IRepo;

namespace Repository.Repo
{
    public class OrderRepo : IOrderRepo
    {
        private OrderDAO dao;
        public OrderRepo()
        {
            dao = new();
        }
        public async Task<List<Order>> AcceptedOrder(string userID) => await dao.AcceptedOrders(userID);

        public async Task<bool> AcceptOrder(string orderID) => await dao.AcceptOrder(orderID);

        public async Task<bool> AddOrder(Order order) => await dao.AddOrder(order);

        public async Task<bool> DeleteOrder(string orderID) => await dao.DeleteOrder(orderID);

        public async Task<List<Order>> DeliveredOrder(string userID) => await dao.DeliveredOrders(userID);

        public async Task<bool> DeliverOrder(string orderID) => await dao.DeliverOrder(orderID);

        public async Task<Order?> GetOrder(string orderID) => await dao.GetOrder(orderID);

        public async Task<List<Order>> HistoryOrder(string userID) => await dao.HistoryOrder(userID);

        public async Task<List<Order>> ListOrders() => await dao.ListOrders();

        public async Task<List<Order>> ReceivedOrder(string userID) => await dao.ReceivedOrders(userID);

        public async Task<bool> ReceiveOrder(string orderID) => await dao.ReceiveOrder(orderID);
    }
}
