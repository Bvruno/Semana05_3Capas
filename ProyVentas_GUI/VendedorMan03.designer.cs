namespace ProyVentas_GUI
{
    partial class VendedorMan03
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
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.dtpFecIng = new System.Windows.Forms.DateTimePicker();
            this.optest = new System.Windows.Forms.RadioButton();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.txtape = new System.Windows.Forms.TextBox();
            this.txtsue = new System.Windows.Forms.TextBox();
            this.optcon = new System.Windows.Forms.RadioButton();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grpDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDatos
            // 
            this.grpDatos.Controls.Add(this.btnGrabar);
            this.grpDatos.Controls.Add(this.Label1);
            this.grpDatos.Controls.Add(this.dtpFecIng);
            this.grpDatos.Controls.Add(this.optest);
            this.grpDatos.Controls.Add(this.txtnom);
            this.grpDatos.Controls.Add(this.txtape);
            this.grpDatos.Controls.Add(this.txtsue);
            this.grpDatos.Controls.Add(this.optcon);
            this.grpDatos.Controls.Add(this.Label2);
            this.grpDatos.Controls.Add(this.Label3);
            this.grpDatos.Controls.Add(this.Label4);
            this.grpDatos.Controls.Add(this.btnCancelar);
            this.grpDatos.Location = new System.Drawing.Point(10, 5);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Size = new System.Drawing.Size(328, 192);
            this.grpDatos.TabIndex = 7;
            this.grpDatos.TabStop = false;
            this.grpDatos.Text = "Datos";
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(240, 105);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(72, 24);
            this.btnGrabar.TabIndex = 4;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(8, 24);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(64, 16);
            this.Label1.TabIndex = 3;
            this.Label1.Text = "Nombre:";
            // 
            // dtpFecIng
            // 
            this.dtpFecIng.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecIng.Location = new System.Drawing.Point(80, 120);
            this.dtpFecIng.Name = "dtpFecIng";
            this.dtpFecIng.Size = new System.Drawing.Size(120, 20);
            this.dtpFecIng.TabIndex = 2;
            // 
            // optest
            // 
            this.optest.Location = new System.Drawing.Point(27, 160);
            this.optest.Name = "optest";
            this.optest.Size = new System.Drawing.Size(96, 24);
            this.optest.TabIndex = 1;
            this.optest.Text = "Estable";
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(80, 24);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(192, 20);
            this.txtnom.TabIndex = 0;
            // 
            // txtape
            // 
            this.txtape.Location = new System.Drawing.Point(80, 56);
            this.txtape.Name = "txtape";
            this.txtape.Size = new System.Drawing.Size(192, 20);
            this.txtape.TabIndex = 0;
            // 
            // txtsue
            // 
            this.txtsue.Location = new System.Drawing.Point(80, 88);
            this.txtsue.Name = "txtsue";
            this.txtsue.Size = new System.Drawing.Size(69, 20);
            this.txtsue.TabIndex = 0;
            // 
            // optcon
            // 
            this.optcon.Location = new System.Drawing.Point(138, 162);
            this.optcon.Name = "optcon";
            this.optcon.Size = new System.Drawing.Size(96, 24);
            this.optcon.TabIndex = 1;
            this.optcon.Text = "Contratado";
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(8, 56);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(64, 16);
            this.Label2.TabIndex = 3;
            this.Label2.Text = "Apellido:";
            // 
            // Label3
            // 
            this.Label3.Location = new System.Drawing.Point(8, 88);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(64, 16);
            this.Label3.TabIndex = 3;
            this.Label3.Text = "Sueldo:";
            // 
            // Label4
            // 
            this.Label4.Location = new System.Drawing.Point(8, 120);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(64, 16);
            this.Label4.TabIndex = 3;
            this.Label4.Text = "F. Ingreso:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(240, 135);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(72, 24);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // VendedorMan03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 209);
            this.Controls.Add(this.grpDatos);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "VendedorMan03";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizar Vendedor";
            this.Load += new System.EventHandler(this.VendedorMan03_Load);
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox grpDatos;
        internal System.Windows.Forms.Button btnGrabar;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.DateTimePicker dtpFecIng;
        internal System.Windows.Forms.RadioButton optest;
        internal System.Windows.Forms.TextBox txtnom;
        internal System.Windows.Forms.TextBox txtape;
        internal System.Windows.Forms.TextBox txtsue;
        internal System.Windows.Forms.RadioButton optcon;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Button btnCancelar;
    }
}