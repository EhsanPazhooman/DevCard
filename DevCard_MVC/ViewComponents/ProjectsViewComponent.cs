using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DevCard_MVC.ViewComponents
{
    public class ProjectsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var projects = new List<Project>
            {
                new Project(1,"تاکسی","درخواست آنلاین تاکسی برای سفرهای درون شهری","project-1.jpg","Snapp"),
                new Project(2, "زودفود", "درخواست آنلاین غذا برای سراسر کشور","project-figure-2.jpg","Snapfood"),
                new Project(3,"مدارس","سیستم مدیریت یکپارچه مدارس","project-figure-1.jpg","monop"),
                new Project(4,"فضاپیما","برنامه مدیریت فضاپیماهای ناسا","project-6.jpg","Nasa"),
            };
            return View("_Projects",projects);
        }
    }
}
