namespace Mongod.Infrastructure.Models
{
    public class FlatModel : BaseModel
    {
        public UserModel Owner { get; set; }

        public AddressModel Address { get; set; }

        public int RoomsCount { get; set; }
    }
}