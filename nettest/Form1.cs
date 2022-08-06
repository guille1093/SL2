using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        //Definimos una Lista de Autos Filtrados
        public List<Autos> AutosFiltrados = new List<Autos>();

        //funcion que rellena la lista con 9 autos de prueba
        private void Rellenar()
        {
            Auto.Add(new Autos() { Patente = "ABC123", Marca = "Ford", Modelo = "Focus", Anio = 2021 });
            Auto.Add(new Autos() { Patente = "DEF456", Marca = "Chevrolet", Modelo = "Cruze", Anio = 2020 });
            Auto.Add(new Autos() { Patente = "GHI789", Marca = "Honda", Modelo = "Civic", Anio = 2019 });
            Auto.Add(new Autos() { Patente = "JKL012", Marca = "Toyota", Modelo = "Corolla", Anio = 2018 });
            Auto.Add(new Autos() { Patente = "MNO345", Marca = "Nissan", Modelo = "Sentra", Anio = 2017 });
            Auto.Add(new Autos() { Patente = "PQR678", Marca = "Hyundai", Modelo = "Sonata", Anio = 2016 });
            Auto.Add(new Autos() { Patente = "STU901", Marca = "Kia", Modelo = "Ceed", Anio = 2015 });
            Auto.Add(new Autos() { Patente = "ABX713", Marca = "Ford", Modelo = "Mondeo", Anio = 2022 });
            Auto.Add(new Autos() { Patente = "MTX820", Marca = "Audi", Modelo = "Q4", Anio = 2017 });
            var source = new BindingSource
            {
                DataSource = Auto
            };
            DgvAutos.DataSource = source;
        }

        //Definimos una funcion para agregar autos a la lista teniendo en cuenta la clase Autos
        private void AgregarAutos()
        {
            Auto.Add(new Autos
            {
                Patente = txtBPatente.Text,
                Marca = txtBMarca.Text,
                Modelo = txtBModelo.Text,
                Anio = Convert.ToInt32(txtBAnio.Text)
            });
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
            //Verificamos que los textboxs no esteen vacios y mostramos una advertencia si lo estan
            if (txtBPatente.Text == "" || txtBMarca.Text == "" || txtBModelo.Text == "" || txtBAnio.Text == "")
            {
                MessageBox.Show("Por favor complete todos los campos",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }
            if (txtBPatente.Text.Length != 6)
            {
                MessageBox.Show("La patente debe tener 6 caracteres",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }
            if (txtBAnio.Text.Length != 4)
            {
                MessageBox.Show("El año debe tener 4 caracteres",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }
            if (txtBAnio.Text.Any(char.IsLetter))
            {
                MessageBox.Show("El año debe ser un numero",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void BtAgregarClick(object sender, EventArgs e)
        {
            //Verificamos que los textboxs no esteen vacios y mostramos una advertencia si lo estan
            if (ValidarCampos())
            {
                //Agregamos un nuevo auto a la lista
                AgregarAutos();
                //Limpiamos los textboxs
                LimpiarCampos();
            }
            //Populamos la tableview con los datos de la lista
            var source = new BindingSource
            {
                DataSource = Auto
            };
            DgvAutos.DataSource = source;
            LimpiarCampos();
        }

        private void dgvAutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Obtenemos la fila seleccionada
            if (DgvAutos.CurrentRow == null) return;
            int n = DgvAutos.CurrentRow.Index;
            //Seteamos los valores de los Textbox con los valores de las columnas
            if (n == -1) return;
            txtBPatente.Text = DgvAutos.Rows[n].Cells[0].Value.ToString();
            txtBMarca.Text = DgvAutos.Rows[n].Cells[1].Value.ToString();
            txtBModelo.Text = DgvAutos.Rows[n].Cells[2].Value.ToString();
            txtBAnio.Text = DgvAutos.Rows[n].Cells[3].Value.ToString();

        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            //Eliminamos el elemento en el renglon seleccionado
            if (DgvAutos.CurrentRow == null) return; 
            int n = DgvAutos.CurrentRow.Index;
            if (n == -1) return;
            Auto.RemoveAt(n);
            //Populamos la tableview con los datos actualizados
            var source = new BindingSource
            {
                DataSource = Auto
            };
            DgvAutos.DataSource = source;
            //Limpiamos los TextBox
            LimpiarCampos();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        //Evento por defecto del Formulario, inicializamos propiedades y funciones
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnModeloPruebas_Click(object sender, EventArgs e)
        {
            Rellenar();
        }

        private void DgvAutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}
