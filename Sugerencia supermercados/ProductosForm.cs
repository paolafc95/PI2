using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Paola Fuentes Caro, agosto 2017

namespace Sugerencia_supermercados
{
    public partial class ProductosForm : Form
    {
        public ProductosForm()
        {
            InitializeComponent();
        }

        private void comunprodtextB_TextChanged(object sender, EventArgs e)
        {

        }

        private void prodcomunlabel_Click(object sender, EventArgs e)
        {

        }

        private void atrasbtn_Click(object sender, EventArgs e)
        {
            //volver a buscar un cliente, cerrar la actual
            BusquedaForm buscarform = new BusquedaForm();
            buscarform.Show();
            this.Close();
        }

        private void clientprodtextB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
