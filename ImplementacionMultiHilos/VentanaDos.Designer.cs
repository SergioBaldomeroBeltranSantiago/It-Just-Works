
namespace ImplementacionMultiHilos
{
    partial class VentanaDos
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
            this.Lb_TextoAqui = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lb_TextoAqui
            // 
            this.Lb_TextoAqui.AutoSize = true;
            this.Lb_TextoAqui.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_TextoAqui.Location = new System.Drawing.Point(47, 74);
            this.Lb_TextoAqui.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lb_TextoAqui.Name = "Lb_TextoAqui";
            this.Lb_TextoAqui.Size = new System.Drawing.Size(115, 25);
            this.Lb_TextoAqui.TabIndex = 0;
            this.Lb_TextoAqui.Text = "Inserte Texto";
            // 
            // VentanaDos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 224);
            this.Controls.Add(this.Lb_TextoAqui);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "VentanaDos";
            this.Text = "Ventana Copia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lb_TextoAqui;
    }
}