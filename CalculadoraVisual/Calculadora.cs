using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculadoraVisual
{
    public class Calculadora //primer clase de prueba
    {
        private float numero1;//propiedades
        private float numero2;//propiedades
        private float resultado;//propeidades

        public Calculadora()
        {
            numero1 = 0;  //variable - les asigno el valor del parametro nro1 a la propiedad numero1
            numero2 = 0; //variable - les asigno el valor del parametro nro2 a la propiedad numero2
        }

        public Calculadora(float nro1, float nro2)//constructor que recibe los parametros - nunca devuelve ningun valor
        {
            numero1 = nro1;  //variable - les asigno el valor del parametro nro1 a la propiedad numero1
            numero2 = nro2; //variable - les asigno el valor del parametro nro2 a la propiedad numero2
        }

        public float Sumar() // creo el metodo SUMAR!!!!!!  - como es public Int quiere decir que espero un valor float de vuelta
        {
            return numero1 + numero2;
        }

        public float Sumar(float nro) // creo una sobrecargar en el metodo SUMAR con un paramatro que es "nro"!!!!!!  - como es public Int quiere decir que espero un valor float de vuelta
        {
            return numero1 + numero2 + nro;
        }

        public void IngresarValor(float nro1, float nro2)
        {
            
                numero1 = nro1;

                numero2 = nro2;
          
        }

        public float MostrarResultado(string operacion)
        {
            if (operacion == "+")
            {
                return numero1 + numero2;
            }
            if (operacion == "-")
            {
                return numero1 - numero2;
            }
            if (operacion == "*")
            {
                return numero1 * numero2;
            }
            if (operacion == "/")
            {
                return numero1 / numero2;
            }
            else
            {
                return 0;
            }
           
        }


    }
}
