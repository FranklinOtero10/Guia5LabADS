using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ADSProject.Models
{
    public class Grupo
    {
        public int id { get; set; }
        public String Nombre { get; set; }
        public int idCarrera { get; set; }
        public int idMateria { get; set; }
        public int idProfesor { get; set; }
        public int Ciclo { get; set; }
        public int Anio { get; set; }
    }
}