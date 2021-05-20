using OkayRealty.Core;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OkayRealty.Data
{
    public interface IApartmentData
    {
        IEnumerable<Apartment> GetApartmentsByName(string name);
        Apartment GetById(int id);
        Apartment Update(Apartment updatedApartment);
        Apartment Add(Apartment newApartment);
        Apartment Delete(int id);
        int GetCountOfApartments();
        int Commit();
    }
}
