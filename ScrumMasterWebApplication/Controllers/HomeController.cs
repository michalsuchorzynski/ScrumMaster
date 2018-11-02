using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using ScrumMasterResource;
using ScrumMasterWebApplication.Models;

namespace ScrumMasterWebApplication.Controllers
{
    public class HomeController : Controller
    {
        private IStringLocalizer<SharedResource> _sharedLocalizer;

        public HomeController(IStringLocalizer<SharedResource> sharedLocalizer)
        {
            _sharedLocalizer = sharedLocalizer;
        }
        public string Index()
        {
            return _sharedLocalizer["Yes"];
        }

        
    }
}
