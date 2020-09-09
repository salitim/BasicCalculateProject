using BasicCalculateProject;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;


namespace CalculateProject.tests
{
    public class CalculationTest
    {
        [Fact]
        public void AdditionReturnFour()
        {
            ////Arrange
            Calculate calculation = new Calculate();

            //ACT
            double number = calculation.Addition(2, 2);

            //ASSERT
            Assert.Equal(4, number);
        }

        [Fact]
        public void MultiplicationReturnFour()
        {
            ////Arrange
            Calculate calculation = new Calculate();

            //ACT
            double number = calculation.Multiplication(2, 2);

            //ASSERT

            Assert.Equal(4, number);
        }

        [Theory]
        [InlineData(2, 2, 1)]
        [InlineData(2, 0, 0)]
        [InlineData(0, 2, 0)]
        public void DivisionReturnGoodValue(double numberOne,double numberTwo, double expected)
        {
            ////Arrange
            Calculate calculation = new Calculate();

            //ACT
            double number = calculation.Divison(numberOne, numberTwo);

            //ASSERT
            Assert.Equal(expected, number);
        }

        [Fact]
        public void ModuloReturnZero()
        {
            ////Arrange
            Calculate calculation = new Calculate();

            //ACT
            double number = calculation.Modulo(2, 2);

            //ASSERT
            //ASSERT
            Assert.Equal(0, number);


        }

        [Fact]
        public void SubstrationReturnZero()
        {
            //Arrange
            Calculate calculation = new Calculate();

            //ACT
            double number = calculation.Substraction(2, 2);

            //ASSERT
            //ASSERT
            Assert.Equal(0, number);


        }
    }
}
