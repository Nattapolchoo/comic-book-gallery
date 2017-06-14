using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Detail()
        {
            return View();
            
        }
        
    }
}


//Controller's public method is an action method that prepare the response to the view
//Content result is an action result type  