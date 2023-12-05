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
            Assert.Equal("Pedro Estepa", result);

        }
    }
}
