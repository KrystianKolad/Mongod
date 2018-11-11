using System;

namespace Mongod.Infrastructure.Models
{
    public class AdModel : BaseModel
    {
        public Guid Id { get; set; }
        public UserModel Owner { get; set; }

        public AddressModel Address { get; set; }

        public string Title { get; set; }
        public string Description{ get; set; }
    }
}