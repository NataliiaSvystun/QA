using QA.Common;
using QA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QA.Controllers
{
    public class HomeController : Controller
    {
        private readonly IQuestionProvider questionProvider;

        public HomeController(IQuestionProvider questionProvider)
        {
            this.questionProvider = questionProvider;
        }

        public ActionResult Index()
        {
            List<Question> questions= this.questionProvider.GetQuestions();
            return View(questions);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}