namespace Vistas
{
    partial class FrmLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.btnIngresar_Click = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(250, 110);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(100, 22);
            this.txtNombreUsuario.TabIndex = 2;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(250, 194);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(100, 22);
            this.txtContraseña.TabIndex = 3;
            // 
            // btnIngresar_Click
            // 
            this.btnIngresar_Click.Location = new System.Drawing.Point(250, 259);
            this.btnIngresar_Click.Name = "btnIngresar_Click";
            this.btnIngresar_Click.Size = new System.Drawing.Size(98, 34);
            this.btnIngresar_Click.TabIndex = 4;
            this.btnIngresar_Click.Text = "Ingresar";
            this.btnIngresar_Click.UseVisualStyleBackColor = true;
            this.btnIngresar_Click.Click += new System.EventHandler(this.btnIngresar_Click_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 368);
            this.Controls.Add(this.btnIngresar_Click);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtNombreUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmLogin";
            this.Text = "FrmLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Button btnIngresar_Click;
    }
}