using prueba.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTests
{
    public class PruebaDataTest
    {
        public Paciente paciente1 { get; set; }
        public Paciente paciente2 { get; set; }
        public List<Paciente> pacientes { get; set; }

        public PruebaDataTest()
        {
            CrearPacientes();
        }

        private void CrearPacientes()
        {
            pacientes = new List<Paciente>();

            paciente1 = new Paciente()

            {
                Documento = "741852963",
                Apellidos = "Martinez",
                Ciudad = "Medellin",
                Direccion = "Carrera 50 Calle 10",
                Email = "correo@prueba.co",
                Nombres = "Rosa",
                Telefono = "3101111111",
                TipoAfiliacion = EnumTipoAfiliacion.Prepagada,
                TipoDocumento = EnumTipoDocumento.Pasaporte
            };
        

            paciente1 = new Paciente()
            {
                Documento = "725941365",
                Apellidos = "Bolivar",
                Ciudad = "Caracas",
                Direccion = "Calle 50 Carrera 10",
                Email = "correo@prueba.co",
                Nombres = "Simon",
                Telefono = "3103333333",
                TipoAfiliacion = EnumTipoAfiliacion.Contributivo,
                TipoDocumento = EnumTipoDocumento.Cedula
            }; 

            pacientes.Add(paciente1);
            pacientes.Add(paciente2);
        }
    }
}
