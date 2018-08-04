using AutoMapper;
using Mongod.Infrastructure.Converters.Profiles;
using NUnit.Framework;

namespace Mongod.Infrastructure.Tests.Converters
{
    [SetUpFixture]
    public class AutoMapperConfigurationTests
    {
        [OneTimeSetUp]
        public void SetUp ()
        {
            Mapper.Initialize (cfg =>
            {
                cfg.AddProfile (new UserProfile ());
                cfg.AddProfile (new FlatProfile ());
                cfg.AddProfile (new AddressProfile ());

            });

            Mapper.AssertConfigurationIsValid ();
        }
    }
}