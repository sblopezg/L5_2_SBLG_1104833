using System;
using System.Diagnostics;

namespace L5_2_SBLG_1104833
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int DIA;
            Console.WriteLine("EJERCICIO 2");
            Console.WriteLine("Ingresar el número");

            DIA = Convert.ToInt32(Console.ReadLine());

            if (DIA == 1)
            {
                Console.WriteLine("El dia es lunes");
            }
            if (DIA == 2)
            {
                Console.WriteLine("El dia es marte");
            }
            if (DIA == 3)
            {
                Console.WriteLine("El dia es miercoles");
            }
            if (DIA == 4)
            {
                Console.WriteLine("El dia es jueves");
            }
            if (DIA == 5)
            {
                Console.WriteLine("El dia es viernes");
            }
            if (DIA == 6)
            {
                Console.WriteLine("El dia es sabado");
            }
            if (DIA == 7)
            {
                Console.WriteLine("El dia es domingo");
            }
            if (DIA > 7)
            {
                Console.WriteLine("El numero no coincide");
            }
            Console.ReadKey();
         
        }
    }
}
