namespace ProyVentas_GUI
{
    partial class frmConsFarturasCliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.dtpFecIni = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFecFin = new System.Windows.Forms.DateTimePicker();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.dtgFacturas = new System.Windows.Forms.DataGridView();
            this.num_fac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fec_fac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fec_can = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_cli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.raz_soc_cli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione Cliente";
            // 
            // cboCliente
            // 
            this.cboCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(162, 12);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(121, 21);
            this.cboCliente.TabIndex = 1;
            // 
            // dtpFecIni
            // 
            this.dtpFecIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecIni.Location = new System.Drawing.Point(197, 45);
            this.dtpFecIni.Name = "dtpFecIni";
            this.dtpFecIni.Size = new System.Drawing.Size(86, 20);
            this.dtpFecIni.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha Inicio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(310, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fecha Fin";
            // 
            // dtpFecFin
            // 
            this.dtpFecFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecFin.Location = new System.Drawing.Point(370, 44);
            this.dtpFecFin.Name = "dtpFecFin";
            this.dtpFecFin.Size = new System.Drawing.Size(95, 20);
            this.dtpFecFin.TabIndex = 4;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(575, 42);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 6;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // dtgFacturas
            // 
            this.dtgFacturas.AllowUserToAddRows = false;
            this.dtgFacturas.AllowUserToDeleteRows = false;
            this.dtgFacturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgFacturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.num_fac,
            this.fec_fac,
            this.fec_can,
            this.Total,
            this.Estado,
            this.cod_cli,
            this.raz_soc_cli});
            this.dtgFacturas.Location = new System.Drawing.Point(12, 83);
            this.dtgFacturas.Name = "dtgFacturas";
            this.dtgFacturas.ReadOnly = true;
            this.dtgFacturas.RowHeadersVisible = false;
            this.dtgFacturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgFacturas.Size = new System.Drawing.Size(650, 166);
            this.dtgFacturas.TabIndex = 7;
            // 
            // num_fac
            // 
            this.num_fac.DataPropertyName = "num_fac";
            this.num_fac.HeaderText = "Nr. Factura";
            this.num_fac.Name = "num_fac";
            this.num_fac.ReadOnly = true;
            // 
            // fec_fac
            // 
            this.fec_fac.DataPropertyName = "fec_fac";
            this.fec_fac.HeaderText = "Fecha Facturacion";
            this.fec_fac.Name = "fec_fac";
            this.fec_fac.ReadOnly = true;
            // 
            // fec_can
            // 
            this.fec_can.DataPropertyName = "fec_can";
            this.fec_can.HeaderText = "Fecha Cancelacion";
            this.fec_can.Name = "fec_can";
            this.fec_can.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Total";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.Total.DefaultCellStyle = dataGridViewCellStyle2;
            this.Total.HeaderText = "Total (S./)";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // cod_cli
            // 
            this.cod_cli.DataPropertyName = "cod_cli";
            this.cod_cli.HeaderText = "Codigo del Cliente";
            this.cod_cli.Name = "cod_cli";
            this.cod_cli.ReadOnly = true;
            this.cod_cli.Visible = false;
            // 
            // raz_soc_cli
            // 
            this.raz_soc_cli.DataPropertyName = "raz_soc_cli";
            this.raz_soc_cli.HeaderText = "Razon Social";
            this.raz_soc_cli.Name = "raz_soc_cli";
            this.raz_soc_cli.ReadOnly = true;
            this.raz_soc_cli.Visible = false;
            // 
            // frmConsFarturasCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 261);
            this.Controls.Add(this.dtgFacturas);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpFecFin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpFecIni);
            this.Controls.Add(this.cboCliente);
            this.Controls.Add(this.label1);
            this.Name = "frmConsFarturasCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Facturas por cliente";
            this.Load += new System.EventHandler(this.frmConsFarturasCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgFacturas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboCliente;
        private System.Windows.Forms.DateTimePicker dtpFecIni;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFecFin;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DataGridView dtgFacturas;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_fac;
        private System.Windows.Forms.DataGridViewTextBoxColumn fec_fac;
        private System.Windows.Forms.DataGridViewTextBoxColumn fec_can;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_cli;
        private System.Windows.Forms.DataGridViewTextBoxColumn raz_soc_cli;
    }
}