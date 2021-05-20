using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using OkayRealty.Core;
using OkayRealty.Data;

namespace OkayRealty.Pages.Apartments
{
    public class EditModel : PageModel
    {
        private readonly IApartmentData apartmentData;
        private readonly IHtmlHelper htmlHelper;

        [BindProperty]
        public Apartment Apartment { get; set; }
        public IEnumerable<SelectListItem> Buildings { get; set; }

        public EditModel(IApartmentData apartmentData,
                         IHtmlHelper htmlHelper)
        {
            this.apartmentData = apartmentData;
            this.htmlHelper = htmlHelper;
        }

        public IActionResult OnGet(int? apartmentId)
        {
            Buildings = htmlHelper.GetEnumSelectList<BuildingType>();
            if (apartmentId.HasValue)
            {
                Apartment = apartmentData.GetById(apartmentId.Value);
            }
            else
            {
                Apartment = new Apartment();
            }
            if (Apartment == null)
            {
                return RedirectToPage("./NotFound");
            }
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                Buildings = htmlHelper.GetEnumSelectList<BuildingType>();
                return Page();
            }

            if (Apartment.Id > 0)
            {
                apartmentData.Update(Apartment);
            }
            else
            {
                apartmentData.Add(Apartment);
            }
            apartmentData.Commit();
            TempData["Message"] = "Apartment saved!";
            return RedirectToPage("./Detail", new { apartmentId = Apartment.Id });
        }
    }
}