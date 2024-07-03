namespace Vistas
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuInicio = new System.Windows.Forms.MenuStrip();
            this.itemCategorias = new System.Windows.Forms.ToolStripMenuItem();
            this.itemDiciplinas = new System.Windows.Forms.ToolStripMenuItem();
            this.itemParticipantes = new System.Windows.Forms.ToolStripMenuItem();
            this.itemUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.itemCompetencias = new System.Windows.Forms.ToolStripMenuItem();
            this.itemInscripcion = new System.Windows.Forms.ToolStripMenuItem();
            this.itemInscripcionSubitemNueva = new System.Windows.Forms.ToolStripMenuItem();
            this.itemInscripcionSubitemConfigurar = new System.Windows.Forms.ToolStripMenuItem();
            this.itemResultados = new System.Windows.Forms.ToolStripMenuItem();
            this.itemCronometrajes = new System.Windows.Forms.ToolStripMenuItem();
            this.itemSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuInicio.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuInicio
            // 
            this.menuInicio.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemCategorias,
            this.itemDiciplinas,
            this.itemParticipantes,
            this.itemUsuarios,
            this.itemCompetencias,
            this.itemInscripcion,
            this.itemCronometrajes,
            this.itemResultados,
            this.itemSalir});
            this.menuInicio.Location = new System.Drawing.Point(0, 0);
            this.menuInicio.Name = "menuInicio";
            this.menuInicio.Size = new System.Drawing.Size(735, 24);
            this.menuInicio.TabIndex = 0;
            this.menuInicio.Text = "menuStrip1";
            // 
            // itemCategorias
            // 
            this.itemCategorias.Name = "itemCategorias";
            this.itemCategorias.Size = new System.Drawing.Size(75, 20);
            this.itemCategorias.Text = "Categorias";
            this.itemCategorias.Click += new System.EventHandler(this.itemCategorias_Click);
            // 
            // itemDiciplinas
            // 
            this.itemDiciplinas.Name = "itemDiciplinas";
            this.itemDiciplinas.Size = new System.Drawing.Size(75, 20);
            this.itemDiciplinas.Text = "Disciplinas";
            this.itemDiciplinas.Click += new System.EventHandler(this.itemDiciplinas_Click);
            // 
            // itemParticipantes
            // 
            this.itemParticipantes.Name = "itemParticipantes";
            this.itemParticipantes.Size = new System.Drawing.Size(87, 20);
            this.itemParticipantes.Text = "Participantes";
            this.itemParticipantes.Click += new System.EventHandler(this.itemParticipantes_Click);
            // 
            // itemUsuarios
            // 
            this.itemUsuarios.Name = "itemUsuarios";
            this.itemUsuarios.Size = new System.Drawing.Size(64, 20);
            this.itemUsuarios.Text = "Usuarios";
            this.itemUsuarios.Click += new System.EventHandler(this.itemUsuarios_Click);
            // 
            // itemCompetencias
            // 
            this.itemCompetencias.Name = "itemCompetencias";
            this.itemCompetencias.Size = new System.Drawing.Size(95, 20);
            this.itemCompetencias.Text = "Competencias";
            this.itemCompetencias.Click += new System.EventHandler(this.itemCompetencia_Click);
            // 
            // itemInscripcion
            // 
            this.itemInscripcion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemInscripcionSubitemNueva,
            this.itemInscripcionSubitemConfigurar});
            this.itemInscripcion.Name = "itemInscripcion";
            this.itemInscripcion.Size = new System.Drawing.Size(77, 20);
            this.itemInscripcion.Text = "Inscripcion";
            // 
            // itemInscripcionSubitemNueva
            // 
            this.itemInscripcionSubitemNueva.Name = "itemInscripcionSubitemNueva";
            this.itemInscripcionSubitemNueva.Size = new System.Drawing.Size(192, 22);
            this.itemInscripcionSubitemNueva.Text = "Nueva Inscripción";
            this.itemInscripcionSubitemNueva.Click += new System.EventHandler(this.itemInscripcionSubitemNueva_Click);
            // 
            // itemInscripcionSubitemConfigurar
            // 
            this.itemInscripcionSubitemConfigurar.Name = "itemInscripcionSubitemConfigurar";
            this.itemInscripcionSubitemConfigurar.Size = new System.Drawing.Size(192, 22);
            this.itemInscripcionSubitemConfigurar.Text = "Configurar Inscripción";
            this.itemInscripcionSubitemConfigurar.Click += new System.EventHandler(this.itemInscripcionSubitemConfigurar_Click);
            // 
            // itemResultados
            // 
            this.itemResultados.Name = "itemResultados";
            this.itemResultados.Size = new System.Drawing.Size(76, 20);
            this.itemResultados.Text = "Resultados";
            this.itemResultados.Click += new System.EventHandler(this.itemResultados_Click);
            // 
            // itemCronometrajes
            // 
            this.itemCronometrajes.Name = "itemCronometrajes";
            this.itemCronometrajes.Size = new System.Drawing.Size(97, 20);
            this.itemCronometrajes.Text = "Cronometrajes";
            this.itemCronometrajes.Click += new System.EventHandler(this.cronometrajesToolStripMenuItem_Click);
            // 
            // itemSalir
            // 
            this.itemSalir.Name = "itemSalir";
            this.itemSalir.Size = new System.Drawing.Size(41, 20);
            this.itemSalir.Text = "Salir";
            this.itemSalir.Click += new System.EventHandler(this.itemSalir_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 404);
            this.Controls.Add(this.menuInicio);
            this.MainMenuStrip = this.menuInicio;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPrincipal";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuInicio.ResumeLayout(false);
            this.menuInicio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuInicio;
        private System.Windows.Forms.ToolStripMenuItem itemCategorias;
        private System.Windows.Forms.ToolStripMenuItem itemDiciplinas;
        private System.Windows.Forms.ToolStripMenuItem itemParticipantes;
        private System.Windows.Forms.ToolStripMenuItem itemSalir;
        private System.Windows.Forms.ToolStripMenuItem itemUsuarios;
        private System.Windows.Forms.ToolStripMenuItem itemCompetencias;
        private System.Windows.Forms.ToolStripMenuItem itemInscripcion;
        private System.Windows.Forms.ToolStripMenuItem itemResultados;
        private System.Windows.Forms.ToolStripMenuItem itemInscripcionSubitemConfigurar;
        private System.Windows.Forms.ToolStripMenuItem itemCronometrajes;
        private System.Windows.Forms.ToolStripMenuItem itemInscripcionSubitemNueva;
    }
}