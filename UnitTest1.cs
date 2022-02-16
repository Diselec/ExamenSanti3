
using Xunit;
using System.Collections.Generic;

namespace Parejas
{

    public class SistemaTest
    {

        [Theory]
        [MemberData(nameof(Data))]
        public void DescendendiaTest(Persona a, Persona b, bool esperado)
        {
            // Given
            var sis = new Sistema();
            // When
            var result = sis.Descendendia(a,b);
            // Then
            Assert.Equal(result, esperado);
        }

        
        public static IEnumerable<object[]> Data =>
        new List<object[]>
        {       
            new object[] { new Persona("A", 20, 'M') , new Persona("B", 29, 'F'), true},
            new object[] { new Persona("A", 19, 'M') , new Persona("B", 38, 'M'), false},
            new object[] { new Persona("A", 21, 'M') , new Persona("B", 38, 'F'), false},
            new object[] { new Persona("A", 21, 'M') , new Persona("B", 39, 'M'), false},
     
        };
        
    }
    
}