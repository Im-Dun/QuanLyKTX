using Microsoft.AspNetCore.Mvc;
using QuanLyKTX.Data;

namespace QuanLyKTX.Controllers;

public class LoginController : Controller
{
    private readonly AppDbContext _context;

    public LoginController(AppDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Index(string username, string password)
    {
        var user = _context.Users
            .FirstOrDefault(x =>
                x.Username == username &&
                x.Password == password);

        if (user == null)
        {
            ViewBag.Error = "Sai tài khoản hoặc mật khẩu";
            return View();
        }

        HttpContext.Session.SetString(
            "Username",
            user.Username);

        return RedirectToAction(
            "Index",
            "Dashboard");
    }

    public IActionResult Logout()
    {
        HttpContext.Session.Clear();

        return RedirectToAction(
            "Index",
            "Login");
    }
}