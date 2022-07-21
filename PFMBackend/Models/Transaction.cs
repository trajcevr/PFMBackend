
using Microsoft.EntityFrameworkCore;
using PFMBackend.Models;
using PFMBackend.Data.Entities;
using System.ComponentModel.DataAnnotations;


public class Transaction
{
    [Key]
    public string? Id { get; set; }
    [Required]
    public string? BeneficiaryName { get; set; }
    [Required]
    public string? date { get; set; }
    [Required]
    public TransactionDirection direction { get; set; }
    [Required]
    public double amount { get; set; }
    [Required]
    public string? description { get; set; }
    [Required]
    public string? currency { get; set; }
    public string? mcc { get; set; }
    [Required]
    public TransactionKind kind { get; set; } 
}