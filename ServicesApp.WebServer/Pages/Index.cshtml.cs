using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using ServicesApp.Core;
using ServicesApp.DAL;

namespace ServicesApp.WebServer.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly BusinessService _businessService;
        public List<Services> BusinessList = new List<Services>();

        public IndexModel(ILogger<IndexModel> logger, BusinessService businessService)
        {
            _logger = logger;
            this._businessService = businessService;
        }

        public void OnGet()
        {
            this.BusinessList = this._businessService.GetAllServices();
        }
    }
}
