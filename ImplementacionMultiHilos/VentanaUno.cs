using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ImplementacionMultiHilos
{
    public partial class VentanaUno : Form
    {
        VentanaDos experimento = new VentanaDos();
        Thread Progreso;

        public VentanaUno()
        {
            InitializeComponent();
        }

        public void BarraProgresoAvance() {
            Invoke(new MethodInvoker(() => { experimento.Hide(); }));
            Invoke(new MethodInvoker(() => { Prb_BarritaCarga.Value = 0; }));
            for (int i = 0; i < 1000; i++) {
                if (Prb_BarritaCarga.Value == Prb_BarritaCarga.Maximum)
                {
                    Invoke(new MethodInvoker(() => { experimento.Show(); }));
                    break;
                }
                else {
                    Invoke(new MethodInvoker(()=> { Prb_BarritaCarga.Value += 1; }));
                    Thread.Sleep(100);
                }
            }
        }

        private void Btn_AbrirForm_Click(object sender, EventArgs e)
        {
            Progreso = new Thread(BarraProgresoAvance);
            Progreso.Start();
        }

        private void Btn_PasarTexto_Click(object sender, EventArgs e)
        {
            experimento.ModifyLabel(lb_texto.Text);
        }
    }
}
