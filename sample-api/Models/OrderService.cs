namespace sample_api.Models
{
    public class OrderService{
        
        private readonly List<Order> _orders = new List<Order>();

        public async Task<Order> Register(Order order)
        {
            await Task.Delay(200);
            order.Id = _orders.Count + 1;
            order.CreatedDate = DateTime.Now;
            _orders.Add(order);
            return order;
        }

        public async Task<IEnumerable<Order>> GetOrders()
        {
            await Task.Delay(200);
            return _orders.ToList();
        }
        
        public async Task<Order> GetOrderById(int id){
            await Task.Delay(200);
            return _orders.FirstOrDefault(x => x.Id == id);            
        }
    }
}