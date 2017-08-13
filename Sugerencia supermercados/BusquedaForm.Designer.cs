namespace Sugerencia_supermercados
{
    partial class BusquedaForm
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
            this.ingresarNombrelabel = new System.Windows.Forms.Label();
            this.clienteBuscartextBo = new System.Windows.Forms.TextBox();
            this.buscarbtn = new System.Windows.Forms.Button();
            this.similarestextB = new System.Windows.Forms.TextBox();
            this.verprodbtn = new System.Windows.Forms.Button();
            this.abrirdbtn = new System.Windows.Forms.Button();
            this.idclientcomboB = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ingresarNombrelabel
            // 
            this.ingresarNombrelabel.AutoSize = true;
            this.ingresarNombrelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingresarNombrelabel.Location = new System.Drawing.Point(12, 44);
            this.ingresarNombrelabel.Name = "ingresarNombrelabel";
            this.ingresarNombrelabel.Size = new System.Drawing.Size(139, 20);
            this.ingresarNombrelabel.TabIndex = 0;
            this.ingresarNombrelabel.Text = "Ingrese un cliente:";
            this.ingresarNombrelabel.Click += new System.EventHandler(this.ingresarNombrelabel_Click);
            // 
            // clienteBuscartextBo
            // 
            this.clienteBuscartextBo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clienteBuscartextBo.Location = new System.Drawing.Point(283, 107);
            this.clienteBuscartextBo.Name = "clienteBuscartextBo";
            this.clienteBuscartextBo.Size = new System.Drawing.Size(144, 24);
            this.clienteBuscartextBo.TabIndex = 1;
            // 
            // buscarbtn
            // 
            this.buscarbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarbtn.Location = new System.Drawing.Point(311, 41);
            this.buscarbtn.Name = "buscarbtn";
            this.buscarbtn.Size = new System.Drawing.Size(75, 23);
            this.buscarbtn.TabIndex = 3;
            this.buscarbtn.Text = "Buscar";
            this.buscarbtn.UseVisualStyleBackColor = true;
            this.buscarbtn.Click += new System.EventHandler(this.buscarbtn_Click);
            // 
            // similarestextB
            // 
            this.similarestextB.AcceptsTab = true;
            this.similarestextB.BackColor = System.Drawing.SystemColors.Control;
            this.similarestextB.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.similarestextB.Location = new System.Drawing.Point(24, 98);
            this.similarestextB.Multiline = true;
            this.similarestextB.Name = "similarestextB";
            this.similarestextB.ReadOnly = true;
            this.similarestextB.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.similarestextB.Size = new System.Drawing.Size(253, 265);
            this.similarestextB.TabIndex = 4;
            // 
            // verprodbtn
            // 
            this.verprodbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verprodbtn.Location = new System.Drawing.Point(311, 334);
            this.verprodbtn.Name = "verprodbtn";
            this.verprodbtn.Size = new System.Drawing.Size(106, 29);
            this.verprodbtn.TabIndex = 5;
            this.verprodbtn.Text = "Ver productos";
            this.verprodbtn.UseVisualStyleBackColor = true;
            this.verprodbtn.Click += new System.EventHandler(this.verprodbtn_Click);
            // 
            // abrirdbtn
            // 
            this.abrirdbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abrirdbtn.Location = new System.Drawing.Point(335, 193);
            this.abrirdbtn.Name = "abrirdbtn";
            this.abrirdbtn.Size = new System.Drawing.Size(82, 27);
            this.abrirdbtn.TabIndex = 6;
            this.abrirdbtn.Text = "Cargar DB";
            this.abrirdbtn.UseVisualStyleBackColor = true;
            this.abrirdbtn.Click += new System.EventHandler(this.abrirdbtn_Click);
            // 
            // idclientcomboB
            // 
            this.idclientcomboB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idclientcomboB.FormattingEnabled = true;
            this.idclientcomboB.Items.AddRange(new object[] {
            "219",
            "587",
            "921",
            "1787",
            "2285",
            "2472",
            "3176",
            "3340",
            "3467",
            "3611",
            "4535",
            "5021",
            "5394",
            "5490",
            "6483",
            "6818",
            "7863",
            "7897",
            "8192",
            "8450",
            "8558",
            "8839",
            "9438",
            "9558",
            "10934",
            "11062",
            "11088",
            "11863",
            "12686",
            "13017",
            "13137",
            "15353",
            "15537",
            "16109",
            "16702",
            "17003",
            "18298",
            "18862",
            "19774",
            "20229",
            "20436",
            "20851",
            "21559",
            "21879",
            "22173"});
            this.idclientcomboB.Location = new System.Drawing.Point(156, 44);
            this.idclientcomboB.Name = "idclientcomboB";
            this.idclientcomboB.Size = new System.Drawing.Size(121, 24);
            this.idclientcomboB.TabIndex = 7;
            // 
            // BusquedaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 391);
            this.Controls.Add(this.idclientcomboB);
            this.Controls.Add(this.abrirdbtn);
            this.Controls.Add(this.verprodbtn);
            this.Controls.Add(this.similarestextB);
            this.Controls.Add(this.buscarbtn);
            this.Controls.Add(this.clienteBuscartextBo);
            this.Controls.Add(this.ingresarNombrelabel);
            this.MaximizeBox = false;
            this.Name = "BusquedaForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busqueda de clientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ingresarNombrelabel;
        private System.Windows.Forms.TextBox clienteBuscartextBo;
        private System.Windows.Forms.Button buscarbtn;
        private System.Windows.Forms.TextBox similarestextB;
        private System.Windows.Forms.Button verprodbtn;
        private System.Windows.Forms.Button abrirdbtn;
        private System.Windows.Forms.ComboBox idclientcomboB;
    }
}

