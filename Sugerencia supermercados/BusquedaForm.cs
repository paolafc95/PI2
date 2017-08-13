using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sugerencia_supermercados
{
    public partial class BusquedaForm : Form
    {
        public BusquedaForm()
        {
            InitializeComponent();
        }

        private void ingresarNombrelabel_Click(object sender, EventArgs e)
        {

        }

        private void buscarbtn_Click(object sender, EventArgs e)
        {
            similarestextB.Text = ("clientes similares");
        }
    }
}
