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
            this.categoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disciplinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.participantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuInicio.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuInicio
            // 
            this.menuInicio.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoriaToolStripMenuItem,
            this.disciplinaToolStripMenuItem,
            this.participantesToolStripMenuItem,
            this.salir});
            this.menuInicio.Location = new System.Drawing.Point(0, 0);
            this.menuInicio.Name = "menuInicio";
            this.menuInicio.Size = new System.Drawing.Size(461, 24);
            this.menuInicio.TabIndex = 0;
            this.menuInicio.Text = "menuStrip1";
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.categoriaToolStripMenuItem.Text = "Categorias";
            // 
            // disciplinaToolStripMenuItem
            // 
            this.disciplinaToolStripMenuItem.Name = "disciplinaToolStripMenuItem";
            this.disciplinaToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.disciplinaToolStripMenuItem.Text = "Disciplinas";
            // 
            // participantesToolStripMenuItem
            // 
            this.participantesToolStripMenuItem.Name = "participantesToolStripMenuItem";
            this.participantesToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.participantesToolStripMenuItem.Text = "Participantes";
            // 
            // salir
            // 
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(41, 20);
            this.salir.Text = "Salir";
            this.salir.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 386);
            this.Controls.Add(this.menuInicio);
            this.MainMenuStrip = this.menuInicio;
            this.Name = "FrmPrincipal";
            this.Text = "FrmPrincipal";
            this.menuInicio.ResumeLayout(false);
            this.menuInicio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuInicio;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disciplinaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem participantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salir;
    }
}