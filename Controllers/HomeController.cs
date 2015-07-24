using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fuget.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index ()
		{
			var db = new SqlDatabase ();
			ViewBag["thing"] = db.Thing;
			return View ();
		}
	}
}