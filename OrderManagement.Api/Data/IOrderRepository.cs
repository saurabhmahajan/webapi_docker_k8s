
public interface IOrderRepository
{
    IEnumerable<Order> GetAll();
}

public class Order
{
    public int Id { get; set; }
    public string OrderNumber { get; set; } = "";
    public string CustomerName { get; set; } = "";
    public decimal Amount { get; set; }
    public string Status { get; set; } = "New";
    public DateTimeOffset CreatedAt { get; set; }
}