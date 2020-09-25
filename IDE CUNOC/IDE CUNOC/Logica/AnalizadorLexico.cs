using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDE_CUNOC.Logica
{
    class AnalizadorLexico
    {
        private char[] texto;
        private EditorDeTexto editor;
        private int estadoActual;
        private Automata automata;


        public EditorDeTexto Editor { get => editor; set => editor = value; }
        public int EstadoActual { get => estadoActual; set => estadoActual = value; }
        internal Automata Automata { get => automata; set => automata = value; }
        public char[] Texto { get => texto; set => texto = value; }

        public AnalizadorLexico(EditorDeTexto editor)
        {
            this.Texto = editor.Text.ToCharArray();
            this.editor = editor;
            this.estadoActual = 0;
            this.automata = new Automata();
        }

        public void analizar()
        {

            for (int i = 0; i < Texto.Length; i++)
            {
                editor.LblFilaColumna.Text = estadoActual.ToString();
                char caracterActual = (char)texto[i];
                String cadena = "";
               
                if (estadoActual != -1 )
                {
                    cadena = cadena + caracterActual;
                    estadoActual = automata.estadoSiguiente(estadoActual, caracterActual);

                }
                else if (automata.validarEstadoDeAceptacion(estadoActual))
                {
                    if (estadoActual == 3 && cadena.Length == 1)
                    {
                        if (cadena.Equals(";") || cadena.Equals("="))
                        {
                            asignarColor(i, Color.Pink, cadena.Length);
                        }
                        else if (cadena.Equals("*") || cadena.Equals("<")
                            || cadena.Equals(">") || cadena.Equals("(") ||
                            cadena.Equals(")"))
                        {
                            asignarColor(i, Color.Blue, cadena.Length);
                        }
                        else
                        {
                            asignarColor(i, Color.Brown, cadena.Length);
                        }
                    }
                }

            }
        }
        public void asignarColor(int indiceFin, Color colorTexto, int tamanio)
        {
            int index = editor.RtxtCodigo1.SelectionStart;

            editor.RtxtCodigo1.Select((indiceFin - tamanio), tamanio);
            editor.RtxtCodigo1.SelectionColor = colorTexto;

            editor.RtxtCodigo1.SelectionStart = index;
            editor.RtxtCodigo1.SelectionLength = 0;

        }
    }
}
