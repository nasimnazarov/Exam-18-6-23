using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;
[ApiController]
[Route("[controller]")]

public class CustomerController : ControllerBase
{
    private readonly CustomerService _customerService;

    public CustomerController(CustomerService customerService)
    {
        _customerService = customerService;
    }

    [HttpGet("GetCustomer")]
    public List<Customer> GetCustomers()
    {
        return _customerService.GetCustomers();
    }

    [HttpPost("AddCustomer")]
    public Customer Add(Customer customer)
    {
        var result = _customerService.Add(customer);
        return customer;
    }
}