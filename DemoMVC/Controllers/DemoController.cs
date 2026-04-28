using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers
{
    public class DemoController : Controller
    {
        // Hàm Index này sẽ được gọi khi người dùng vào đường dẫn /Demo hoặc /Demo/Index
        public IActionResult Index()
        {
            return View(); // Lệnh này ra chỉ thị: "Hãy đi tìm giao diện hiển thị cho tôi"
        }
    }
}