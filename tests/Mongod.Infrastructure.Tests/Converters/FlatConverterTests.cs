using Mongod.Domain.Entities;
using Mongod.Infrastructure.Converters;
using Mongod.Infrastructure.Converters.Interfaces;
using Mongod.Infrastructure.Models;
using NUnit.Framework;

namespace Mongod.Infrastructure.Tests.Converters
{
    [TestFixture]
    public class FlatConverterTests
    {
        private IConverter<Flat,FlatModel> _sut;
        
        [SetUp]
        public void SetUp ()
        {
            _sut = new FlatConverter(AutoMapperConfigurationTests._mapper);
        }   
    }
}