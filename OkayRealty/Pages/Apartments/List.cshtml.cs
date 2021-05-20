using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using OkayRealty.Core;
using OkayRealty.Data;

namespace OkayRealty.Pages.Apartments
{
    public class ListModel : PageModel
    {
        private readonly IConfiguration config;
        private readonly IApartmentData apartmentData;

        public string Message { get; set; }
        public IEnumerable<Apartment>Apartments { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SearchTerm { get; set; }

        public ListModel(IConfiguration config, 
                         IApartmentData apartmentData)
        {
            this.config = config;
            this.apartmentData = apartmentData;
        }

        public void OnGet()
        {
            Message = config["Message"];
            Apartments = apartmentData.GetApartmentsByName(SearchTerm); 
        }
    }
}
