using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using Ext.Net;
using Ext.Net.Core;

using ExtNetMvcWithOracle.Models;

namespace ExtNetMvcWithOracle.Controllers {
    public class DirectEventController : Controller {
        public IActionResult Index() {
            return View();
        }

        public IActionResult ButtonClick() {
            this.X().Toast($"Server Time is { DateTime.Now.ToString("H:mm:ss tt") } 👍");

            return this.Direct();
        }
    }
}