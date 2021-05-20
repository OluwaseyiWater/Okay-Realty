using System.Collections.Generic;
using OkayRealty.Core;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace OkayRealty.Data
{
    public class SqlApartmentData : IApartmentData
    {
        private readonly OkayRealtyDbContext db;

        public SqlApartmentData(OkayRealtyDbContext db)
        {
            this.db = db;
        }

        public Apartment Add(Apartment newApartment)
        {
            db.Add(newApartment);
            return newApartment;
        }

        public int Commit()
        {
            return db.SaveChanges();
        }

        public Apartment Delete(int id)
        {
            var apartment = GetById(id);
            if (apartment != null)
            {
                db.Apartments.Remove(apartment);
            }
            return apartment;
        }

        public Apartment GetById(int id)
        {
            return db.Apartments.Find(id);
        }

        public int GetCountOfApartments()
        {
            return db.Apartments.Count();
        }

        public IEnumerable<Apartment> GetApartmentsByName(string name)
        {
            var query = from a in db.Apartments
                        where a.Name.StartsWith(name) || string.IsNullOrEmpty(name)
                        orderby a.Name
                        select a;
            return query;
        }

        public Apartment Update(Apartment updatedApartment)
        {
            var entity = db.Apartments.Attach(updatedApartment);
            entity.State = EntityState.Modified;
            return updatedApartment;
        }
    }
}
