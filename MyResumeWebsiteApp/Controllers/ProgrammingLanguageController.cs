using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyResumeWebsiteApp.Controllers
{
    [Route("api/[controller]")]
    public class ProgrammingLanguageController : Controller
    {
        [HttpGet("[action]")]
        public IEnumerable<ProgrammingLanguage> ProgrammingLanguages()
        {
            List<ProgrammingLanguage> ProgrammingLanguageList = new List<ProgrammingLanguage>();

            ProgrammingLanguageList.Add(new ProgrammingLanguage
            {
                LanguageName = "C#",
                ProgrammingLanguageLevel = 8,
                SkillsUsed = "LINQ, EF, EF Core, Windows Forms, WPF (MVVM), ASP.NET (MVC, WebAPI), Razor"
            });
            ProgrammingLanguageList.Add(new ProgrammingLanguage
            {
                LanguageName = "C++",
                ProgrammingLanguageLevel = 6,
            });
            ProgrammingLanguageList.Add(new ProgrammingLanguage
            {
                LanguageName = "Python",
                ProgrammingLanguageLevel = 5,
                SkillsUsed = "OpenCV, NumPy, SciPy, matplotlib, Jupyter Notebook, Spyder"
            });
            ProgrammingLanguageList.Add(new ProgrammingLanguage
            {
                LanguageName = "C",
                ProgrammingLanguageLevel = 5
            });
            ProgrammingLanguageList.Add(new ProgrammingLanguage
            {
                LanguageName = "SQL",
                ProgrammingLanguageLevel = 5,
                SkillsUsed = "Oracle, MySQL, SQLite, PostgreSQL, MSSQL, MySQL"
            });
            ProgrammingLanguageList.Add(new ProgrammingLanguage
            {
                LanguageName = "Java SE",
                ProgrammingLanguageLevel = 4
            });
            ProgrammingLanguageList.Add(new ProgrammingLanguage
            {
                LanguageName = "CSS",
                ProgrammingLanguageLevel = 3,
                SkillsUsed = "Bootstrap"
            });
            ProgrammingLanguageList.Add(new ProgrammingLanguage
            {
                LanguageName = "HTML5",
                ProgrammingLanguageLevel = 2
            });
            ProgrammingLanguageList.Add(new ProgrammingLanguage
            {
                LanguageName = "Javascript",
                ProgrammingLanguageLevel = 2,
                SkillsUsed = "Angular, AJAX"
            });
            return ProgrammingLanguageList;
        }

        public class ProgrammingLanguage
        {
            public string LanguageName { get; set; }
            public int ProgrammingLanguageLevel { get; set; }
            public string SkillsUsed { get; set; }
        }
    }
}
