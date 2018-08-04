namespace Mongod.Domain.Entities
{
    public class Flat : BaseEntity
    {
        public User Owner { get; set; }
        public Address Address { get; set; }
        public int RoomsNumber { get; set; }
    }
}