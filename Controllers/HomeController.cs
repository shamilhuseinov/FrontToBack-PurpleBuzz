using System;
using Microsoft.AspNetCore.Mvc;
using PurpleBuzz.Models;
using PurpleBuzz.ViewModels.Home;

namespace PurpleBuzz.Cntrollers
{
	public class HomeController:Controller
	{
		public IActionResult Index()
		{
			var works = new List<Work>
			{
				new Work{Id=1, Title="Social Media", Description="Social Media Description", PhotoPath="/assets/img/recent-work-01.jpg"},
				new Work{Id=2, Title="Web Marketing", Description="Web Marketing Description", PhotoPath="/assets/img/recent-work-02.jpg"},
                new Work{Id=3, Title="R & D", Description="R & D Description", PhotoPath="/assets/img/recent-work-03.jpg"}
            };

			ViewBag.WorksTitle = "Recent Works";

			var model = new HomeIndexVM
			{
				Works = works
			};

			return View(model);
		}
	}
}

