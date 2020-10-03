using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BlogSite.Controllers
{
    [Route("error")]
    public class ErrorController : Controller
    {
        //private readonly TelemetryClient _telemetryClient;

        public ErrorController()
        {
           // _telemetryClient = telemetryClient;
        }

        [Route("500")]
        public IActionResult AppError()
        {
            //var exceptionHandlerPathFeature = HttpContext.Features.Get<IExceptionHandlerPathFeature>();
            //_telemetryClient.TrackException(exceptionHandlerPathFeature.Error);
            //_telemetryClient.TrackEvent("Error.ServerError", new Dictionary<string, string>
            //{
            //    ["originalPath"] = exceptionHandlerPathFeature.Path,
            //    ["error"] = exceptionHandlerPathFeature.Error.Message
            //});
            return View();
        }
    }
}
