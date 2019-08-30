using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Inscripciones
    {
        public int ID { get; set; }
        public List<TipoInscripcion> tipoInscripcion { get; set; }
        public Materia mat { get; set; }
        public DateTime fecha { get; set; }
        public int Nota { get; set; }
    }
}
