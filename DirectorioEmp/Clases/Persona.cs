using System;
using System.Collections.Generic;

namespace DirectorioEmp.Clases
{
    public class Persona
    {
        public string numeroID { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public string telefono { get; set; }
        public string celular { get; set; }
        public string pais { get; set; }
        public string ciudad { get; set; }
        public string direccion { get; set; }
        public string profesion { get; set; }

        public List<Grado> Grados { get; set; }
        public List<Cargo> Cargos { get; set; }

        public Persona()
        {
            this.Grados = new List<Grado>();
            this.Cargos = new List<Cargo>();
        }

        public Persona(string numeroID, string nombres, string apellidos, DateTime fechaNacimiento, string telefono, string celular, string pais, string ciudad, string direccion, string profesion)
        {
            this.numeroID = numeroID;
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.fechaNacimiento = fechaNacimiento;
            this.telefono = telefono;
            this.celular = celular;
            this.pais = pais;
            this.ciudad = ciudad;
            this.direccion = direccion;
            this.profesion = profesion;

            this.Grados = new List<Grado>();
            this.Cargos = new List<Cargo>();
        }
    }
}