using System;
using System.Collections.Generic;
using DirectorioEmp.Clases;

namespace DirectorioEmp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // instancia de Persona
            Persona miPersona = new Persona("0801200312345", "Josue ", "Barahona", new DateTime(2003, 5, 15), "22334115", "99887766", "Honduras", "Tegucigalpa", "Colonia Miraflores", "Ingeniero");

            // instancias de Grado y Cargo
            Grado gradoUniversitario = new Grado(1, "Universitario", "Universidad Metropolitana", "Ingeniería en informatica", new DateTime(2020, 1, 1), new DateTime(2025, 12, 15), "Pregrado", DateTime.Now.AddYears(1), "Honduras");
            Cargo cargoActual = new Cargo(1, "Desarrollador de Software", new DateTime(2023, 1, 10), DateTime.Now, true, "Diuns", 17000.00m, "Desarrollo de aplicaciones web y móviles.");

            miPersona.Grados.Add(gradoUniversitario);
            miPersona.Cargos.Add(cargoActual);

            Console.WriteLine($"--- Datos de la Persona ---");
            Console.WriteLine($"ID: {miPersona.numeroID}");
            Console.WriteLine($"Nombre Completo: {miPersona.nombres} {miPersona.apellidos}");
            Console.WriteLine($"Fecha de Nacimiento: {miPersona.fechaNacimiento.ToShortDateString()}");
            Console.WriteLine($"Profesión: {miPersona.profesion}");
            Console.WriteLine();

            Console.WriteLine("--- Grados Académicos ---");
            foreach (var grado in miPersona.Grados)
            {
                Console.WriteLine($"Título: {grado.nombreTitulo}");
                Console.WriteLine($"Institución: {grado.institucion}");
                Console.WriteLine($"Nivel: {grado.nivelEducativo}");
                Console.WriteLine($"Fechas: {grado.fechaInicio.ToShortDateString()} - {grado.fechaFinal.ToShortDateString()}");
                Console.WriteLine();
            }

            Console.WriteLine("--- Historial de Cargos ---");
            foreach (var cargo in miPersona.Cargos)
            {
                Console.WriteLine($"Título del Cargo: {cargo.titulo}");
                Console.WriteLine($"Empresa: {cargo.empresa}");
                Console.WriteLine($"Salario: {cargo.salario:C}");
                Console.WriteLine($"Fechas: {cargo.fechaInicio.ToShortDateString()} - {cargo.fechaFinal.ToShortDateString()}");
                Console.WriteLine($"Empleado Actual: {(cargo.empleadoActual ? "Sí" : "No")}");
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}