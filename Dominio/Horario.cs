using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Horario
    {
        public int ID { get; set; }
        public List<Turno> turno { get; set; }
        public List<Cuatrimestre> cuatri { get; set; }
        public int Aula { get; set; }
    }
}
