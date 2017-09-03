using System;
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

            //Assetr
            Assert.True(result == numbersTotal);
        }

        [Fact]
        public void suma_con_separadores_varios()
        {
            //Arrange
            string numbers = "1\n2,3";
            int numbersTotal = 6;

            //Act
            int result = Target.add(numbers);

            //Assert
            Assert.True(result == numbersTotal);
        }

        [Fact]
        public void suma_con_separador_default()
        {
            //Arrange
            string numbers = "//;\n1;2";
            int numbersTotal = 3;

            //Act
            int result = Target.add(numbers);

            //Assert
            Assert.True(result == numbersTotal);
        }

        [Fact]
        public void suma_sin_negativos()
        {
            //Arrange
            string numbers = "1,4,-1";

            //Act
            Exception ex = Assert.Throws<Exception>(() => Target.add(numbers));

            //Assert
            Assert.Equal("negatives not allowed: -1", ex.Message);
        }

        [Fact]
        public void suma_ignorando_numeros_grandes()
        {
            //Arrange
            string numbers = "//;\n1001;2";
            int numbersTotal = 2;

            //Act
            int result = Target.add(numbers);

            //Assert
            Assert.True(result == numbersTotal);
        }
    }
}