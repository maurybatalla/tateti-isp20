using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tateti_isp20
{
    class Program
    {
        static void Main(string[] args)
        {   //declaro e inicializo el juego
            Juego juego = new Juego();
            int jugador_actual = 1;//creo variable
            int ficha_actual = 1;//creo variable
            int ficha_a_mover = 0;
            int posicion_elegida = 0;
            while (true)
            {
                juego.PintarTablero();//llamo al metodo pintar tablero de juego
                //pide ingresar e movimiento
                //cuando se colocaron las seis fichas pide definir la ficha a mover
                if (ficha_actual == 0)
                {
                    ficha_a_mover = juego.SeleccionarFicha(jugador_actual);
                    Console.Write("Jugador {0}: ingrese la posicion de la ficha {1} : ", jugador_actual, ficha_a_mover);
                    posicion_elegida = Convert.ToInt32(Console.ReadLine());
                    juego.Jugar(jugador_actual, ficha_a_mover, posicion_elegida);//llamo al metodo jugar y le paso los parametros
                }
                //en las primeras seis fichas se ejecuta esto
                else
                {
                    Console.Write("Jugador {0}: ingrese la posicion de la ficha {1} : ", jugador_actual, ficha_actual);
                    try
                    {
                        posicion_elegida = Convert.ToInt32(Console.ReadLine());
                    }
                    catch 
                    {
                        Console.WriteLine("ERROR VALOR INCORRECTO, PRESIONE UNA TECLA PARA CONTINUAR");
                        Console.ReadKey();
                        continue;
                    }
                    //almaceno el movimiento en el tablero y en las fichas del jugador
                    juego.Jugar(jugador_actual, ficha_actual, posicion_elegida);//llamo al metodo jugar y le paso los parametros

                }
                //cambio el jugador
                jugador_actual++;

                if (jugador_actual == 3)
                {
                    jugador_actual = 1;
                    if (ficha_actual > 0)
                    {
                        ficha_actual++;
                        if (ficha_actual == 4)
                            ficha_actual = 0;
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
