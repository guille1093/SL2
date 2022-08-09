namespace nettest
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtBPatente = new System.Windows.Forms.TextBox();
            this.txtBMarca = new System.Windows.Forms.TextBox();
            this.txtBModelo = new System.Windows.Forms.TextBox();
            this.lblPatente = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.DgvAutos = new System.Windows.Forms.DataGridView();
            this.btAgregar = new System.Windows.Forms.Button();
            this.btEliminar = new System.Windows.Forms.Button();
            this.LbAnio = new System.Windows.Forms.Label();
            this.txtBAnio = new System.Windows.Forms.TextBox();
            this.btnModeloPruebas = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.GpBoxElementosDeBusqueda = new System.Windows.Forms.GroupBox();
            this.RBAnio = new System.Windows.Forms.RadioButton();
            this.RBModelo = new System.Windows.Forms.RadioButton();
            this.RBMarca = new System.Windows.Forms.RadioButton();
            this.RBPatente = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAutos)).BeginInit();
            this.GpBoxElementosDeBusqueda.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBPatente
            // 
            this.txtBPatente.Location = new System.Drawing.Point(110, 6);
            this.txtBPatente.Name = "txtBPatente";
            this.txtBPatente.Size = new System.Drawing.Size(80, 20);
            this.txtBPatente.TabIndex = 2;
            // 
            // txtBMarca
            // 
            this.txtBMarca.Location = new System.Drawing.Point(110, 32);
            this.txtBMarca.Name = "txtBMarca";
            this.txtBMarca.Size = new System.Drawing.Size(80, 20);
            this.txtBMarca.TabIndex = 3;
            // 
            // txtBModelo
            // 
            this.txtBModelo.Location = new System.Drawing.Point(110, 58);
            this.txtBModelo.Name = "txtBModelo";
            this.txtBModelo.Size = new System.Drawing.Size(80, 20);
            this.txtBModelo.TabIndex = 4;
            // 
            // lblPatente
            // 
            this.lblPatente.AutoSize = true;
            this.lblPatente.Location = new System.Drawing.Point(12, 9);
            this.lblPatente.Name = "lblPatente";
            this.lblPatente.Size = new System.Drawing.Size(92, 13);
            this.lblPatente.TabIndex = 5;
            this.lblPatente.Text = "Ingrese la patente";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(12, 35);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(85, 13);
            this.lblMarca.TabIndex = 6;
            this.lblMarca.Text = "Ingrese la marca";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(12, 61);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(90, 13);
            this.lblModelo.TabIndex = 7;
            this.lblModelo.Text = "Ingrese el modelo";
            // 
            // DgvAutos
            // 
            this.DgvAutos.AllowUserToAddRows = false;
            this.DgvAutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvAutos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvAutos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DgvAutos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvAutos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvAutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvAutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAutos.Location = new System.Drawing.Point(202, 9);
            this.DgvAutos.MultiSelect = false;
            this.DgvAutos.Name = "DgvAutos";
            this.DgvAutos.RowHeadersVisible = false;
            this.DgvAutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvAutos.Size = new System.Drawing.Size(500, 322);
            this.DgvAutos.TabIndex = 8;
            this.DgvAutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvAutos_CellClick);
            // 
            // btAgregar
            // 
            this.btAgregar.Location = new System.Drawing.Point(9, 251);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(86, 23);
            this.btAgregar.TabIndex = 9;
            this.btAgregar.Text = "Agregar";
            this.btAgregar.UseVisualStyleBackColor = true;
            this.btAgregar.Click += new System.EventHandler(this.BtAgregarClick);
            // 
            // btEliminar
            // 
            this.btEliminar.Location = new System.Drawing.Point(108, 251);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(80, 23);
            this.btEliminar.TabIndex = 10;
            this.btEliminar.Text = "Eliminar";
            this.btEliminar.UseVisualStyleBackColor = true;
            this.btEliminar.Click += new System.EventHandler(this.BtEliminar_Click);
            // 
            // LbAnio
            // 
            this.LbAnio.AutoSize = true;
            this.LbAnio.Location = new System.Drawing.Point(12, 87);
            this.LbAnio.Name = "LbAnio";
            this.LbAnio.Size = new System.Drawing.Size(74, 13);
            this.LbAnio.TabIndex = 12;
            this.LbAnio.Text = "Ingrese el año";
            // 
            // txtBAnio
            // 
            this.txtBAnio.Location = new System.Drawing.Point(110, 84);
            this.txtBAnio.Name = "txtBAnio";
            this.txtBAnio.Size = new System.Drawing.Size(80, 20);
            this.txtBAnio.TabIndex = 11;
            // 
            // btnModeloPruebas
            // 
            this.btnModeloPruebas.Location = new System.Drawing.Point(10, 309);
            this.btnModeloPruebas.Name = "btnModeloPruebas";
            this.btnModeloPruebas.Size = new System.Drawing.Size(179, 23);
            this.btnModeloPruebas.TabIndex = 13;
            this.btnModeloPruebas.Text = "Cargar modelo de pruebas";
            this.btnModeloPruebas.UseVisualStyleBackColor = true;
            this.btnModeloPruebas.Click += new System.EventHandler(this.BtnModeloPruebas_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Location = new System.Drawing.Point(10, 280);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(179, 23);
            this.BtnLimpiar.TabIndex = 14;
            this.BtnLimpiar.Text = "Limpiar Seleccion";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(103, 86);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(80, 23);
            this.BtnBuscar.TabIndex = 16;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // GpBoxElementosDeBusqueda
            // 
            this.GpBoxElementosDeBusqueda.Controls.Add(this.RBAnio);
            this.GpBoxElementosDeBusqueda.Controls.Add(this.RBModelo);
            this.GpBoxElementosDeBusqueda.Controls.Add(this.RBMarca);
            this.GpBoxElementosDeBusqueda.Controls.Add(this.RBPatente);
            this.GpBoxElementosDeBusqueda.Controls.Add(this.BtnBuscar);
            this.GpBoxElementosDeBusqueda.Location = new System.Drawing.Point(5, 130);
            this.GpBoxElementosDeBusqueda.Name = "GpBoxElementosDeBusqueda";
            this.GpBoxElementosDeBusqueda.Size = new System.Drawing.Size(191, 115);
            this.GpBoxElementosDeBusqueda.TabIndex = 17;
            this.GpBoxElementosDeBusqueda.TabStop = false;
            this.GpBoxElementosDeBusqueda.Text = "Seleccione el campo a buscar";
            // 
            // RBAnio
            // 
            this.RBAnio.AutoSize = true;
            this.RBAnio.Location = new System.Drawing.Point(7, 89);
            this.RBAnio.Name = "RBAnio";
            this.RBAnio.Size = new System.Drawing.Size(44, 17);
            this.RBAnio.TabIndex = 20;
            this.RBAnio.TabStop = true;
            this.RBAnio.Text = "Año";
            this.RBAnio.UseVisualStyleBackColor = true;
            // 
            // RBModelo
            // 
            this.RBModelo.AutoSize = true;
            this.RBModelo.Location = new System.Drawing.Point(7, 66);
            this.RBModelo.Name = "RBModelo";
            this.RBModelo.Size = new System.Drawing.Size(60, 17);
            this.RBModelo.TabIndex = 19;
            this.RBModelo.TabStop = true;
            this.RBModelo.Text = "Modelo";
            this.RBModelo.UseVisualStyleBackColor = true;
            // 
            // RBMarca
            // 
            this.RBMarca.AutoSize = true;
            this.RBMarca.Location = new System.Drawing.Point(7, 43);
            this.RBMarca.Name = "RBMarca";
            this.RBMarca.Size = new System.Drawing.Size(55, 17);
            this.RBMarca.TabIndex = 18;
            this.RBMarca.TabStop = true;
            this.RBMarca.Text = "Marca";
            this.RBMarca.UseVisualStyleBackColor = true;
            // 
            // RBPatente
            // 
            this.RBPatente.AutoSize = true;
            this.RBPatente.Checked = true;
            this.RBPatente.Location = new System.Drawing.Point(7, 20);
            this.RBPatente.Name = "RBPatente";
            this.RBPatente.Size = new System.Drawing.Size(62, 17);
            this.RBPatente.TabIndex = 17;
            this.RBPatente.TabStop = true;
            this.RBPatente.Text = "Patente";
            this.RBPatente.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 343);
            this.Controls.Add(this.GpBoxElementosDeBusqueda);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.btnModeloPruebas);
            this.Controls.Add(this.LbAnio);
            this.Controls.Add(this.txtBAnio);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.btAgregar);
            this.Controls.Add(this.DgvAutos);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblPatente);
            this.Controls.Add(this.txtBModelo);
            this.Controls.Add(this.txtBMarca);
            this.Controls.Add(this.txtBPatente);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Final Libre SL2";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvAutos)).EndInit();
            this.GpBoxElementosDeBusqueda.ResumeLayout(false);
            this.GpBoxElementosDeBusqueda.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBPatente;
        private System.Windows.Forms.TextBox txtBMarca;
        private System.Windows.Forms.TextBox txtBModelo;
        private System.Windows.Forms.Label lblPatente;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.DataGridView DgvAutos;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Label LbAnio;
        private System.Windows.Forms.TextBox txtBAnio;
        private System.Windows.Forms.Button btnModeloPruebas;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.GroupBox GpBoxElementosDeBusqueda;
        private System.Windows.Forms.RadioButton RBMarca;
        private System.Windows.Forms.RadioButton RBPatente;
        private System.Windows.Forms.RadioButton RBModelo;
        private System.Windows.Forms.RadioButton RBAnio;
    }
}

