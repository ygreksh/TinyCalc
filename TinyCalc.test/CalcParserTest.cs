using Xunit;

namespace TinyCalc.test
{
    public class CalcParserTest
    {
        [Fact]
        public void Sum_2_Plus_2_Eq_4()
        {
            //Arrange
            int a = 2;
            int b = 2;
            //Act
            int result = CalcParser.Sum(a, b);
            //Assert
            Assert.NotNull(result);
            Assert.Equal(4,result);
        }
        [Fact]
        public void Sum_2_Plus_0_Eq_2()
        {
            //Arrange
            int a = 2;
            int b = 0;
            //Act
            int result = CalcParser.Sum(a, b);
            //Assert
            Assert.NotNull(result);
            Assert.Equal(2,result);
        }
        [Fact]
        public void Substr_2_minus_2_Eq_0()
        {
            //Arrange
            int a = 2;
            int b = 2;
            //Act
            int result = CalcParser.Substr(a,b);
            //Assert
            Assert.NotNull(result);
            Assert.Equal(0,result);
        }
        [Fact]
        public void Substr_5_minus_10_Eq_min5()
        {
            //Arrange
            int a = 5;
            int b = 10;
            //Act
            int result = CalcParser.Substr(a,b);
            //Assert
            Assert.NotNull(result);
            Assert.Equal(-5,result);
        }
        [Fact]
        public void Multi_3_mult_4_Eq_12()
        {
            //Arrange
            int a = 3;
            int b = 4;
            //Act
            int result = CalcParser.Multi(a,b);
            //Assert
            Assert.NotNull(result);
            Assert.Equal(12,result);
        }
    }
}