using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
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

            //mostrar los productos comunes del cliente y el otro similar
            ProductosForm clientprodtextB = new ProductosForm();
            ProductosForm comunprodtextB = new ProductosForm();              
           // clientprodtextB.Text = lista1;
            //comunprodtextB.Text = lista2;


        }

        private void abrirdbtn_Click(object sender, EventArgs e)
        {
            // Displays an OpenFileDialog so the user can select a file.
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            
            // Show the Dialog.
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(openFileDialog1.FileName);
                //MessageBox.Show(sr.ReadToEnd());
                string srr = sr.ReadToEnd();
                sr.Close();
                similarestextB.Text = srr;
                ////agregar el archivo a la lista
                //similares.Add(srr);
                
            }
        }        
    }
}
