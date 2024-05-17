namespace UniversidadService
{
    public class Alumno
    {
        public int DNI { get; set; }
        public string Nombre { get; set; }
        public string Carrera { get; set; }
        public int AñoCursando { get; set; }
        public List<Alumno> Alumnos { get; set; }
        public List<Materia> Materias { get; set; }


        public Alumno()
        {
            Alumnos = new List<Alumno>();
            Materias = new List<Materia>();
        }
        

    }

    
}
