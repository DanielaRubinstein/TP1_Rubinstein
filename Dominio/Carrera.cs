using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Carrera
    {
        public int ID { get; set; }
        public string Descripcion { get; set; }
        public TipoCarrera Tipo { get; set; }
        public int Anios { get; set; }
        public List<Comision> Comision { get; set; }
        public List<Materia> Mat { get; set; }

    }
}
