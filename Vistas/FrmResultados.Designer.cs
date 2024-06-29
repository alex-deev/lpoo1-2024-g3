namespace Vistas
{
    partial class FrmResultados
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
            this.lblCompetencia = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.gridResultados = new System.Windows.Forms.DataGridView();
            this.numIdCompetencia = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.gridResultados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIdCompetencia)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCompetencia
            // 
            this.lblCompetencia.AutoSize = true;
            this.lblCompetencia.Location = new System.Drawing.Point(111, 45);
            this.lblCompetencia.Name = "lblCompetencia";
            this.lblCompetencia.Size = new System.Drawing.Size(206, 17);
            this.lblCompetencia.TabIndex = 0;
            this.lblCompetencia.Text = "Ingrese el ID de la competencia";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(585, 44);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // gridResultados
            // 
            this.gridResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridResultados.Location = new System.Drawing.Point(114, 114);
            this.gridResultados.Name = "gridResultados";
            this.gridResultados.RowTemplate.Height = 24;
            this.gridResultados.Size = new System.Drawing.Size(637, 304);
            this.gridResultados.TabIndex = 3;
            // 
            // numIdCompetencia
            // 
            this.numIdCompetencia.Location = new System.Drawing.Point(363, 45);
            this.numIdCompetencia.Name = "numIdCompetencia";
            this.numIdCompetencia.Size = new System.Drawing.Size(120, 22);
            this.numIdCompetencia.TabIndex = 4;
            // 
            // FrmResultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 561);
            this.Controls.Add(this.numIdCompetencia);
            this.Controls.Add(this.gridResultados);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblCompetencia);
            this.Name = "FrmResultados";
            this.Text = "FrmResultados";
            ((System.ComponentModel.ISupportInitialize)(this.gridResultados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIdCompetencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCompetencia;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView gridResultados;
        private System.Windows.Forms.NumericUpDown numIdCompetencia;
    }
}