using Moq;
using NUnit.Framework;
using prueba.WebApi.Controllers;
using prueba.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTests.Controllers
{
    public class PacientesControllerTests
    {
        public PacientesController pacientesController { get; set; }
        public EntityModel dbEntity {get; set;}
        public PruebaDataTest pruebaDataTest { get; set; }
        public Mock<DbSet> dbSet { get; set; }

        [SetUp]
        public void Setup()
        {
            pacientesController = new PacientesController();
            pruebaDataTest = new PruebaDataTest();
            dbEntity = new EntityModel();
            dbSet = new Mock<DbSet>();

            var queryable = pruebaDataTest.pacientes.AsQueryable();

            dbSet.As<IQueryable<Paciente>>().Setup(m => m.Provider).Returns(queryable.Provider);
            dbSet.As<IQueryable<Paciente>>().Setup(m => m.Expression).Returns(queryable.Expression);
            dbSet.As<IQueryable<Paciente>>().Setup(m => m.ElementType).Returns(queryable.ElementType);
            dbSet.As<IQueryable<Paciente>>().Setup(m => m.GetEnumerator()).Returns(() => queryable.GetEnumerator());

        }

        [Test]
        public void Put_InData_OutPacientes()
        {
            //Arrange
            var pacientes = pruebaDataTest.pacientes;
            var paciente = pruebaDataTest.paciente1;

            dbSet.Setup(x => x.Add(paciente)).Returns(paciente);

            //Act
            var result = pacientesController.PostPaciente(paciente);

            //Assert
            Assert.IsNotNull(result);

        }
    }
}
