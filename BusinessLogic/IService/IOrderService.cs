using Models;

namespace BusinessLogic.IService
{
    public interface IOrderService
    {
        Task<List<Order>> HistoryOrder(string userID);
        Task<List<Order>> AcceptedOrder(string userID);
        Task<List<Order>> ReceivedOrder(string userID);
        Task<List<Order>> DeliveredOrder(string userID);
        Task<List<Order>> ListOrders();
        Task<bool> AddOrder(Order order);
        Task<Order?> GetOrder(string orderID);
        Task<bool> DeleteOrder(string orderID);
        Task<bool> AcceptOrder(string orderID);
        Task<bool> ReceiveOrder(string orderID);
        Task<bool> DeliverOrder(string orderID);
    }
}
