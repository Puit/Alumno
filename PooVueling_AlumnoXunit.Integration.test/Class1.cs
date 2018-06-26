using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xunit;

//namespace AlumnoXUnitTest
namespace PooVueling_Alumno
{
    public class Class1
    {
        private Alumno alumnoTest = new Alumno();
        [Fact]
        public void PassingTest()
        {
            alumnoTest.Nombre = "Abcde";
            alumnoTest.Apellidos = "Fghi Jqlm";
            alumnoTest.DNI = "11111111v";
            alumnoTest.Id = alumnoTest.GetHashCode().ToString();
            bool result = alumnoTest.Guardar();
            Assert.True(result);

        }

        //[Fact]
        //public void FailingTest()
        //{
        //    Assert.Equal(5, Add(2, 2));
        //}
    }
}