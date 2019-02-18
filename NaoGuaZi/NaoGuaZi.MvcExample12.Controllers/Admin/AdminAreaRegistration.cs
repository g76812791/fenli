﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
namespace NaoGuaZi.MvcExample12.Controllers.Admin {
	public class AdminAreaRegistration : AreaRegistration {
		public override string AreaName {
			get {
				return "Admin";
			}
		}
		public override void RegisterArea(AreaRegistrationContext context) {
			context.MapRoute(
				"Admin_default",
				"Admin/{controller}/{action}/{id}",
				new { controller = "Home", action = "Index", id = UrlParameter.Optional },
				new string[] {"NaoGuaZi.MvcExample12.Controllers.Admin"}
			);
		}
	}
}
