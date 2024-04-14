using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace app.intranet_netcore.Models
{
    [Table("alumno", Schema = "intranet")]
    public class Alumno
    {
        public int IdAlumno { get; set; }
        public string ApePatAlumno { get; set; }
        public string ApeMatAlumno { get; set; }
        public string NomAlumno { get; set; }
        public string DNI { get; set; }
        public string CodigoAlu { get; set; }
        public string TelAlumno { get; set; }
        public char Sexo { get; set; }
        public string EmailAlumno { get; set; }
        public string DirAlumno { get; set; }
        public string Tipo { get; set; }
        public string Carrera { get; set; }
    }
}
