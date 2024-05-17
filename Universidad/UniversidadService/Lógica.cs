using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversidadService
{
    public class Lógica
    {
        Alumno alumno = new Alumno();
        public List<Alumno> Alumnos { get; set; }
        public Lógica()
        {
            Alumnos = new List<Alumno>();
            examenesaprobados = new List<ExamenAprobado>();
        }

        public List<ExamenAprobado> examenesaprobados {get; set; }  

        public List<ExamenAprobado> ExamenesAprobados(int DNI)
        {

            var ExamenAlumno = Alumnos.Find(x => x.DNI == alumno.DNI);

            foreach (var Materia in ExamenAlumno.Materias)
            {
                foreach (var Examen in Materia.MesasDeExamenes)
                {
                    if (Examen.NotaFinal >= 4)
                    {
                        ExamenAprobado examenaprobado = new ExamenAprobado()
                        {
                            AñoAsignado = Examen.AñoAsignado,
                            AñoCursado = Examen.AñoCursado,
                            Carrera = Examen.Carrera,
                            mesa = Examen.mesa,
                            NotaFinal = Examen.NotaFinal,
                            Nombre = Examen.Nombre,
                            NombreMateria = Examen.NombreMateria
                         };

                       examenesaprobados.Add(examenaprobado);
                     }
                }    
            }


        }
      

    }
}
