using System;

namespace DirectorioEmp.Clases
{
    public class Cargo
    {
        public int numeroCargo { get; set; }
        public string titulo { get; set; }
        public DateTime fechaInicio { get; set; }
        public DateTime fechaFinal { get; set; }
        public bool empleadoActual { get; set; }
        public string empresa { get; set; }
        public decimal salario { get; set; }
        public string detalles { get; set; }

        public Cargo()
        {
            
        }

        public Cargo(int numeroCargo, string titulo, DateTime fechaInicio, DateTime fechaFinal, bool empleadoActual, string empresa, decimal salario, string detalles)
        {
            this.numeroCargo = numeroCargo;
            this.titulo = titulo;
            this.fechaInicio = fechaInicio;
            this.fechaFinal = fechaFinal;
            this.empleadoActual = empleadoActual;
            this.empresa = empresa;
            this.salario = salario;
            this.detalles = detalles;
        }
    }
}