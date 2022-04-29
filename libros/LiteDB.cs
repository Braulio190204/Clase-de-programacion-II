using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libros
{
    public class prestar_libros
    {
        public DateTime fecha { get; set; }
        public int matricula { get; set; }
        public string nombre_completo { get; set; }
        public string curso { get; set; }
        public string autor { get; set; }
        public string titulo { get; set; }
        public string categoria{ get; set; }
        public string Estado { get; set; }
        public string tipo_estudiante { get; set; }
        public string uso_interno { get; set; }
        public string uso_interno_prestamo { get; set; }
        public int  id { get; set; }
    }
  

    class LiteDB
    {



    }




}
