using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AlumnoXunit.Integration.Test
{
     public class Class1
    {
        private  miAlumno = new PooVueling.Calculadora();
        [Fact]
        public void SumaTest()
        {
            var result = miCalculadora.Division(4, 2);
            Assert.Equal(2, result);
        }

        [Fact]
        public void SumaFailingTest()
        {
            var result = miCalculadora.Division(4, 2);
            Assert.Equal(5, result);
        }
    }
}
