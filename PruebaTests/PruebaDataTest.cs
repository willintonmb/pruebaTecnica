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

            paciente1 = new Paciente("987654321",
                                    "Fulanito",
                                    "DeTal",
                                    "Calle 50 Carrera 50",
                                    "3108888888",
                                    "Tunja",
                                    "prueba@pruebas.co",
                                    EnumTipoDocumento.Cedula,
                                    EnumTipoAfiliacion.Particular
                                    );

            paciente1 = new Paciente("741852963",
                                    "Rosa",
                                    "Martinez",
                                    "Carrera 50 Calle 10",
                                    "3101111111",
                                    "Medellin",
                                    "correo@prueba.co",
                                    EnumTipoDocumento.Pasaporte,
                                    EnumTipoAfiliacion.Prepagada
                                    );

            pacientes.Add(paciente1);
            pacientes.Add(paciente2);
        }
    }
}
