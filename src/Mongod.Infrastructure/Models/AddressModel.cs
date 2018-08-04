namespace Mongod.Infrastructure.Models
{
    public class AddressModel : BaseModel
    {
        public string ZipCode { get; set; }

        public string Street { get; set; }

        public string City { get; set; }

        public int BuildingNumber { get; set; }

        public int FlatNumber { get; set; }
    }
}