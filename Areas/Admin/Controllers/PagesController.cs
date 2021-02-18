using Project_ASP.Models.Data;
using Project_ASP.Models.ViewModel.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project_ASP.Areas.Admin.Controllers
{ 
    public class PagesController : Controller
    {
        // GET: Admin/Pages
        public ActionResult Index()
        {
            // declare list of pagesvm
            List<PageVM> pagesList;
            
            using (Db db = new Db())
            {
                // init the list
                pagesList = db.Pages.ToArray().OrderBy(x => x.Sorting).Select(x => new PageVM(x)).ToList();
            }

            // return view with list
            return View(pagesList);
        }

        // GET: Admin/Pages/AddPage
        public ActionResult AddPage()

        {
            return View();
        }
    }
} 