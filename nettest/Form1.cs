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

        //Definimos como DataSource del TableGridView la Lista de Autos
        private void ActualizarDgv()
        {
            var source = new BindingSource
            {
                DataSource = Auto
            };
            DgvAutos.DataSource = source;
        }

        //Funcion que hace visible todas las filas del DataGridView
        private void MostrarFilas()
        {
            foreach (DataGridViewRow row in DgvAutos.Rows)
            {
                row.Visible = true;
            }
        }

        //funcion que oculta las filas que no contengan el campo seleccionado por el raddiobutton 
        private void OcultarFilas()
        {
            if (RBPatente.Checked)
            {
                //Algunas veces el DataGridView toma la cell[0] como header lo que genera una excepcion al intentar ser modificada
                try
                {
                    foreach (DataGridViewRow row in DgvAutos.Rows)
                    {
                        if (!row.Cells[0].Value.ToString().Contains(txtBPatente.Text))
                        {
                            row.Visible = false;
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("No se encontraron coincidencias", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }

            if (RBMarca.Checked)
            {
                foreach (DataGridViewRow row in DgvAutos.Rows)
                {
                    if (!row.Cells[1].Value.ToString().Contains(txtBMarca.Text))
                    {
                        row.Visible = false;
                    }
                }
            }
            if (RBModelo.Checked)
            {
                foreach (DataGridViewRow row in DgvAutos.Rows)
                {
                    if (!row.Cells[2].Value.ToString().Contains(txtBModelo.Text))
                    {
                        row.Visible = false;
                    }
                }
            }
            if (RBAnio.Checked)
            {
                foreach (DataGridViewRow row in DgvAutos.Rows)
                {
                    if (!row.Cells[3].Value.ToString().Contains(txtBAnio.Text))
                    {
                        row.Visible = false;
                    }
                }
            }
        }
        
        

        //funcion lambda boolean que retorna true si ya existe una patente en la lista con el mismo valor que el del textbox
        private bool ExistePatente()
        {
            if (Auto.Exists(x => x.Patente == txtBPatente.Text))
            {
                MessageBox.Show("La patente ya existe",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return true;
            }
            else
            {
                return false;
            }
        }

        //funcion que rellena la lista con autos de prueba
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
            Auto.Add(new Autos() { Patente = "QWE908", Marca = "Nissan", Modelo = "Qashqai", Anio = 2018 });
            Auto.Add(new Autos() { Patente = "RTY654", Marca = "Kia", Modelo = "Rio", Anio = 2019 });
            Auto.Add(new Autos() { Patente = "UIO321", Marca = "Hyundai", Modelo = "Genesis", Anio = 2020 });
            Auto.Add(new Autos() { Patente = "VBN654", Marca = "Chevrolet", Modelo = "Cruze", Anio = 2021 });
            Auto.Add(new Autos() { Patente = "WXY987", Marca = "Honda", Modelo = "Civic", Anio = 2022 });
            Auto.Add(new Autos() { Patente = "ZAB987", Marca = "Toyota", Modelo = "Corolla", Anio = 2017 });
            Auto.Add(new Autos() { Patente = "CDE654", Marca = "Nissan", Modelo = "Sentra", Anio = 2018 });
            Auto.Add(new Autos() { Patente = "FGH321", Marca = "Dodge", Modelo = "Charger", Anio = 1969 });
            Auto.Add(new Autos() { Patente = "GHI654", Marca = "Ford" , Modelo  = "Mustang", Anio = 2020 });
            Auto.Add(new Autos() { Patente = "JKL654", Marca = "Acura", Modelo = "NSX", Anio = 1999 });
            Auto.Add(new Autos() { Patente = "KLM321", Marca = "Audi", Modelo = "Q3", Anio = 2020 });
            Auto.Add(new Autos() { Patente = "NOP654", Marca = "Nissan", Modelo = "R32", Anio = 1998 });
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
                "Operacion exitosa",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
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
                MessageBox.Show("El año debe tener 4 digitos",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }

            if (!txtBAnio.Text.Any(char.IsLetter)) return true;
            MessageBox.Show("El año debe ser un numero",
                "Advertencia",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
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
            OcultarFilas();
        }

    }
}
