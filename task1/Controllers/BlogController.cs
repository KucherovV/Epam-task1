using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using task1.Models;
using task1.ViewModels;

namespace task1.Controllers
{
    public class BlogController : Controller
    {     

        // GET: Blog
        public ActionResult Index()
        {
            return View(Storage.articles);
        }

        public ActionResult GuestRoom()
        {
            return View(Storage.feedbacks);
        }

        [HttpGet]
        public ActionResult Addfeedback()
        {
            FeedbackViewModel fbvm = new FeedbackViewModel();
            fbvm.feedbacks = Storage.feedbacks;
            fbvm.feedback = new Feedback();
            return View("GuestRoom", fbvm);
        }

        [HttpPost]
        public ActionResult Addfeedback(FeedbackViewModel viewModel)
        {
            viewModel.feedback.Date = DateTime.Now;
            Storage.feedbacks.Add(viewModel.feedback);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Form()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Form(Form form)
        {
            return View("Formresults", form);
        }
    }
}