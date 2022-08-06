using System;

namespace nettest
{
    //Clase Autos 🚗🚗🚗//
    public class Autos 
    {
        //Atributos//
        public string Patente;
        public string Marca;
        public string Modelo;
        public int Anio;

        //Metodos//
        //Constructor 💪💪💪//
        public Autos(string patente, string marca, string modelo, int anio)
        {
            this.Patente = patente ?? throw new ArgumentNullException(nameof(patente));
            this.Marca = marca ?? throw new ArgumentNullException(nameof(marca));
            this.Modelo = modelo ?? throw new ArgumentNullException(nameof(modelo));
            this.Anio = anio;
        }

        //Constructor sin parametros 😎😎😎//
        public Autos()
        {
        }

        //Setters ❤️❤️❤️//
        public void SetAutos(string patente, string marca, string modelo, int anio)
        {
            this.Patente = patente;
            this.Marca = marca;
            this.Modelo = modelo;
            this.Anio = anio;
        }

        //Getters 🦘🦘🦘//
        public string GetPatente()
        {
            return this.Patente;
        }
        public string GetMarca()
        {
            return this.Marca;
        }
        public string GetModelo()
        {
            return this.Modelo;
        }
        public int GetAnio()
        {
            return this.Anio;
        }
        
        //ToString
        
    }
}