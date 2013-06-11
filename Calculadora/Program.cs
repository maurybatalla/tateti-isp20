using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
           /* string nombre, apellido = "";
            Console.WriteLine("Ingresa tu nombre:");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingresa su Apellido:");
            apellido = Console.ReadLine();
            Console.WriteLine("Bienvenido a C# {0} {1} ",nombre,apellido);
            */
            
            Calculadora micalcu = new Calculadora(); //(instanciamos la calculadora)creo el objeto micalcu  basado en la clase calculadora

            Console.WriteLine("Ingrese un Numero: ");//pedimos el ingreso del primer numero
            //grabamos el numero en la calculadora
            float nro1 = Convert.ToSingle(Console.ReadLine());
            micalcu.IngresarValor(nro1);


            Console.WriteLine("Ingrese la operacion");//pido el tipo de operacion
            string tipodeoperacion = Console.ReadLine();//almaceno lo que escribio el usuario en tipodeoperacion

            //pedimos otro numero y hacemos lo mismo que en el paso anterior
            Console.WriteLine("Ingrese Otro Numero: ");
            float nro2 = Convert.ToSingle(Console.ReadLine());
            micalcu.IngresarValor(nro2);

           
            Console.WriteLine("El resultado es: {0}",micalcu.MostrarResultado(tipodeoperacion));//muestro el resultado
            Console.ReadKey();
       

           

            

        }
    }
}
