using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using NaoGuaZi.MvcExample12.Controllers.Models;

namespace NaoGuaZi.MvcExample12.Controllers {
	public class HomeController:Controller {
		public ViewResult Index() {

            MyEntity  en= new MyEntity();
		    en.Name = "abc";
			return View(en);
		}
	}
}
