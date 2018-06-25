using Microsoft.VisualStudio.TestTools.UnitTesting;
using PooVueling_Alumno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooVueling_Alumno.Tests
{
    [TestClass()]
    public class AlumnoTests
    {
        [TestCategory("Test Guardado")]
        [TestMethod()]
        public void AllRight()
        {
            //Arrange
            Alumno alumno = new Alumno();
            alumno.Nombre = "pepe";
            alumno.Apellidos = "Garcia Garcia";
            alumno.DNI = "44444444v";
            alumno.Id = "1";
            //Act
            bool test = alumno.Guardar();
            ////Assert
            Assert.IsTrue(test);
        }
        [TestCategory("Test Guardado")]
        [TestMethod()]
        public void idIgual()
        {
            //Arrange
            Alumno alumno = new Alumno();
            alumno.Nombre = "pepe";
            alumno.Apellidos = "Garcia Garcia";
            alumno.DNI = "44444444v";
            alumno.Id = "1";
            //Act
            bool test = alumno.Guardar();
            ////Assert
            Assert.IsTrue(test);
        }
    }
}