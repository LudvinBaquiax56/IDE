using IDE_CUNOC.Clases;
using IDE_CUNOC.Logica;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDE_CUNOC
{
    public partial class EditorDeTexto : Form
    {
        private ArchivoDeTexto archivoP;
        private Proyecto proyecto;
        private AnalizadorLexico analizador;
        public EditorDeTexto()
        {
            InitializeComponent();
            analizador = new AnalizadorLexico(this);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void crearFuncion(object sender, EventArgs e)
        {

        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void abrirFuncion(object sender, EventArgs e)
        {
            String ruta;

            //OPArchivos.InitialDirectory = "c:\\";
            OPArchivos.Filter = "Text files (*.gt)|*.gt";
            OPArchivos.FilterIndex = 2;
            OPArchivos.RestoreDirectory = true;
            OPArchivos.ShowDialog();
            System.IO.StreamReader archivo = new System.IO.StreamReader(OPArchivos.FileName);
            ruta = archivo.ReadLine();
            this.archivoP = new ArchivoDeTexto(archivo.ReadLine());
            this.archivoP.Path = "hola";
            RtxtCodigo.Text = ruta.ToString();

        }

        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SFGuardar.FileName = "Nombre";

        }

        private void crearProyectoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FBDBuscarCarpeta.RootFolder = Environment.SpecialFolder.Desktop;
            String NombreProyecto = Interaction.InputBox("Ingrese nombre del Proyecto", "Nombre del Proyceto:", "").Trim();
            if (NombreProyecto != "")
            {
                FBDBuscarCarpeta.Description = "Seleccione donde desea Guardar el Proyecto";
                FBDBuscarCarpeta.ShowNewFolderButton = true;
                if (FBDBuscarCarpeta.ShowDialog() == DialogResult.OK)
                {
                    if (!Directory.Exists(FBDBuscarCarpeta.SelectedPath + "\\" + NombreProyecto))
                    {
                        Directory.CreateDirectory(FBDBuscarCarpeta.SelectedPath + "\\" + NombreProyecto);
                    }
                }
            }
        }

        private void RtxtCodigo_TextChanged(object sender, EventArgs e)
        {

            Point pos = new Point(0, 0);
            int firstIndex = RtxtCodigo.GetCharIndexFromPosition(pos);
            int firstLine = RtxtCodigo.GetLineFromCharIndex(firstIndex);

            //now we get index of last visible char 
            //and number of last visible line
            pos.X = ClientRectangle.Width;
            pos.Y = ClientRectangle.Height;

            int lastIndex = RtxtCodigo.GetCharIndexFromPosition(pos);
            int lastLine = RtxtCodigo.GetLineFromCharIndex(lastIndex);


            //this is point position of last visible char, we'll 
            //use its Y value for calculating numberLabel size
            pos = RtxtCodigo.GetPositionFromCharIndex(lastIndex);

            //finally, renumber label
            LblFilaColumna.Text = "Fila: " + pos + ", Columa: 0";
            analizador.analizar();

        }
    }
}
