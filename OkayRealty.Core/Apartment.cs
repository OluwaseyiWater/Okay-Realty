
using System.ComponentModel.DataAnnotations;


namespace OkayRealty.Core
{
    public class Apartment
    {
        public int Id { get; set; }

        [Required, StringLength(80)]
        public string Name { get; set; }

        [Required, StringLength(255)]
        public string Location { get; set; }
        public BuildingType Building { get; set; }
    }
}
