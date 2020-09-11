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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String ruta;
            //OPArchivos.InitialDirectory = "c:\\";
            OPArchivos.Filter = "Text files (*.gt)|*.gt";
            OPArchivos.FilterIndex = 2;
            OPArchivos.RestoreDirectory = true;
            OPArchivos.ShowDialog();
            System.IO.StreamReader archivo = new System.IO.StreamReader(OPArchivos.FileName);
            ruta = archivo.ReadLine();
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
    }
}
