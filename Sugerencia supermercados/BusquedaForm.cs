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
            this.abrirdbtn.Click += new System.EventHandler(this.abrirdbtn_Click);
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

        private void abrirdbtn_Click(object sender, EventArgs e)
        {
            // Displays an OpenFileDialog so the user can select a Cursor.
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Cursor Files|*.cur";
            openFileDialog1.Filter = "Archivo|*.txt";
            openFileDialog1.Title = "Select a Data Base";

            // Show the Dialog.
            // If the user clicked OK in the dialog and a .CUR file was selected, open it.
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // Assign the cursor in the Stream to the Form's Cursor property.
                this.Cursor = new Cursor(openFileDialog1.OpenFile());
            }
            /*
            //abrir un archivo existente
            if (OpenFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.StreamReader sr = new
                System.IO.StreamReader(OpenFileDialog.FileName);
                MessageBox.Show(sr.ReadToEnd());
                sr.Close();
            }*/

        }

        
    }
}
