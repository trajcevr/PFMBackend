
using Microsoft.EntityFrameworkCore;
namespace PFMBackend.Models;

[Keyless]
public class Transaction
{
    
    public string id { get; set; } 
    public string beneficiary_name { get; set; }
    public string date { get; set; }
    public string direction { get; set; }
    public double amount { get; set; }
    public string description { get; set; }
    public string currency { get; set; }
    public string mcc { get; set; } 
    public string kind { get; set; } 
}