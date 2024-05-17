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

            Alumno alumno = Alumnos.Find(x => x.DNI == DNI); //ES COMO SI AGARRARA UN NUEVO ALUMNO.

            foreach (var Materia in alumno.Materias)
            {
                foreach (var Examen in Materia.MesasDeExamenes)
                {
                    if (Examen.NotaFinal >= 4)
                    {
                        ExamenAprobado examenaprobado = new ExamenAprobado()
                        {
                            AñoAsignado = Materia.AñoAsignado,
                            AñoCursado = Materia.AñoCursado,
                            Carrera = alumno.Carrera,
                            mesa = (ExamenAprobado.Mesa)(int)Examen.mesa,
                            NotaFinal = Examen.NotaFinal,
                            Nombre = alumno.Nombre,
                            NombreMateria = Materia.NombreMateria
                         };

                       examenesaprobados.Add(examenaprobado);
                     }
                }    
            }
            return examenesaprobados;

        }

    }

    public void MateriasNoAprobadasEnMesa(Mesa(mesa)) 
    {}

}
