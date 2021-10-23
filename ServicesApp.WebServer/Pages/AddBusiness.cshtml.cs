using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ServicesApp.Core;
using ServicesApp.DAL;

namespace ServicesApp.WebServer.Pages
{
    public class AddBusinessModel : PageModel
    {

        [BindProperty]
        public Services AddedServices { get; set; }
        private BusinessService _service;


        public AddBusinessModel(BusinessService service)
        {
            this._service = service;
        }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (this.ModelState.IsValid)
            {
                this._service.AddServices(this.AddedServices);
                return RedirectToPage("/Index");
            }
            return BadRequest();
        }
    }
}
