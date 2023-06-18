namespace Domain.Dtos;

public class OrderDto
{
    public int Id { get; set; }
    public DateTime OrderPlace { get; set; }
    public DateTime OrderFulFilled { get; set; }
    public int CustomerId { get; set; }
}