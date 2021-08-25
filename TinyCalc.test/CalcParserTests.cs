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
        public void Sum_3_Plus_0_NotEq_0()
        {
            //Arrange
            int a = 3;
            int b = 0;
            //Act
            int result = CalcParser.Sum(a, b);
            //Assert
            Assert.NotNull(result);
            Assert.NotEqual(0,result);
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
        public void Substr_5_minus_10_NotEq_5()
        {
            //Arrange
            int a = 5;
            int b = 10;
            //Act
            int result = CalcParser.Substr(a,b);
            //Assert
            Assert.NotNull(result);
            Assert.NotEqual(5,result);
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
        [Fact]
        public void Multi_1_mult_5_NotEq_1()
        {
            //Arrange
            int a = 1;
            int b = 5;
            //Act
            int result = CalcParser.Multi(a,b);
            //Assert
            Assert.NotNull(result);
            Assert.NotEqual(1,result);
        }
        [Fact]
        public void Divide_9_div_3_Eq_3()
        {
            //Arrange
            int a = 9;
            int b = 3;
            //Act
            int result = CalcParser.Divide(a,b);
            //Assert
            Assert.NotNull(result);
            Assert.Equal(3,result);
        }
        [Fact]
        public void Divide_9_div_3_NOtEq_4()
        {
            //Arrange
            int a = 9;
            int b = 3;
            //Act
            int result = CalcParser.Divide(a,b);
            //Assert
            Assert.NotNull(result);
            Assert.NotEqual(4,result);
        }
    }
}