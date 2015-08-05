namespace HttpErrors.Mvc.Controllers
{
    using System.Web.Mvc;

    /// <summary>
    /// Displays error pages
    /// </summary>
    public sealed class ErrorsController : Controller
    {
        /// <summary>
        /// Used for authorization errors
        /// </summary>
        /// <returns>
        /// An <see cref="ActionResult" /> encapsulating a 403 error
        /// </returns>
        public ActionResult Forbidden()
        {
            this.Response.StatusCode = 403;

            return this.View();
        }

        /// <summary>
        /// Used for not found errors
        /// </summary>
        /// <returns>
        /// An <see cref="ActionResult" /> encapsulating a 404 error
        /// </returns>
        public ActionResult NotFound()
        {
            this.Response.StatusCode = 404;

            return this.View();
        }

        /// <summary>
        /// Used for unspecified errors
        /// </summary>
        /// <param name="code">
        /// The error code (defaults to 500)
        /// </param>
        /// <returns>
        /// An <see cref="ActionResult" /> encapsulating an unspecified error
        /// </returns>
        public ActionResult Other(int? code)
        {
            this.Response.StatusCode = code ?? 500;

            return this.View();
        }
    }
}
