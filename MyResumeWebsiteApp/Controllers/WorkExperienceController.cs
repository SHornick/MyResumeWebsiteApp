using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
public class WorkExperienceController : Controller
{
    [HttpGet("[action]")]
    public IEnumerable<WorkExperience> GetWorkExperience()
    {
        List<WorkExperience> WorkExperienceList = new List<WorkExperience>();

        WorkExperienceList.Add(new WorkExperience
        {
            CompanyName = "ethosIQ",
            Position = "Software Engineer Intern",
            EndDate = new DateTime(2018, 8, 27).ToString("d"),
            StartDate = new DateTime(2019, 5, 18).ToString("d")
        });
        WorkExperienceList.Add(new WorkExperience
        {
            CompanyName = "Salt 'n Pepper Group",
            Position = "Security/Bouncer",
            StartDate = new DateTime(2013, 10, 26).ToString("d"),
            EndDate = new DateTime(2018, 8, 26).ToString("d")
        });
        WorkExperienceList.Add(new WorkExperience
        {
            CompanyName = "Crystal Pool Services",
            Position = "Supervisor, Manager, Assistant Manager, Lifeguard, Maintenance",
            StartDate = new DateTime(2007, 5, 15).ToString("d"),
            EndDate = new DateTime(2013, 9, 1).ToString("d")
        });
        return WorkExperienceList;
    }

    public class WorkExperience
    {
        public string CompanyName { get; set; }
        public string Position { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string Duties { get; set; }
        public List<string> NotableProjects { get; set; }
    }
}