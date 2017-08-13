namespace Sugerencia_supermercados
{
    partial class ProductosForm
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
            this.clientprodtextB = new System.Windows.Forms.TextBox();
            this.comunprodtextB = new System.Windows.Forms.TextBox();
            this.clientprodlabel = new System.Windows.Forms.Label();
            this.prodcomunlabel = new System.Windows.Forms.Label();
            this.atrasbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clientprodtextB
            // 
            this.clientprodtextB.AcceptsTab = true;
            this.clientprodtextB.BackColor = System.Drawing.SystemColors.Control;
            this.clientprodtextB.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientprodtextB.Location = new System.Drawing.Point(12, 68);
            this.clientprodtextB.Multiline = true;
            this.clientprodtextB.Name = "clientprodtextB";
            this.clientprodtextB.ReadOnly = true;
            this.clientprodtextB.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.clientprodtextB.Size = new System.Drawing.Size(191, 271);
            this.clientprodtextB.TabIndex = 5;
            // 
            // comunprodtextB
            // 
            this.comunprodtextB.AcceptsTab = true;
            this.comunprodtextB.BackColor = System.Drawing.SystemColors.Control;
            this.comunprodtextB.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comunprodtextB.Location = new System.Drawing.Point(231, 68);
            this.comunprodtextB.Multiline = true;
            this.comunprodtextB.Name = "comunprodtextB";
            this.comunprodtextB.ReadOnly = true;
            this.comunprodtextB.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.comunprodtextB.Size = new System.Drawing.Size(191, 271);
            this.comunprodtextB.TabIndex = 6;
            this.comunprodtextB.TextChanged += new System.EventHandler(this.comunprodtextB_TextChanged);
            // 
            // clientprodlabel
            // 
            this.clientprodlabel.AutoSize = true;
            this.clientprodlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientprodlabel.Location = new System.Drawing.Point(8, 26);
            this.clientprodlabel.Name = "clientprodlabel";
            this.clientprodlabel.Size = new System.Drawing.Size(160, 20);
            this.clientprodlabel.TabIndex = 7;
            this.clientprodlabel.Text = "Productos del cliente:";
            // 
            // prodcomunlabel
            // 
            this.prodcomunlabel.AutoSize = true;
            this.prodcomunlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodcomunlabel.Location = new System.Drawing.Point(227, 26);
            this.prodcomunlabel.Name = "prodcomunlabel";
            this.prodcomunlabel.Size = new System.Drawing.Size(205, 20);
            this.prodcomunlabel.TabIndex = 8;
            this.prodcomunlabel.Text = "Productos cliente en común";
            this.prodcomunlabel.Click += new System.EventHandler(this.prodcomunlabel_Click);
            // 
            // atrasbtn
            // 
            this.atrasbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atrasbtn.Location = new System.Drawing.Point(145, 356);
            this.atrasbtn.Name = "atrasbtn";
            this.atrasbtn.Size = new System.Drawing.Size(126, 23);
            this.atrasbtn.TabIndex = 9;
            this.atrasbtn.Text = "Buscar otro cliente";
            this.atrasbtn.UseVisualStyleBackColor = true;
            this.atrasbtn.Click += new System.EventHandler(this.atrasbtn_Click);
            // 
            // ProductosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 391);
            this.Controls.Add(this.atrasbtn);
            this.Controls.Add(this.prodcomunlabel);
            this.Controls.Add(this.clientprodlabel);
            this.Controls.Add(this.comunprodtextB);
            this.Controls.Add(this.clientprodtextB);
            this.MaximizeBox = false;
            this.Name = "ProductosForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos comunes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox clientprodtextB;
        private System.Windows.Forms.TextBox comunprodtextB;
        private System.Windows.Forms.Label clientprodlabel;
        private System.Windows.Forms.Label prodcomunlabel;
        private System.Windows.Forms.Button atrasbtn;
    }
}