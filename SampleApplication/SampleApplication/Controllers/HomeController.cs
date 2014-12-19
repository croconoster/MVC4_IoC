using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Security.AccessControl;
using SampleApplication.Interfaces;

namespace SampleApplication.Controllers
{
	public class HomeController : Controller
	{
		private IMessageService _messageService;

		public HomeController (IMessageService messageService)
		{
			_messageService = messageService;
		}

		public ActionResult Index ()
		{
			ViewBag.Title = _messageService.GetMessage ();

			return View ();
		}
	}
}

