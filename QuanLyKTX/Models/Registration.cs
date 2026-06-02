using System.ComponentModel.DataAnnotations;

namespace QuanLyKTX.Models;

public class Registration
{
    [Key]
    public int RegistrationId { get; set; }

    public int StudentId { get; set; }

    public int RoomId { get; set; }

    public DateTime RegistrationDate { get; set; }

    public string Status { get; set; }

    public Student? Student { get; set; }

    public Room? Room { get; set; }
}