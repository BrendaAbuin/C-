using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Ejercicio 1

            //Console.WriteLine("Ingrese el lado de un triangulo");
            //int LadoTriangulo = int.Parse(Console.ReadLine());


            //int LadoTotal = TrianguloEquilatero(LadoTriangulo);
            //Console.WriteLine("El perimetro es: " + LadoTotal);


            ////Ejercicio 2
            //Console.WriteLine("Ingrese su nombre");
            //string Nombre1 = Console.ReadLine();

            //Console.WriteLine("Ingrese su nombre");
            //string Nombre2 = Console.ReadLine();

            //Console.WriteLine("Ingrese el peso de " + Nombre1);
            //int Peso1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Ingrese el peso de " + Nombre2);
            //int Peso2 = int.Parse(Console.ReadLine());


            //int suma = Peso1 + Peso2;
            //int promedio = suma / 2;
            //Console.WriteLine($"Ustedes se llaman {Nombre1} y {Nombre2} " +
            //    $"y pesan {Peso1} y {Peso2} kilos que sumados son {suma} y el promedio de peso es {promedio}");


            ////Ejercicio 3
            //Console.WriteLine("Ingrese el precio");
            //double PrecioProducto = double.Parse(Console.ReadLine());

            //Console.WriteLine("Ingrese el descuento");
            //double descuento = double.Parse(Console.ReadLine());

            //double Precio = PrecioTotal(PrecioProducto, descuento);
            //Console.WriteLine("El precio final es: " + Precio);


            //EJERCICIO 4
            Console.WriteLine("Ingresa un numero");
            int Numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese otro numero");
            int Numero2 = int.Parse(Console.ReadLine());

            NumerosTotales(Numero1, Numero2);
            



            Console.ReadKey();
        }

        //static int TrianguloEquilatero(int LadoTriangulo)
        //{
        //    int perimetro = LadoTriangulo * 3;
        //    return perimetro;
        //}
        //static double PrecioTotal (double PrecioProducto,double descuento)
        //{
        //    double PrecioConDescuento = PrecioProducto * descuento/100;
        //    double PrecioTotalConDescuento = PrecioProducto - PrecioConDescuento;
        //    return PrecioTotalConDescuento;
        //}

        static void NumerosTotales(int Numero1, int Numero2)
        {
            int Resta = Numero1 - Numero2;
            int Suma = Numero1 + Numero2;

            if (Numero1 == Numero2)
            {
                Console.WriteLine(Numero1.ToString() + Numero2.ToString());
            }
            if (Numero1 > Numero2)
            {
                Console.WriteLine(Resta); 
            }
            if (Numero2 > Numero1)
            {
                Console.WriteLine(Suma);
            }
            else if (Resta > 10)
            {
                Console.WriteLine($"La resta es {Resta} y supero el 10");
            }
               
            
             

        }
    }
      

}
