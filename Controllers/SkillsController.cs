using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SkillsTracker.Controllers
{
    [Route("/skills")]
    public class SkillsController : Controller
    {
        [HttpGet]        
        public IActionResult Index()
        {
            string html = "<h1>Skills Tracker</h1>" +
                "<h2>Coding skills to learn:</h2>" +
                "<ol>" +
                "<li>C#</li>" +
                "<li>Javascript</li>" +
                "<li>Python</li>" +
                "</ol";

            return Content(html, "text/html");
        }
        [HttpGet("form")]
        [HttpPost("form")]
        public IActionResult Skills(string skillsDate, string cSharp, string js, string python)
        {
            string optionValue = "<option value = ''>--Please choose an option--</ option >" +
                "<option value='Learning basics'>Learning basics</option>" +
                "<option value='Learning advanced features'>Learning advanced features</option>" +
                "<option value='Coding apps'>Coding apps</option>" +
                "<option value='Master coder'>Master coder</option>" +
                "</select></p>";

            string htmlForm = "<form method='post'action='/skills/form/'>" + 
                "<p><label for= 'dateForm'> Date: </ label>" +
                "<input type = 'date' id = 'dateForm' name = 'skillsDate' value = '2020-11-10' min = '1950-01-01' max = '2120-12-31' ></p>" +
                "<p><label for= 'cSharp'> C#: </ label>" +
                "<select name='cSharp' id='cSharp'>" +
                optionValue +
                "<p><label for= 'js'> JavaScript: </ label>" +
                "<select name='js' id='js'>" +
                optionValue +
                "<p><label for= 'python'> Python: </ label>" +
                "<select name='python' id='python'>" +
                optionValue +
                "<br>" +
                "<input type='submit' value='Submit' />" +
                "</form>";

            if (skillsDate == null)
            {
                return Content(htmlForm, "text/html");
            }            

            string htmlSummary = "<h1> " + skillsDate + " </h1>" +
                "<ol>" +
                "<li>C#: " + cSharp + " </li>" +
                "<li>Javascript: " + js + " </li>" +
                "<li>Python: " + python + " </li>" +
                "</ol";

            return Content(htmlSummary, "text/html");
        }
    }
}
