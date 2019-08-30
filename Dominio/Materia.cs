using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Materia
    {
        public int ID { get; set; }
        public string Descripcion { get; set; }
        public List <Catedra> catedra { get; set; }
        public  List <Horario> horario { get; set; }
        public  List <Docente> docente { get; set; }
        public  List <Ayudante> ayudante { get; set; }
    }
}
