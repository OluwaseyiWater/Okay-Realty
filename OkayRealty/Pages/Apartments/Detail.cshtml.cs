using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OkayRealty.Core;
using OkayRealty.Data;

namespace OkayRealty.Pages.Apartments
{
    public class DetailModel : PageModel
    {
        private readonly IApartmentData apartmentData;

        [TempData]
        public string Message { get; set; }

        public Apartment Apartment { get; set; }

        public DetailModel(IApartmentData apartmentData)
        {
            this.apartmentData = apartmentData;
        }

        public IActionResult OnGet(int apartmentId)
        {
            Apartment = apartmentData.GetById(apartmentId);
            if (Apartment == null)
            {
                return RedirectToPage("./NotFound");
            }
            return Page();
        }
    }
}