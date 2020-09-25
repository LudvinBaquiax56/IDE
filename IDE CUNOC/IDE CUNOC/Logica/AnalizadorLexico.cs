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
        String ruta = "";
        String cadena = "";

        public EditorDeTexto Editor { get => editor; set => editor = value; }
        public int EstadoActual { get => estadoActual; set => estadoActual = value; }
        internal Automata Automata { get => automata; set => automata = value; }
        public char[] Texto { get => texto; set => texto = value; }

        public AnalizadorLexico(EditorDeTexto editor)
        {
            this.Texto = editor.RtxtCodigo1.Text.ToCharArray();
            this.editor = editor;
            this.estadoActual = 0;
            this.automata = new Automata();
        }

        public void analizar()
        {
            this.Texto = editor.RtxtCodigo1.Text.ToCharArray();
            this.estadoActual = 0;
            ruta = "";
            cadena = "";

            for (int i = 0; i < Texto.Length; i++)
            {
                char caracterActual = (char)texto[i];

                if (estadoActual != -1)
                {
                    if (estadoActual == 2 && automata.estadoSiguiente(estadoActual, caracterActual) == 3)
                    {
                        ruta = ruta + "3";
                    }
                    //Estado B numeros enteros 
                    else if (estadoActual == 1)
                    {
                        if ((automata.estadoSiguiente(estadoActual, caracterActual) != 1 || i == texto.Length)
                             && automata.estadoSiguiente(estadoActual, caracterActual) != 16)
                        {
                            asignarColor(i + 1, Color.Purple, cadena.Length + 1);
                            restablecerValores();
                        }
                    }
                    //Comentarios
                    else if (estadoActual == 4)
                    {
                        if (cadena.Length == 1 && !(automata.estadoSiguiente(estadoActual, caracterActual) != 14
                           || automata.estadoSiguiente(estadoActual, caracterActual) != 13))
                        {
                            asignarColor(i + 1, Color.Blue, cadena.Length);
                            restablecerValores();
                        }
                    }
                    //Estado F palabras reservadas minusculas
                    else if (estadoActual == 5)
                    {
                        if (automata.estadoSiguiente(estadoActual, caracterActual) != 5 || i == texto.Length)
                        {
                            if (cadena.Equals("entero") || cadena.Equals("decimal")
                                || cadena.Equals("cadena") || cadena.Equals("booleano")
                                || cadena.Equals("caracter") || cadena.Equals("carácter"))
                            {
                                cadena = cadena + caracterActual;
                                i++;
                                asignarColor(i + 1, Color.Green, cadena.Length + 1);
                                restablecerValores();
                            }
                            else if (cadena.Equals("verdadero") || cadena.Equals("falso"))
                            {
                                asignarColor(i + 1, Color.DarkOrange, cadena.Length + 1);
                                restablecerValores();
                            }
                        }
                    }
                    //Estado Q numeros decimales
                    else if (estadoActual == 16)
                    {
                        if (automata.estadoSiguiente(estadoActual, caracterActual) != 16 || i == texto.Length)
                        {
                            asignarColor(i + 1, Color.SkyBlue, cadena.Length + 1);
                            restablecerValores();
                        }
                    }
                    //Estado G Palabras reservadas
                    else if (estadoActual == 6)
                    {
                        if (automata.estadoSiguiente(estadoActual, caracterActual) != 6 || i == texto.Length)
                        {
                            if (cadena.Equals("SI") || cadena.Equals("SINO")
                                || cadena.Equals("SINO_SI") || cadena.Equals("MIENTRAS")
                                || cadena.Equals("HACER") || cadena.Equals("DESDE")
                                || cadena.Equals("HASTA") || cadena.Equals("INCREMENTO"))
                            {
                                asignarColor(i + 1, Color.Green, cadena.Length + 1);
                                restablecerValores();
                            }
                        }
                    }
                    //Estado k signo != COMBINADOS
                    else if (estadoActual == 10)
                    {
                        if (automata.estadoSiguiente(estadoActual, caracterActual) == 3 || i == texto.Length)
                        {
                            cadena = cadena + caracterActual;
                            i++;
                            asignarColor(i + 1, Color.Blue, cadena.Length);
                            restablecerValores();
                        }
                        else
                        {
                            asignarColor(i + 1, Color.Blue, cadena.Length);
                            restablecerValores();
                        }

                    }
                    cadena = cadena + caracterActual;
                    estadoActual = automata.estadoSiguiente(estadoActual, caracterActual);
                    editor.LblFilaColumna.Text = estadoActual.ToString();
                    if (estadoActual == 2)
                    {
                        ruta = ruta + "2";
                    }
                }
                else
                {
                    asignarColor(i + 1, Color.Black, cadena.Length);
                    restablecerValores();
                    i--;
                }
                if (automata.validarEstadoDeAceptacion(estadoActual))
                {
                    //Estado D
                    if (estadoActual == 3)
                    {
                        if (cadena.Length == 1 && ruta.Equals(""))
                        {
                            //Fin de Se4ntencia
                            if (cadena.Equals(";"))
                            {
                                asignarColor(i + 1, Color.HotPink, cadena.Length);
                            }
                            //Algunos Operadores
                            else if (cadena.Equals("*") || cadena.Equals("<")
                                || cadena.Equals(">") || cadena.Equals("(") ||
                                cadena.Equals(")"))
                            {
                                asignarColor(i + 1, Color.Blue, cadena.Length);
                            }
                            //Caracteres
                            else
                            {
                                asignarColor(i + 1, Color.Chocolate, cadena.Length);
                            }
                            restablecerValores();
                        }
                        //Cadenas de texto
                        else if (ruta.Contains("23"))
                        {
                            asignarColor(i + 1, Color.Gray, cadena.Length);
                            restablecerValores();
                        }
                        //Resto de operadores
                        else if (cadena.Length == 2)
                        {
                            asignarColor(i + 1, Color.Blue, cadena.Length);
                            restablecerValores();
                        }
                        else
                        {
                            asignarColor(i + 1, Color.Red, cadena.Length);
                            restablecerValores();
                        }
                    }
                    //Comentarios
                    else if (estadoActual == 4)
                    {
                        asignarColor(i + 1, Color.Blue, cadena.Length);
                    }
                    //Estado H signo igual 
                    else if (estadoActual == 7)
                    {
                        asignarColor(i + 1, Color.HotPink, cadena.Length);
                        restablecerValores();
                    }
                    //Estado I signo +
                    else if (estadoActual == 8)
                    {
                        asignarColor(i + 1, Color.Blue, cadena.Length);
                        restablecerValores();
                    }
                    //Estado J signo -
                    else if (estadoActual == 9)
                    {
                        asignarColor(i + 1, Color.Blue, cadena.Length);
                        restablecerValores();
                    }
                    //Estado k signo !
                    else if (estadoActual == 10)
                    {
                        asignarColor(i + 1, Color.Blue, cadena.Length);
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

        public void restablecerValores()
        {
            estadoActual = 0;
            cadena = "";
            ruta = "";
        }
    }
}
