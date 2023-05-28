using System;
using Microsoft.AspNetCore.Mvc;
using PurpleBuzz.Models;
using PurpleBuzz.ViewModels.About;

namespace PurpleBuzz.Controllers
{
	public class AboutController:Controller
	{
		public IActionResult Index()
		{
			var pinneds = new List<Pinned>
			{
				new Pinned{Id=1, Title="Our Vision", Description="Our Vision Description", IconPath="display-4 bx bxs-bulb text-light"},
				new Pinned{Id=2, Title="Our Mission", Description="Our Mission Description", IconPath="display-4 bx bx-revision text-light"},
                new Pinned{Id=3, Title="Our Goal", Description="Our Goal Description", IconPath="display-4 bx bxs-select-multiple text-light"}

            };
			var model = new AboutIndexVM
			{
				Pinneds=pinneds
			};
			return View(model);
		}

	}
}

