using System;

namespace DirectorioEmp.Clases
{
    public class Grado
    {
        public int numeroGrado { get; set; }
        public string nivelEducativo { get; set; }
        public string institucion { get; set; }
        public string nombreTitulo { get; set; }
        public DateTime fechaInicio { get; set; }
        public DateTime fechaFinal { get; set; }
        public string tipoGrado { get; set; }
        public DateTime fechaExpiracion { get; set; }
        public string pais { get; set; }

        public Grado()
        {

        }

        public Grado(int numeroGrado, string nivelEducativo, string institucion, string nombreTitulo, DateTime fechaInicio, DateTime fechaFinal, string tipoGrado, DateTime fechaExpiracion, string pais)
        {
            this.numeroGrado = numeroGrado;
            this.nivelEducativo = nivelEducativo;
            this.institucion = institucion;
            this.nombreTitulo = nombreTitulo;
            this.fechaInicio = fechaInicio;
            this.fechaFinal = fechaFinal;
            this.tipoGrado = tipoGrado;
            this.fechaExpiracion = fechaExpiracion;
            this.pais = pais;
        }
    }
}