using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        public string Detail()
        {
            return "Hello from the comic book controller";
        }
    }
}


//Controller's public method is an action method that prepare the response to the view