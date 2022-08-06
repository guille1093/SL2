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
            this.txtBPatente = new System.Windows.Forms.TextBox();
            this.txtBMarca = new System.Windows.Forms.TextBox();
            this.txtBModelo = new System.Windows.Forms.TextBox();
            this.lblPatente = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.DgvAutos = new System.Windows.Forms.DataGridView();
            this.clPatente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btAgregar = new System.Windows.Forms.Button();
            this.btEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAutos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBPatente
            // 
            this.txtBPatente.Location = new System.Drawing.Point(149, 48);
            this.txtBPatente.Name = "txtBPatente";
            this.txtBPatente.Size = new System.Drawing.Size(100, 20);
            this.txtBPatente.TabIndex = 2;
            // 
            // txtBMarca
            // 
            this.txtBMarca.Location = new System.Drawing.Point(149, 74);
            this.txtBMarca.Name = "txtBMarca";
            this.txtBMarca.Size = new System.Drawing.Size(100, 20);
            this.txtBMarca.TabIndex = 3;
            // 
            // txtBModelo
            // 
            this.txtBModelo.Location = new System.Drawing.Point(149, 100);
            this.txtBModelo.Name = "txtBModelo";
            this.txtBModelo.Size = new System.Drawing.Size(100, 20);
            this.txtBModelo.TabIndex = 4;
            // 
            // lblPatente
            // 
            this.lblPatente.AutoSize = true;
            this.lblPatente.Location = new System.Drawing.Point(51, 51);
            this.lblPatente.Name = "lblPatente";
            this.lblPatente.Size = new System.Drawing.Size(92, 13);
            this.lblPatente.TabIndex = 5;
            this.lblPatente.Text = "Ingrese la patente";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(51, 77);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(85, 13);
            this.lblMarca.TabIndex = 6;
            this.lblMarca.Text = "Ingrese la marca";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(51, 103);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(90, 13);
            this.lblModelo.TabIndex = 7;
            this.lblModelo.Text = "Ingrese el modelo";
            // 
            // DgvAutos
            // 
            this.DgvAutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvAutos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvAutos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DgvAutos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvAutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clPatente,
            this.clMarca,
            this.clModelo});
            this.DgvAutos.Location = new System.Drawing.Point(282, 48);
            this.DgvAutos.MultiSelect = false;
            this.DgvAutos.Name = "DgvAutos";
            this.DgvAutos.Size = new System.Drawing.Size(343, 122);
            this.DgvAutos.TabIndex = 8;
            this.DgvAutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAutos_CellClick);
            // 
            // clPatente
            // 
            this.clPatente.HeaderText = "Patente";
            this.clPatente.Name = "clPatente";
            this.clPatente.ReadOnly = true;
            // 
            // clMarca
            // 
            this.clMarca.HeaderText = "Marca";
            this.clMarca.Name = "clMarca";
            this.clMarca.ReadOnly = true;
            // 
            // clModelo
            // 
            this.clModelo.HeaderText = "Modelo";
            this.clModelo.Name = "clModelo";
            this.clModelo.ReadOnly = true;
            // 
            // btAgregar
            // 
            this.btAgregar.Location = new System.Drawing.Point(54, 147);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(75, 23);
            this.btAgregar.TabIndex = 9;
            this.btAgregar.Text = "Agregar";
            this.btAgregar.UseVisualStyleBackColor = true;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // btEliminar
            // 
            this.btEliminar.Location = new System.Drawing.Point(174, 147);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(75, 23);
            this.btEliminar.TabIndex = 10;
            this.btEliminar.Text = "Eliminar";
            this.btEliminar.UseVisualStyleBackColor = true;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 184);
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
            this.Text = "Final Libre SL2";
            ((System.ComponentModel.ISupportInitialize)(this.DgvAutos)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn clPatente;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn clModelo;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.Button btEliminar;
    }
}

