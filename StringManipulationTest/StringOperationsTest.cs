using StringManipulation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulationTest
{
    public class StringOperationsTest
    {
        [Fact]
        public void ConcatenateStrings()
        {
            //Arrange
            var strOperations = new StringOperations();
            //Act
            var result = strOperations.ConcatenateStrings("Pedro", "Estepa");

            //Assert
            Assert.NotNull(result);
            Assert.NotEmpty(result);
            Assert.Equal("Pedro Estepa", result);

        }

        /// <summary>
        /// Este metodo es una prueba unitario de polindromos con respuesta positiva
        /// </summary>

        [Fact]
        public void IsPalindrome()
        {
            //Arrange
            var strOperations = new StringOperations();

            //Act
            var result = strOperations.IsPalindrome("ama");

            //Assert            

            Assert.True(result);
        }

        /// <summary>
        /// Este metodo es una prueba unitario de polindromos con respuesta negativa
        /// </summary>
        /// 
        [Fact(Skip = "saltar este metodo de prueba al incluir Skip dentro del Fact")]
        public void IsPalindromeFalse()
        {
            //Arrange
            var strOperations = new StringOperations();

            //Act
            var result = strOperations.IsPalindrome("Pedro");

            //Assert            

            Assert.False(result);
        }

        /// <summary>
        /// Este metodo es una prueba unitario comprueba la remocion de espacios en blanco
        /// </summary>
        /// 
        [Fact]
        public void RemoveWhitespace()
        {
            //Arrange
            var strOperations = new StringOperations();

            //Act
            var result = strOperations.RemoveWhitespace("Pedro Eduardo Estepa Julio");

            //Assert            

            Assert.NotNull(result);
            Assert.NotEmpty(result);
            Assert.Equal("PedroEduardoEstepaJulio", result);
        }

        [Fact]
        public void GetStringLength_Exeption()
        {
            //Arrange
            var strOperations = new StringOperations();

            //Act
            //var result = strOperations.RemoveWhitespace("Pedro Eduardo Estepa Julio");

            //Assert            

            Assert.ThrowsAny<ArgumentException>(() => strOperations.GetStringLength(null));
        }

        /// <summary>
        /// Esta es una prueba unitaria que recibe parametros y luego compara su resultado es igual
        /// </summary>
        /// <param name="romanNumber"></param>
        /// <param name="decimalNumber"></param>
        [Theory]
        [InlineData("V", 5)]
        public void FromRomanToNumber(string romanNumber, int decimalNumber)
        {
            var strOperations = new StringOperations();

            var result = strOperations.FromRomanToNumber(romanNumber);
            Assert.Equal(decimalNumber, result);
        }

    }
}


