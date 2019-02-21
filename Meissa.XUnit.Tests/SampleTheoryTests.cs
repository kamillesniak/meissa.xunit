using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Meissa.XUnit.Tests
{
    public class SampleTheoryTests
    {
        [Theory]
        [InlineData(1)]
        public void Theory_test_1(int number)
        {
             
        }
        [Theory]
        [InlineData(1)]
        public void Theory_test_2(int number)
        {

        }
    }
}
