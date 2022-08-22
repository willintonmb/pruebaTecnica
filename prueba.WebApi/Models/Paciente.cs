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
        public string Documento { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Ciudad { get; set; }
        public string Email { get; set; }
        public EnumTipoDocumento TipoDocumento { private get; set; }
        public EnumTipoAfiliacion TipoAfiliacion { private get; set; }

    }
}