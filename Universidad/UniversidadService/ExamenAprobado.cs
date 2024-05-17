using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversidadService
{
    public class ExamenAprobado
    {
        public string Nombre { get; set; }
        public string Carrera { get; set; }
        public string NombreMateria { get; set; }
        public int AñoAsignado { get; set; }
        public int AñoCursado { get; set; }
        public enum Mesa { marzo = 1, mayo = 2, septiembre = 3 }
        public Mesa mesa { get; set; }
        public double NotaFinal { get; set; }

        public void 
        
    }
}
