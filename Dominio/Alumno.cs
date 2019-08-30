using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Alumno : Persona
    {
        public DateTime FechaNac { get; set; }
        public List<Inscripciones> Inscrip {get;set;}
    }
}
