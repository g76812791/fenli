using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace NaoGuaZi.MvcExample12.Controllers.Admin {
	public class HomeController:Controller {
		public ViewResult Index() {
			return View("~/Views/Admin/Home/Index.cshtml");
		}
	}
}
