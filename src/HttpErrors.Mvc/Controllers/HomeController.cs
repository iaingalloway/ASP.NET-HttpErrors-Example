namespace HttpErrors.Mvc.Controllers
{
    using System;
    using System.Web.Mvc;

    public sealed class HomeController : Controller
    {
        public ActionResult Index()
        {
            return this.View();
        }

        public ActionResult Forbidden()
        {
            return new HttpStatusCodeResult(403);
        }

        public ActionResult Other()
        {
            throw new InvalidOperationException();
        }
    }
}
