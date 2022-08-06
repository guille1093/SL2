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
        //Definimos un struct Autos con los campos marca, modelo y patente
        //Solo para probar xd... Se termina usando una lista 
        //// control+k+c/u comment
        //public struct Autos
        //{
        //    public string marca;
        //    public string modelo;
        //    public string patente;
        //    //add setters

        //    public void SetAuto(string marca, string modelo, string patente)
        //    {
        //        this.marca = marca;
        //        this.modelo = modelo;
        //        this.patente = patente;
        //    }

        //}

        ////Definimos un array del struct Autos
        ////que odioso hacerlo asi
        //private Autos[] Auto = { new Autos(), new Autos(), new Autos(), new Autos(), new Autos() };
        ////Agregamos un Auto al array creado
        //public void AgregarAutos() 
        //{ 
        //    Auto[0].SetAuto("ABC123", "Ford", "2021");
        //    Auto[1].SetAuto("ABC123", "Chevrolet", "2020");
        //    Auto[2].SetAuto("ABC123", "Dodge", "1972");
        //    Auto[3].SetAuto("ABC123", "Audi", "2022");
        //    Auto[4].SetAuto("ABC123", "Fiat", "1999");
        //}
        //Definimos una Lista de Autos
        private List<Autos> Auto = new List<Autos>();
        //Definimos una funcion para agregar autos a la lista teniendo en cuenta la clase Autos
        public void AgregarAutos()
        {
            Auto.Add(new Autos { Patente = "ABC123", Marca = "Ford", Modelo = "Focus", Anio = 2021 });
        }
        private void limpiarCampos()
        {
            txtBPatente.Clear();
            txtBMarca.Clear();
            txtBModelo.Clear();
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            //Obtenemos el indice sobre el que estamos trabajando
            int n = DgvAutos.Rows.Add();
            //Seteamos los valores de las columnas con los valores de los TextBox
            //TODO: No se valida una mierda todavia. Valida con un regex por lo menos
            DgvAutos.Rows[n].Cells[0].Value = txtBPatente.Text;
            DgvAutos.Rows[n].Cells[1].Value = txtBMarca.Text;
            DgvAutos.Rows[n].Cells[2].Value = txtBModelo.Text;
            //Limpiamos los TextBox
            limpiarCampos();
            
        }

        private void dgvAutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = DgvAutos.CurrentRow.Index;
            //Seteamos los valores de los Textbox con los valores de las columnas
            try {  
                if (n != -1) 
            {
                txtBPatente.Text = DgvAutos.Rows[n].Cells[0].Value.ToString();
                txtBMarca.Text = DgvAutos.Rows[n].Cells[1].Value.ToString();
                txtBModelo.Text = DgvAutos.Rows[n].Cells[2].Value.ToString();
            }
                
        }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                return;
            }
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            //Eliminamos el elemento en el renglon seleccionado
            int n = DgvAutos.CurrentRow.Index;
            if (n != -1)
            {
                DgvAutos.Rows.RemoveAt(n);
            }
            //Limpiamos los TextBox
            limpiarCampos();

        }
    }
}
