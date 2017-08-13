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
            this.clienteBuscartextBo.Location = new System.Drawing.Point(157, 40);
            this.clienteBuscartextBo.Name = "clienteBuscartextBo";
            this.clienteBuscartextBo.Size = new System.Drawing.Size(144, 24);
            this.clienteBuscartextBo.TabIndex = 1;
            // 
            // buscarbtn
            // 
            this.buscarbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarbtn.Location = new System.Drawing.Point(342, 41);
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
            this.similarestextB.Location = new System.Drawing.Point(24, 98);
            this.similarestextB.Multiline = true;
            this.similarestextB.Name = "similarestextB";
            this.similarestextB.ReadOnly = true;
            this.similarestextB.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.similarestextB.Size = new System.Drawing.Size(253, 265);
            this.similarestextB.TabIndex = 4;
            // 
            // BusquedaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 424);
            this.Controls.Add(this.similarestextB);
            this.Controls.Add(this.buscarbtn);
            this.Controls.Add(this.clienteBuscartextBo);
            this.Controls.Add(this.ingresarNombrelabel);
            this.Name = "BusquedaForm";
            this.Text = "Busqueda de clientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ingresarNombrelabel;
        private System.Windows.Forms.TextBox clienteBuscartextBo;
        private System.Windows.Forms.Button buscarbtn;
        private System.Windows.Forms.TextBox similarestextB;
    }
}

