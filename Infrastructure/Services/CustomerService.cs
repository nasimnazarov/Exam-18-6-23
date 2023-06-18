using Infrastructure.Context;

namespace Infrastructure.Services;

public class CustomerService
{
    private readonly DataContext _context;

    public CustomerService(DataContext context)
    {
        _context = context;
    }

    public List<Customer> GetCustomers()
    {
        var result = _context.Costomers.ToList();
        return result;
    }

    public Customer Add(Customer customer)
    {
        _context.Costomers.Add(customer);
        _context.SaveChanges();
        return customer;
    }
}