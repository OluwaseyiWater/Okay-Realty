using Microsoft.AspNetCore.Mvc;
using OkayRealty.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OkayRealty.ViewComponents
{
    public class ApartmentCountViewComponent
         : ViewComponent
    {
        private readonly IApartmentData apartmentData;

        public ApartmentCountViewComponent(IApartmentData apartmentData)
        {
            this.apartmentData = apartmentData;
        }

        public IViewComponentResult Invoke()
        {
            var count = apartmentData.GetCountOfApartments();
            return View(count);
        }

    }
}
