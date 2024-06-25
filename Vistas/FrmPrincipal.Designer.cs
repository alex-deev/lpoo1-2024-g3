﻿namespace Vistas
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
            this.inscripcionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.configInscripcionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.inscripcionToolStripMenuItem,
            this.configInscripcionToolStripMenuItem,
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
            this.itemCompetencias.Click += new System.EventHandler(this.competenciaToolStripMenuItem_Click);
            // 
            // inscripcionToolStripMenuItem
            // 
            this.inscripcionToolStripMenuItem.Name = "inscripcionToolStripMenuItem";
            this.inscripcionToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.inscripcionToolStripMenuItem.Text = "Inscripcion";
            this.inscripcionToolStripMenuItem.Click += new System.EventHandler(this.inscripcionToolStripMenuItem_Click);
            // 
            // itemSalir
            // 
            this.itemSalir.Name = "itemSalir";
            this.itemSalir.Size = new System.Drawing.Size(41, 20);
            this.itemSalir.Text = "Salir";
            this.itemSalir.Click += new System.EventHandler(this.itemSalir_Click);
            // 
            // configInscripcionToolStripMenuItem
            // 
            this.configInscripcionToolStripMenuItem.Name = "configInscripcionToolStripMenuItem";
            this.configInscripcionToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.configInscripcionToolStripMenuItem.Text = "Config Inscripcion";
            this.configInscripcionToolStripMenuItem.Click += new System.EventHandler(this.configInscripcionToolStripMenuItem_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 404);
            this.Controls.Add(this.menuInicio);
            this.MainMenuStrip = this.menuInicio;
            this.Name = "FrmPrincipal";
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
        private System.Windows.Forms.ToolStripMenuItem inscripcionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configInscripcionToolStripMenuItem;
    }
}