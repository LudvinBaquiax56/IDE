using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDE_CUNOC.Logica
{
    class Automata
    {
        private int[,] tablaTransiciones = {
            //{0,  1,  2,  3,  4,  5,  6,  7,  8,  9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 ,20 ,21},
            {  1,  3,  2,  3,  4,  3,  3,  3,  5,  6,  6,  7,  3,  8,  9,  3,  3, 10, 11, 12,  3,  3},
            {  1, 16, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1},
            {  2,  2,  3,  2,  2,  2,  2,  2,  2,  2,  2,  2,  2,  2,  2,  2,  2,  2,  2,  2,  2,  2},
            { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1},
            { -1, -1, -1, -1, 13, -1, -1, 14, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1},
            { -1, -1, -1, -1, -1, -1, -1, -1,  5, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1},
            { -1, -1, -1, -1, -1, -1, -1, -1, -1,  6,  6, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1},
            { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1,  3, -1, -1, -1, -1},
            { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1,  3, -1, -1, -1, -1, -1, -1, -1, -1},
            { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1,  3, -1, -1, -1, -1, -1, -1, -1},
            { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1,  3, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1},
            { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1,  3, -1, -1, -1},
            { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1,  3, -1, -1},
            { 13, 13, 13, 13, 13, 13,  3, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13},
            { 14, 14, 14, 14, 14, 14, 14, 15, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14},
            { -1, -1, -1, -1,  3, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1},
            { 16, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1},
        };

        private int[] estadosDeAceptacion = { 1, 3, 4, 5, 6, 7, 8, 9, 10, 16 };

        public Automata()
        {
        }
        public int estadoSiguiente(int estado, char caracter)
        {
            return tablaTransiciones[estado, validarCaracter(caracter)];
        }

        public int validarCaracter(char caracter)
        {
            int valorACSSI = (int)caracter;
            //Digito
            if (48 <= valorACSSI && valorACSSI <= 57)
            {
                return 0;
            }
            //Punto
            else if (46 == valorACSSI)
            {
                return 1;
            }
            //comillas
            else if (34 == valorACSSI)
            {
                return 2;
            }
            //Diagonal
            else if (47 == valorACSSI)
            {
                return 4;
            }
            //Espacio
            else if (32 == valorACSSI)
            {
                return 5;
            }
            //Salto De Linea
            else if (10 == valorACSSI)
            {
                return 6;
            }
            //Asteristico
            else if (42 == valorACSSI)
            {
                return 7;
            }
            //Letras minusculas
            else if ((97 <= valorACSSI && valorACSSI <= 122) || 164 == valorACSSI)
            {
                return 8;
            }
            //Letras Mayusculas
            else if ((65 <= valorACSSI && valorACSSI <= 90) || 165 == valorACSSI)
            {
                return 9;
            }
            //Guion bajo
            else if (95 == valorACSSI)
            {
                return 10;
            }
            //Igual
            else if (61 == valorACSSI)
            {
                return 11;
            }
            //Punto y coma
            else if (59 == valorACSSI)
            {
                return 12;
            }
            //Signo mas +
            else if (43 == valorACSSI)
            {
                return 13;
            }
            //signo menos -
            else if (45 == valorACSSI)
            {
                return 14;
            }
            //mayor que >
            else if (62 == valorACSSI)
            {
                return 15;
            }
            //menor que <
            else if (60 == valorACSSI)
            {
                return 16;
            }
            //Signo de admiraccion cierre !
            else if (33 == valorACSSI)
            {
                return 17;
            }
            //Signo de o |
            else if (124 == valorACSSI)
            {
                return 18;
            }
            //Signo de y &
            else if (38 == valorACSSI)
            {
                return 19;
            }
            //Abrir parentesis (
            else if (40 == valorACSSI)
            {
                return 20;
            }
            //Cerrar parentesis )
            else if (41 == valorACSSI)
            {
                return 21;
            }
            //Calquier tipo de CHAR
            else
            {
                return 3;
            }

        }

        public Boolean validarEstadoDeAceptacion(int estadoValidar)
        {
            for (int i = 0; i < estadosDeAceptacion.Length; i++)
            {
                if (estadosDeAceptacion[i] == estadoValidar)
                {
                    return true;
                }
            }
            return false;
        }
    }
}