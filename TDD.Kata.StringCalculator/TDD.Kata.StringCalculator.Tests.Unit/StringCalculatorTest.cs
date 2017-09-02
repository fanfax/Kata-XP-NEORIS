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
            Assert.True(0 == result);
        }

        [Fact]
        public void debe_devolver_el_mismo_numero()
        {
            //Arrange
            string numbers = "4";
            int numbersInt = int.Parse(numbers);

            //Act
            int result = Target.add(numbers);

            //Assert
            Assert.True(result == numbersInt);
        }

        [Fact]
        public void debe_devolver_la_suma_de_los_2_numeros()
        {
            //Arrange
            string numbers = "4,3";
            int numbersTotal = 7;

            //Act
            int result = Target.add(numbers);

            //Assert
            Assert.True(result == numbersTotal);
        }

        [Fact]
        public void debe_devolver_la_suma_de_todos_los_numeros()
        {
            //Arrange
            string numbers = "1,23,4,11,53";
            int numbersTotal = 1 + 23 + 4 + 11 + 53;

            //Act
            int result = Target.add(numbers);

            //Assert
            Assert.True(result == numbersTotal);
        }
    }
}
