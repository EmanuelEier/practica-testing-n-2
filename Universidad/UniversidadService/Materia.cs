using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversidadService
{
    public class Materia
    {
        public string NombreMateria { get; set; }
        public int AñoAsignado {  get; set; }
        public int AñoCursado { get; set; }
        public List<MesaDeExamen> MesasDeExamenes { get; set; }


        public Materia() { 
        MesasDeExamenes = new List<MesaDeExamen>();
        }


       /* public List Materia(string Carrera, int AñoAsignado, int AñoCursado)
        {
            switch (Carrera)
            {
                case "Abogacia":
                    List<Materia> MateriasCursadas = new List<Materia> { "Lengua" };
                    break;
            }
        }*/
    }
}
