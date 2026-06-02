using System.ComponentModel.DataAnnotations;

namespace QuanLyKTX.Models;

public class Room
{
    [Key]
    public int RoomId { get; set; }

    [Required]
    [StringLength(20)]
    public string RoomCode { get; set; }

    [Required]
    [StringLength(100)]
    public string RoomName { get; set; }

    [Range(1, 20)]
    public int Capacity { get; set; }

    public int CurrentOccupancy { get; set; }

    public string Status { get; set; } = "Available";
}