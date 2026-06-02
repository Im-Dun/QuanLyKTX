using System.ComponentModel.DataAnnotations;

namespace QuanLyKTX.Models;

public class User
{
    [Key]
    public int UserId { get; set; }

    [Required]
    public string Username { get; set; }

    [Required]
    public string Password { get; set; }
}