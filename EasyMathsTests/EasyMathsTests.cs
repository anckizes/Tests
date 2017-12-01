using System;
using Xunit;
using EasyMaths;

namespace EasyMathsTests
{
    public class EasyMathsTest
    {
        [Fact]
        public void Test1()
        {
            Assert.True(true);
        }
        
        [Fact]
        public void Given_NTP_when_Inecremenr_recieves_two_Integers_should_return_a_number_higher_or_equal_both_given_numbers()
        {
        //Given
            Random random = new Random();
            int Int1 = random.Next();
            int Int2 = random.Next();
            EasyMath easyMaths = new EasyMath();
        //When
            int result = easyMaths.Increment(Int1,Int2);
        //Then
            Assert.True(Int1 <= result);
            Assert.True(Int2 <= result);
        }
    }
}
