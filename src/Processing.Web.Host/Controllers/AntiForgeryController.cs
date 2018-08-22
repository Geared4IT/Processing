using Microsoft.AspNetCore.Antiforgery;
using Processing.Controllers;

namespace Processing.Web.Host.Controllers
{
    public class AntiForgeryController : ProcessingControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
