using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SDI_Test.Models;

namespace SDI_Test.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Form()
        {
			//Pass in an instanciated FormModel so the Guid is pre-generated
            return View(new FormModel());
        }

        [HttpPost]
		[ValidateAntiForgeryToken]
        public ActionResult Form(FormModel formModel)
        {
			//ensure that the data is valid from client
			if (ModelState.IsValid)
			{
				using (var db = new ApplicationDbContext())
				{
					//Add data to database
					db.Forms.Add(formModel);
					db.SaveChanges();
				}
				//Redirect to grid page after data is saved
				return RedirectToAction("Grid", "Home");
			}
			//If data is not valid, reload the page with previous enterd data.
			return View(formModel);
        }

        public ActionResult Grid()
        {
			
			using (var db = new ApplicationDbContext())
			{
				//Load all data from database into a table and pass to view as the Model
				return View(db.Forms.ToList());
			}
        }
    }
}