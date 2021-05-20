using OkayRealty.Core;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OkayRealty.Data
{
    public class InMemoryApartmentData : IApartmentData

    {
        readonly List<Apartment> apartments;
        public InMemoryApartmentData()
        {
            apartments = new List<Apartment>()
            {
                new Apartment { Id = 1, Name = "Flourish palace", Location="Lekki Chevron", Building=BuildingType.Bungalow},
                new Apartment { Id = 2, Name = "Mansori", Location="Ikoyi", Building=BuildingType.Detached},
                new Apartment { Id = 3, Name = "Villahut", Location="Osapa London", Building=BuildingType.Duplex},
                new Apartment { Id = 4, Name = "Roller Rays", Location="Banana Island", Building=BuildingType.SemiDetached}
            };
        }

        public Apartment GetById(int id)
        {
            return apartments.SingleOrDefault(a => a.Id == id);
        }

        public Apartment Add(Apartment newApartment)
        {
            apartments.Add(newApartment);
            newApartment.Id = apartments.Max(a => a.Id) + 1;
            return newApartment;
        }

        public Apartment Update(Apartment updatedApartment)
        {
            var apartment = apartments.SingleOrDefault(a => a.Id == updatedApartment.Id);
            if (apartment != null)
            {
                apartment.Name = updatedApartment.Name;
                apartment.Location = updatedApartment.Location;
                apartment.Building = updatedApartment.Building;
            }
            return apartment;
        }

        public int Commit()
        {
            return 0;
        }
        public IEnumerable<Apartment> GetApartmentsByName(string name = null)
        {
            return from a in apartments
                   where string.IsNullOrEmpty(name) || a.Name.StartsWith(name)
                   orderby a.Name
                   select a;

        }

        public Apartment Delete(int id)
        {
            var apartment = apartments.FirstOrDefault(a => a.Id == id);

            if(apartment != null)
            {
                apartments.Remove(apartment);
            }
            return null;
        }
        

        public int GetCountOfApartments()
        {
            return apartments.Count();
        }
    }
}
