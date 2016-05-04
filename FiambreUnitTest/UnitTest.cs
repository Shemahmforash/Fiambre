using Xunit;
using Fiambre.Models;

namespace FiambreUnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void PassingTest()
        {
            Assert.Equal("bla", new Stuff().Bla());
        }
    }
}
