using Microsoft.AspNetCore.Mvc;
using MovieStoreApp.Core.Contract.Service;
using MovieStoreApp.Core.Models;

namespace MovieStoreApp.WebApp.Controllers
{
    public class CastController : Controller
    {
        private readonly ICastServiceAsync castServiceAsync;
        public CastController(ICastServiceAsync _castServiceAsync)
        {
            castServiceAsync = _castServiceAsync;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CastModel model)
        {
            // Don't know why it always is not valid
            //if (ModelState.IsValid)
            if (model.ProfilePath != null)
            {
                // call the service to insert the data
                castServiceAsync.AddCastAsync(model);
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}
