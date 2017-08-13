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

        private void verprodbtn_Click(object sender, EventArgs e)
        {
            //mostrar sgte form de los productos en comun
            ProductosForm prodform = new ProductosForm();
            prodform.Show();
            this.Hide();

            //mostras los productos comunes del cliente y el otro similar
           
        }
    }
}
