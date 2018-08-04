using AutoMapper;
using Mongod.Infrastructure.Converters.Profiles;
using NUnit.Framework;

namespace Mongod.Infrastructure.Tests.Converters
{
    [SetUpFixture]
    public class AutoMapperConfigurationTests
    {
        public static IMapper _mapper;
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
            _mapper = new Mapper(Mapper.Configuration);
        }
    }
}