using System.ComponentModel.DataAnnotations;

namespace QuanLyKTX.Models;

public class Student
{
    [Key]
    public int StudentId { get; set; }

    [Required]
    public string FullName { get; set; }

    public string Gender { get; set; }

    public string Phone { get; set; }

    public string Email { get; set; }
}