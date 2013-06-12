using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace tateti_isp20
{//comentario de prueba
    public class Tablero
    {
        public Hashtable posiciones;//diccionario maneja de a pares de valores , (indice y valor)
        
        public Tablero()
        {
            posiciones = new Hashtable();
            //inicializamos las nueve posiciones con el valor vacio
            for (int i = 1; i < 10; i++)
                posiciones.Add(i,"  ");
        }

        public void Limpiar()
        {
            for (int i = 1; i < 10; i++)
                posiciones[i]="  ";
        }



        public void Pintar()
        {
            Console.Clear();//borro la consola
            //imprimo el tablero y cada una de las posiciones con su respectivo valor
            for (int i = 1; i < 10; i++)//el primer valor se inicializa , en el segundo hasta donde y en el tercero la accion
            {
                Console.Write("[{0}]", posiciones[i]);
                //utilizamos el modulo para detectar que ya se imprimieron 3 casilleros
                // y generamos un salto de linea
                if (i % 3 == 0)//cuando se imprimiero 3 valores hace un salto de linea
                {
                    Console.Write("\n");
                }
            }
        }

    }
}
