using System;

namespace IDE_CUNOC.Clases
{
    class ArchivoDeTexto
    {
        private String path;

        public ArchivoDeTexto(string path)
        {
            this.Path = path;
        }

        public string Path { get => path; set => path = value; }
    }
}
