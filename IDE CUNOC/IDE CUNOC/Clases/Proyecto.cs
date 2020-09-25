using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDE_CUNOC.Clases
{
    class Proyecto
    {
        private List<ArchivoDeTexto> archivos;
        private String path;

        public Proyecto(List<ArchivoDeTexto> proyectos)
        {
            this.Proyectos = proyectos;
        }

        public string Path { get => path; set => path = value; }
        internal List<ArchivoDeTexto> Proyectos { get => archivos; set => archivos = value; }
    }
}
