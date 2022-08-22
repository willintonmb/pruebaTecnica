using NUnit.Framework;
using prueba.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTests.Models
{
    public class PacienteTests
    {
        public Paciente paciente { get; set; }
        public PruebaDataTest pruebaDataTest { get; set; }

        [SetUp]
        public void Setup()
        {
            pruebaDataTest = new PruebaDataTest();
        }

        [Test]
        public void CrearPaciente_InDatos_OutPaciente()
        {
            //Arrange

            var documento = pruebaDataTest.paciente1.Documento;
            var nombres = pruebaDataTest.paciente1.Nombres;
            var apellidos = pruebaDataTest.paciente1.Apellidos;
            var dirección = pruebaDataTest.paciente1.Direccion;
            var ciudad = pruebaDataTest.paciente1.Ciudad;
            var email = pruebaDataTest.paciente1.Email;
            var telefono = pruebaDataTest.paciente1.Telefono;
            EnumTipoAfiliacion tipoAfiliacion = EnumTipoAfiliacion.Subsidiado;
            EnumTipoDocumento tipoDocumento = EnumTipoDocumento.Cedula;


            //Act 
            var paciente = new Paciente(documento, 
                                        nombres, 
                                        apellidos, 
                                        dirección,
                                        telefono,
                                        ciudad, 
                                        email, 
                                        tipoDocumento, 
                                        tipoAfiliacion
                                        );

            //Assert
            Assert.IsNotNull(paciente);
            Assert.AreEqual(documento, paciente.Documento);
            Assert.AreEqual(nombres, paciente.Nombres);
            Assert.AreEqual(apellidos, paciente.Apellidos);
            Assert.AreEqual(dirección, paciente.Direccion);
            Assert.AreEqual(ciudad, paciente.Ciudad);
            Assert.AreEqual(telefono, paciente.Telefono);
            Assert.AreEqual(email, paciente.Email);
        }
    }
}
