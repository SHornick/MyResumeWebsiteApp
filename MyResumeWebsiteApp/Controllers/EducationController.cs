using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MyResumeWebsiteApp.Controllers
{
    [Route("api/[controller]")]
    public class EducationController : Controller
    {
        [HttpGet("[action]")]
        public IEnumerable<School> GetSchoolList()
        {
            List<School> SchoolList = new List<School>();

            SchoolList.Add(new School
            {
                Name = "University of Houston - Downtown",
                Location = "Houston, TX",
                Major = "B.S. Computer Science",
                StartDate = new DateTime(2017, 8, 15).ToString("MM/yyyy"),
                EndDate = new DateTime(2019, 5, 18).ToString("MM/yyyy")
            });
            SchoolList.Add(new School
            {
                Name = "Houston Community College",
                Location = "Houston, TX",
                Major = "A.S. Computer Science",
                StartDate = new DateTime(2015, 1, 15).ToString("MM/yyyy"),
                EndDate = new DateTime(2016, 12, 15).ToString("MM/yyyy")
            });

            return SchoolList;
        }

        public class School
        {
            public string Name { get; set; }
            public string Location { get; set; }
            public string Major { get; set; }
            public string StartDate { get; set; }
            public string EndDate { get; set; }
        }
    }
}