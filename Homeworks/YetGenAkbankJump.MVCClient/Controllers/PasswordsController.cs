using Microsoft.AspNetCore.Mvc;

namespace YetGenAkbankJump.MVCClient.Controllers
{
	public class PasswordsController : Controller
	{

		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}
	}
}
