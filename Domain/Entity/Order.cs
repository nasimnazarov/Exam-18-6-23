namespace Infrastructure.Services;

public class Order
{
    public int Id { get; set; }
    public DateTime OrderPlace { get; set; }
    public DateTime OrderFulfilled { get; set; }
    public int CustomerId { get; set; }
    public Customer Customer { get; set; }
}