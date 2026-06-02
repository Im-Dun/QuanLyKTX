using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyKTX.Models;

public class Invoice
{
    [Key]
    public int InvoiceId { get; set; }

    public int StudentId { get; set; }

    [Column(TypeName = "decimal(18,2)")]
    public decimal Amount { get; set; }

    public DateTime DueDate { get; set; }

    public string Status { get; set; }

    public Student? Student { get; set; }
}