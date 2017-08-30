using Xunit;

namespace TDD.Kata.StringCalculator.Tests.Unit
{
   
    public class StringCalculatorTest
    {
        public StringCalculator Target;

        public StringCalculatorTest()
        {
            this.Target = new StringCalculator();
        }

        [Fact]
        public void debe_devolver_un_cero()
        {
            //Arrange
            string numbers = string.Empty;

            //Act
           int result = Target.add(numbers);

            //assert
            Assert.True(0==result);
        }
    }
}
