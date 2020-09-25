using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDE_CUNOC.Logica
{
    class Token
    {
        private int estadoDeFinalizacion;
        private String tipoDato;

        public int EstadoDeFinalizacion { get => estadoDeFinalizacion; set => estadoDeFinalizacion = value; }
    }
}
