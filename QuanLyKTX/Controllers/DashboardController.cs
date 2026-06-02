using Microsoft.AspNetCore.Mvc;
using QuanLyKTX.Data;

namespace QuanLyKTX.Controllers;

public class DashboardController : Controller
{
    private readonly AppDbContext _context;

    public DashboardController(AppDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        if (HttpContext.Session.GetString("Username") == null)
        {
            return RedirectToAction("Index", "Login");
        }
        ViewBag.TotalRooms =
            _context.Rooms.Count();

        ViewBag.TotalStudents =
            _context.Students.Count();

        ViewBag.TotalRegistrations =
            _context.Registrations.Count();

        ViewBag.TotalInvoices =
            _context.Invoices.Count();

        ViewBag.AvailableRooms =
    _context.Rooms.Count(r => r.Status == "Available");

        ViewBag.FullRooms =
            _context.Rooms.Count(r => r.Status == "Full");

        ViewBag.PaidInvoices =
            _context.Invoices.Count(i => i.Status == "Đã thanh toán");

        ViewBag.UnpaidInvoices =
            _context.Invoices.Count(i => i.Status == "Chưa thanh toán");

        return View();
    }
}