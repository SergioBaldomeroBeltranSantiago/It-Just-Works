using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImplementacionMultiHilos
{

    public partial class VentanaDos : Form
    {
        public event Delegado ValueUpdate;
        public VentanaDos()
        {
            InitializeComponent();
        }

        public void ModifyLabel(string entrada) {
            Lb_TextoAqui.Text = entrada;
        }
    }
}
