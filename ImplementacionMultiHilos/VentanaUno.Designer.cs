
namespace ImplementacionMultiHilos
{
    partial class VentanaUno
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
            this.lb_texto = new System.Windows.Forms.Label();
            this.Btn_AbrirForm = new System.Windows.Forms.Button();
            this.Prb_BarritaCarga = new System.Windows.Forms.ProgressBar();
            this.Btn_PasarTexto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_texto
            // 
            this.lb_texto.AutoSize = true;
            this.lb_texto.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_texto.Location = new System.Drawing.Point(77, 38);
            this.lb_texto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_texto.Name = "lb_texto";
            this.lb_texto.Size = new System.Drawing.Size(56, 23);
            this.lb_texto.TabIndex = 0;
            this.lb_texto.Text = "Ajolote";
            // 
            // Btn_AbrirForm
            // 
            this.Btn_AbrirForm.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_AbrirForm.Location = new System.Drawing.Point(13, 109);
            this.Btn_AbrirForm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_AbrirForm.Name = "Btn_AbrirForm";
            this.Btn_AbrirForm.Size = new System.Drawing.Size(192, 46);
            this.Btn_AbrirForm.TabIndex = 1;
            this.Btn_AbrirForm.Text = "Cargar ventana";
            this.Btn_AbrirForm.UseVisualStyleBackColor = true;
            this.Btn_AbrirForm.Click += new System.EventHandler(this.Btn_AbrirForm_Click);
            // 
            // Prb_BarritaCarga
            // 
            this.Prb_BarritaCarga.Location = new System.Drawing.Point(13, 258);
            this.Prb_BarritaCarga.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Prb_BarritaCarga.Name = "Prb_BarritaCarga";
            this.Prb_BarritaCarga.Size = new System.Drawing.Size(192, 35);
            this.Prb_BarritaCarga.TabIndex = 3;
            // 
            // Btn_PasarTexto
            // 
            this.Btn_PasarTexto.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_PasarTexto.Location = new System.Drawing.Point(13, 178);
            this.Btn_PasarTexto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_PasarTexto.Name = "Btn_PasarTexto";
            this.Btn_PasarTexto.Size = new System.Drawing.Size(192, 46);
            this.Btn_PasarTexto.TabIndex = 4;
            this.Btn_PasarTexto.Text = "Pasar Texto";
            this.Btn_PasarTexto.UseVisualStyleBackColor = true;
            this.Btn_PasarTexto.Click += new System.EventHandler(this.Btn_PasarTexto_Click);
            // 
            // VentanaUno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 317);
            this.Controls.Add(this.Btn_PasarTexto);
            this.Controls.Add(this.Prb_BarritaCarga);
            this.Controls.Add(this.Btn_AbrirForm);
            this.Controls.Add(this.lb_texto);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "VentanaUno";
            this.Text = "Ventana Original";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_texto;
        private System.Windows.Forms.Button Btn_AbrirForm;
        private System.Windows.Forms.ProgressBar Prb_BarritaCarga;
        private System.Windows.Forms.Button Btn_PasarTexto;
    }
}

