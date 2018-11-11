using System;
using Bogus;
using Mongod.Domain.Entities;
using Mongod.Domain.Repositories;
using MongoDB.Driver;

namespace Mongod.Faker
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("I exist ony to Fake!");

            var connectionString = "mongodb://localhost:27017";

            var repo = new BaseRepository<Ad>(new MongoClient(connectionString));

            var testAddresses = new Faker<Address>()
                .RuleFor(x=>x.BuildingNumber, f => f.Random.Number(1,100))
                .RuleFor(x=>x.City, f => f.Address.City())
                .RuleFor(x=>x.Street, f => f.Address.StreetName())
                .RuleFor(x=>x.ZipCode, f => f.Address.ZipCode())
                .RuleFor(x=>x.FlatNumber, f => f.Random.Number(1,100))
                .Generate(50);

            var testOwners = new Faker<User>()
                .RuleFor(x=>x.Name, f => f.Name.FirstName())
                .RuleFor(x=>x.Surname, f => f.Name.LastName())
                .Generate(20);

            var testAds = new Faker<Ad>()
                .RuleFor(x=>x.Address, f => f.PickRandom(testAddresses))
                .RuleFor(x=>x.Owner, f => f.PickRandom(testOwners))
                .RuleFor(x=>x.Title, f => f.Commerce.ProductName())
                .RuleFor(x=>x.Description, f => f.Commerce.ProductAdjective())
                .Generate(34);
                
            foreach (var item in testAds)
            {
                repo.AddAsync(item).GetAwaiter().GetResult();
            }

            System.Console.WriteLine("And I just did it!");
        }
    }
}
