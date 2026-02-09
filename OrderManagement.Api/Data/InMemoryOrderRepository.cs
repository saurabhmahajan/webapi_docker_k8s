

public class InMemoryOrderRepository : IOrderRepository
{
    public IEnumerable<Order> GetAll()
    {
        return new List<Order>
        {
            new Order
            {
                Id = 1,
                OrderNumber="#A123",
                CustomerName="Saurabh",
                Amount=123.45M,
                Status="Confirmed",
                CreatedAt=DateTimeOffset.Now
            },
            new Order
            {
                Id = 2,
                OrderNumber="#A456",
                CustomerName="Tejashree",
                Amount=454.45M,
                Status="New",
                CreatedAt=DateTimeOffset.Now
            },
            new Order
            {
                Id = 3,
                OrderNumber="#A456",
                CustomerName="Savi",
                Amount=888.45M,
                Status="Delivered",
                CreatedAt=DateTimeOffset.Now
            }
        };
    }
}