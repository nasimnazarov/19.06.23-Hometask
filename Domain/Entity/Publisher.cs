using System.ComponentModel.DataAnnotations;
using System.Transactions;

namespace Domain.Entity;

public class Publisher
{
    [Key]
    public int PubId { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string State { get; set; }
}