using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCard_MVC.ViewComponents
{
	public class LatestArticlesViewComponent : ViewComponent
	{
		public IViewComponentResult Invoke()
		{

            var articles = new List<Article>
            {
               new Article(1,"آموزش asp.net core mvc","کامل ترین پکیج آموزش asp.net core mvc","blog-post-thumb-card-3.jpg"),
               new Article(2,"آموزش git و github","کامل ترین پکیج آموزش git & github","blog-post-thumb-6.jpg"),
               new Article(3,"آموزش javascript","کامل ترین آموزش javascript","blog-post-thumb-4.jpg"),
            };
            return View("_LatestArticles",articles);
		}
	}
}
