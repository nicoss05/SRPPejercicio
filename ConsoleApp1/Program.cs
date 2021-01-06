using SRPPejercicio;
using System;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Empleado empleado = new Empleado();
            empleado.Sueldo = 100;
            CalculadoraImpuesto calculadoraImpuesto = new CalculadoraImpuesto();
            double impuestoTrabajdor = calculadoraImpuesto.CalcularImpuestoIessDelTrabajador(empleado.Sueldo);
            Console.WriteLine("El impuesto que paga el trabajador es {0}", impuestoTrabajdor);

        }
    }
}
