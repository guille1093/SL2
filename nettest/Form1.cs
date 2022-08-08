using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace nettest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Definimos una Lista de Autos
        public List<Autos> Auto = new List<Autos>();

        //Creamos las expresiones regulares para validar los campos
        private readonly Regex _regexPatente = new Regex(@"^[A-Z]{3}\d{3}$");
        private readonly Regex _regexMarca = new Regex(@"^[A-Za-z]+$");
        private readonly Regex _regexModelo = new Regex(@"^[A-Za-z]+$");
        private readonly Regex _regexAnio = new Regex(@"^\d{4}$");

        //Define como DataSource del TableGridView la Lista de Autos
        private void ActualizarDgv()
        {
            BindingSource source = new BindingSource{DataSource = Auto};
            DgvAutos.DataSource = source;
        }

        //Hace visibles todas las filas del DataGridView
        private void MostrarFilas()
        {
            foreach (DataGridViewRow row in DgvAutos.Rows)
            {
                row.Visible = true;
            }
        }

        //Oculta las filas que no cumplan con el criterio de busqueda utilizando una query Linq
        private void FiltrarFilas()
        {
            switch (RBPatente.Checked)
            {
                case true:
                    DgvAutos.Rows.Cast<DataGridViewRow>().Where(row => !row.Cells[0].Value.ToString().Contains(txtBPatente.Text)).ToList().ForEach(row => row.Visible = false);
                    break;
                default:
                    break;
            }
            switch (RBMarca.Checked)
            {
                case true:
                    DgvAutos.Rows.Cast<DataGridViewRow>().Where(row => !row.Cells[1].Value.ToString().Contains(txtBMarca.Text)).ToList().ForEach(row => row.Visible = false);
                    break;
                default:
                    break;
            }
            switch (RBModelo.Checked)
            {
                case true:
                    DgvAutos.Rows.Cast<DataGridViewRow>().Where(row => !row.Cells[2].Value.ToString().Contains(txtBModelo.Text)).ToList().ForEach(row => row.Visible = false);
                    break;
                default:
                    break;
            }
            switch (RBAnio.Checked)
            {
                case true:
                    DgvAutos.Rows.Cast<DataGridViewRow>().Where(row => !row.Cells[3].Value.ToString().Contains(txtBAnio.Text)).ToList().ForEach(row => row.Visible = false);
                    break;
                default:
                    break;
            }
        }



        //funcion lambda booleana que retorna true si ya existe una patente en la lista con el mismo valor que el del textbox
        private bool ExistePatente()
        {
            if (!Auto.Exists(x => x.Patente == txtBPatente.Text)) return false;
            MessageBox.Show("La patente ya existe", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            return true;
        }

        //funcion que rellena la lista con autos de prueba
        private void Rellenar()
        {
            Auto.Add(new Autos() { Patente = "ABC123", Marca = "Ford",      Modelo = "Focus",    Anio = 2021 });
            Auto.Add(new Autos() { Patente = "DEF456", Marca = "Chevrolet", Modelo = "Cruze",    Anio = 2020 });
            Auto.Add(new Autos() { Patente = "GHI789", Marca = "Honda",     Modelo = "Civic",    Anio = 2019 });
            Auto.Add(new Autos() { Patente = "JKL012", Marca = "Toyota",    Modelo = "Corolla",  Anio = 2018 });
            Auto.Add(new Autos() { Patente = "MNO345", Marca = "Nissan",    Modelo = "Sentra",   Anio = 2017 });
            Auto.Add(new Autos() { Patente = "PQR678", Marca = "Hyundai",   Modelo = "Sonata",   Anio = 2016 });
            Auto.Add(new Autos() { Patente = "STU901", Marca = "Kia",       Modelo = "Ceed",     Anio = 2015 });
            Auto.Add(new Autos() { Patente = "ABX713", Marca = "Ford",      Modelo = "Mondeo",   Anio = 2022 });
            Auto.Add(new Autos() { Patente = "MTX820", Marca = "Audi",      Modelo = "Q4",       Anio = 2017 });
            Auto.Add(new Autos() { Patente = "QWE908", Marca = "Nissan",    Modelo = "Qashqai",  Anio = 2018 });
            Auto.Add(new Autos() { Patente = "RTY654", Marca = "Kia",       Modelo = "Rio",      Anio = 2019 });
            Auto.Add(new Autos() { Patente = "UIO321", Marca = "Hyundai",   Modelo = "Genesis",  Anio = 2020 });
            Auto.Add(new Autos() { Patente = "VBN654", Marca = "Chevrolet", Modelo = "Cruze",    Anio = 2021 });
            Auto.Add(new Autos() { Patente = "WXY987", Marca = "Honda",     Modelo = "Civic",    Anio = 2022 });
            Auto.Add(new Autos() { Patente = "ZAB987", Marca = "Toyota",    Modelo = "Corolla",  Anio = 2017 });
            Auto.Add(new Autos() { Patente = "CDE654", Marca = "Nissan",    Modelo = "Sentra",   Anio = 2018 });
            Auto.Add(new Autos() { Patente = "FGH321", Marca = "Dodge",     Modelo = "Charger",  Anio = 1969 });
            Auto.Add(new Autos() { Patente = "GHI654", Marca = "Ford" ,     Modelo  = "Mustang", Anio = 2020 });
            Auto.Add(new Autos() { Patente = "JKL654", Marca = "Acura",     Modelo = "NSX",      Anio = 1999 });
            Auto.Add(new Autos() { Patente = "KLM321", Marca = "Audi",      Modelo = "Q3",       Anio = 2020 });
            Auto.Add(new Autos() { Patente = "NOP654", Marca = "Nissan",    Modelo = "R32",      Anio = 1998 });
            ActualizarDgv();
            DgvAutos.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            btnModeloPruebas.Enabled = false;
        }

        //Definimos una funcion para agregar autos a la lista
        private void AgregarAutos()
        {
            Auto.Add(new Autos
            {
                Patente = txtBPatente.Text,
                Marca = txtBMarca.Text,
                Modelo = txtBModelo.Text,
                Anio = Convert.ToInt32(txtBAnio.Text)
            });
            //Mensaje de confirmacion de agregado de autos
            MessageBox.Show(txtBMarca.Text+" "+txtBModelo.Text+ " agregado correctamente",
                "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LimpiarCampos()
        {
            txtBPatente.Clear();
            txtBMarca.Clear();
            txtBModelo.Clear();
            txtBAnio.Clear();
        }

        private bool ValidarCampos()
        {
            //Validamos los campos con las expresiones regulares
            if (_regexPatente.IsMatch(txtBPatente.Text) 
                && _regexMarca.IsMatch(txtBMarca.Text) 
                && _regexModelo.IsMatch(txtBModelo.Text) 
                && _regexAnio.IsMatch(txtBAnio.Text)) return true;
            MessageBox.Show("Por favor, ingrese los datos correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }


        ////////////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////// Event Handlers del formulario ////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////////

        //Evento por defecto del Formulario, inicializamos propiedades y funciones
        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        //Click en el boton agregar
        private void BtAgregarClick(object sender, EventArgs e)
        {
            //Verificamos que los textboxs no esteen vacios y la patente no sea repetida
            if (!ValidarCampos() || ExistePatente()) return;
            AgregarAutos();
            ActualizarDgv();
            LimpiarCampos();
        }

        //Click en una celda valida del DataGridView
        private void dgvAutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Obtenemos la fila seleccionada
            if (DgvAutos.CurrentRow == null) return;
            int n = DgvAutos.CurrentRow.Index;
            if (n == -1) return;
            //Seteamos los valores de los Textbox con los valores de las columnas
            txtBPatente.Text = DgvAutos.Rows[n].Cells[0].Value.ToString();
            txtBMarca.Text = DgvAutos.Rows[n].Cells[1].Value.ToString();
            txtBModelo.Text = DgvAutos.Rows[n].Cells[2].Value.ToString();
            txtBAnio.Text = DgvAutos.Rows[n].Cells[3].Value.ToString();

        }

        //
        private void btEliminar_Click(object sender, EventArgs e)
        {
            if (DgvAutos.CurrentRow == null) return; 
            int n = DgvAutos.CurrentRow.Index;
            if (n == -1) return;
            MessageBox.Show("¿Esta seguro que desea eliminar el auto " + DgvAutos.Rows[n].Cells[0].Value.ToString() + "?",
                "Advertencia",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            Auto.RemoveAt(n);
            ActualizarDgv();
            LimpiarCampos();

        }


        private void btnModeloPruebas_Click(object sender, EventArgs e)
        {
            Rellenar();
        }


        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            MostrarFilas();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                FiltrarFilas();
            }
            catch (Exception)
            {
                MessageBox.Show("No se encontraron coincidencias", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                MostrarFilas();
            }
        }

    }
}
