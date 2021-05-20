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
    public class DeleteModel : PageModel
    {
        private readonly IApartmentData apartmentData;

        public Apartment Apartment { get; set; }

        public DeleteModel(IApartmentData apartmentData)
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

        public IActionResult OnPost(int apartmentId)
        {
            var apartment = apartmentData.Delete(apartmentId);
            apartmentData.Commit();

            if (apartment == null)
            {
                return RedirectToPage("./NotFound");
            }

            TempData["Message"] = $"{apartment.Name} deleted";
            return RedirectToPage("./List");
        }
    }
}