using Dapper.Contrib.Extensions;

namespace StoreApi.Models;

public class Store
{
    [Key]
    public int StoreId { get; set; }
    public string StoreName { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public string Street { get; set; }
    public string City { get; set; }
    public string State { get; set; }
}
