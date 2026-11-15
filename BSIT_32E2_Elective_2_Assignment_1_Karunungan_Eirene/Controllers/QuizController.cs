using BSIT_32E2_Elective_2_Assignment_1.Models;
using Microsoft.AspNetCore.Mvc;

namespace BSIT_32E2_Elective_2_Assignment_1.Controllers
{
    public class QuizController : Controller
    {
        public IActionResult Index()
        {
            var questions = new List<QuizQuestion>
            {
                new()
                {
                    Number = 1,
                    Question = "What is the fundamental difference between Server-Side Rendering (SSR/MVC) and a Decoupled Web API architecture?",
                    Options = new()
                    {
                        ['A'] = "SSR returns JSON payloads, whereas a Web API compiles .cshtml Razor views on the server.",
                        ['B'] = "SSR compiles HTML views on the server and sends fully rendered markup to the browser, whereas a Web API acts as a stateless data provider returning raw JSON.",
                        ['C'] = "SSR only works with mobile applications, whereas Web APIs are restricted to desktop web browsers.",
                        ['D'] = "SSR requires client-side routing in React, whereas Web APIs manage HTML layouts directly on the server."
                    },
                    CorrectAnswer = 'B',
                    Explanation = "MVC renders HTML on the server; a Web API only supplies data (JSON) and leaves presentation to the client."
                }
            };

            return View(questions);
        }
    }
}