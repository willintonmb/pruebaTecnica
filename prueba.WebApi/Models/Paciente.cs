using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace prueba.WebApi.Models
{
    public class Paciente
    {
        /// <summary>
        /// Representa un paciente
        /// </summary>
        public Guid id { get; set; }
        public string Documento { get; private set; }
        public string Nombres { get; private set; }
        public string Apellidos { get; private set; }
        public string Direccion { get; private set; }
        public string Telefono { get; private set; }
        public string Ciudad { get; private set; }
        public string Email { get; private set; }
        public EnumTipoDocumento TipoDocumento { private get; set; }
        public EnumTipoAfiliacion TipoAfiliacion { private get; set; }

        public Paciente(string documento, 
                        string nombres, 
                        string apellidos, 
                        string direccion, 
                        string telefono, 
                        string ciudad, 
                        string email, 
                        EnumTipoDocumento tipoDocumento, 
                        EnumTipoAfiliacion tipoAfiliacion)
        {
            id = Guid.NewGuid();
            Documento = documento;
            Nombres = nombres;
            Apellidos = apellidos;
            Direccion = direccion;
            Telefono = telefono;
            Ciudad = ciudad;
            Email = email;
            TipoDocumento = tipoDocumento;
            TipoAfiliacion = tipoAfiliacion;
        }
    }
}