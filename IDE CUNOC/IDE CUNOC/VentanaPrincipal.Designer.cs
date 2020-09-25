using System.Windows.Forms;

namespace IDE_CUNOC
{
    partial class EditorDeTexto
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarProyectoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proyectoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearProyectoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.layout = new System.Windows.Forms.TableLayoutPanel();
            this.RtxtCodigo = new System.Windows.Forms.RichTextBox();
            this.LblFilaColumna = new System.Windows.Forms.Label();
            this.btnCompilar = new System.Windows.Forms.Button();
            this.RtxtErrores = new System.Windows.Forms.RichTextBox();
            this.OPArchivos = new System.Windows.Forms.OpenFileDialog();
            this.SFGuardar = new System.Windows.Forms.SaveFileDialog();
            this.FBDBuscarCarpeta = new System.Windows.Forms.FolderBrowserDialog();
            this.menuStrip1.SuspendLayout();
            this.layout.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.proyectoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.cerrarToolStripMenuItem,
            this.cerrarProyectoToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            this.archivoToolStripMenuItem.Click += new System.EventHandler(this.archivoToolStripMenuItem_Click);
            // 
            // crearToolStripMenuItem
            // 
            this.crearToolStripMenuItem.Name = "crearToolStripMenuItem";
            this.crearToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.crearToolStripMenuItem.Text = "Guardar";
            this.crearToolStripMenuItem.Click += new System.EventHandler(this.crearToolStripMenuItem_Click);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirFuncion);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.eliminarToolStripMenuItem.Text = "Crear";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.crearFuncion);
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.cerrarToolStripMenuItem.Text = "Eliminar";
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            // 
            // cerrarProyectoToolStripMenuItem
            // 
            this.cerrarProyectoToolStripMenuItem.Name = "cerrarProyectoToolStripMenuItem";
            this.cerrarProyectoToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.cerrarProyectoToolStripMenuItem.Text = "Cerrar Proyecto";
            // 
            // proyectoToolStripMenuItem
            // 
            this.proyectoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearProyectoToolStripMenuItem});
            this.proyectoToolStripMenuItem.Name = "proyectoToolStripMenuItem";
            this.proyectoToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.proyectoToolStripMenuItem.Text = "Proyecto";
            // 
            // crearProyectoToolStripMenuItem
            // 
            this.crearProyectoToolStripMenuItem.Name = "crearProyectoToolStripMenuItem";
            this.crearProyectoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.crearProyectoToolStripMenuItem.Text = "Crear Proyecto";
            this.crearProyectoToolStripMenuItem.Click += new System.EventHandler(this.crearProyectoToolStripMenuItem_Click);
            // 
            // layout
            // 
            this.layout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.layout.ColumnCount = 2;
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layout.Controls.Add(this.RtxtCodigo, 0, 0);
            this.layout.Controls.Add(this.LblFilaColumna, 0, 1);
            this.layout.Controls.Add(this.btnCompilar, 1, 1);
            this.layout.Controls.Add(this.RtxtErrores, 0, 2);
            this.layout.Location = new System.Drawing.Point(12, 27);
            this.layout.Name = "layout";
            this.layout.RowCount = 3;
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.layout.Size = new System.Drawing.Size(776, 462);
            this.layout.TabIndex = 1;
            // 
            // RtxtCodigo
            // 
            this.layout.SetColumnSpan(this.RtxtCodigo, 2);
            this.RtxtCodigo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RtxtCodigo.Location = new System.Drawing.Point(3, 3);
            this.RtxtCodigo.Name = "RtxtCodigo";
            this.RtxtCodigo.Size = new System.Drawing.Size(770, 355);
            this.RtxtCodigo.TabIndex = 0;
            this.RtxtCodigo.Text = "";
            this.RtxtCodigo.TextChanged += new System.EventHandler(this.RtxtCodigo_TextChanged);
            // 
            // lblFilaColumna
            // 
            this.LblFilaColumna.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblFilaColumna.AutoSize = true;
            this.LblFilaColumna.Location = new System.Drawing.Point(3, 361);
            this.LblFilaColumna.Name = "lblFilaColumna";
            this.LblFilaColumna.Size = new System.Drawing.Size(382, 30);
            this.LblFilaColumna.TabIndex = 1;
            this.LblFilaColumna.Text = "Fila: 0, Columa: 0";
            // 
            // btnCompilar
            // 
            this.btnCompilar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCompilar.Location = new System.Drawing.Point(391, 364);
            this.btnCompilar.Name = "btnCompilar";
            this.btnCompilar.Size = new System.Drawing.Size(382, 24);
            this.btnCompilar.TabIndex = 2;
            this.btnCompilar.Text = "Compilar";
            this.btnCompilar.UseVisualStyleBackColor = true;
            // 
            // RtxtErrores
            // 
            this.layout.SetColumnSpan(this.RtxtErrores, 2);
            this.RtxtErrores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RtxtErrores.Enabled = false;
            this.RtxtErrores.Location = new System.Drawing.Point(3, 394);
            this.RtxtErrores.Name = "RtxtErrores";
            this.RtxtErrores.Size = new System.Drawing.Size(770, 70);
            this.RtxtErrores.TabIndex = 3;
            this.RtxtErrores.Text = "";
            // 
            // OPArchivos
            // 
            this.OPArchivos.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 501);
            this.Controls.Add(this.layout);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IDE CUNOC";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.layout.ResumeLayout(false);
            this.layout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarProyectoToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel layout;
        private System.Windows.Forms.RichTextBox RtxtCodigo;
        private System.Windows.Forms.Label lblFilaColumna;
        private System.Windows.Forms.Button btnCompilar;
        private System.Windows.Forms.RichTextBox RtxtErrores;
        private System.Windows.Forms.OpenFileDialog OPArchivos;
        private System.Windows.Forms.SaveFileDialog SFGuardar;
        private System.Windows.Forms.ToolStripMenuItem proyectoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearProyectoToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog FBDBuscarCarpeta;

        public RichTextBox RtxtCodigo1 { get => RtxtCodigo; set => RtxtCodigo = value; }
        public Label LblFilaColumna { get => lblFilaColumna; set => lblFilaColumna = value; }
    }
}

