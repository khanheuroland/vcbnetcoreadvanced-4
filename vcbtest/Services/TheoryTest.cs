using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace vcbtest.Services
{
    public class TheoryTest
    {
        [Theory]
        [InlineData("VCB", "VIB")]
        [InlineData("STB", "MBB")]
        public void Test(String p1, String p2)
        {
            Assert.Equal("VCB", p1);
            Assert.Equal("VIB", p2);
        }
    }
}