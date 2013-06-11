using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace tateti_isp20
{
    public class Juego
    {
        private Tablero tablero;
        private Jugador jugador1;
        private Jugador jugador2;

        public Juego()
        {

            tablero = new Tablero();//inicializamos
            jugador1 = new Jugador("X");//inicializamos
            jugador2 = new Jugador("O");//inicializamos
        }

        public void PintarTablero()
        {
            tablero.Limpiar();
            foreach (DictionaryEntry ficha in jugador1.fichas)//crea objeta de tipo ficha de tipo dictionaryentry
            {
                tablero.posiciones[ficha.Value] = jugador1.tipo_ficha + ficha.Key.ToString();// en tablero en tal posicion en el jugador uno imprime la ficha
            }

            foreach (DictionaryEntry ficha in jugador2.fichas)// evaluamos las fichas y por cada vez que da vuelta trae dos datos
            {
                tablero.posiciones[ficha.Value] = jugador2.tipo_ficha + ficha.Key.ToString();
            }
            tablero.Pintar();
        }


        public int SeleccionarFicha(int jugador_actual)
        {
            int ficha_a_mover = 0;
            Console.Write("Jugador {0}: ingrese la el numero de ficha a mover: ", jugador_actual);
            try
            {
                ficha_a_mover = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("ERROR VALOR INCORRECTO, PRESIONE UNA TECLA PARA CONTINUAR");
                Console.ReadKey();
                SeleccionarFicha(jugador_actual);
            }
            return ficha_a_mover;
        }

        public void Jugar (int jugador, int nroficha, int pos_elegida)
        {
            if(jugador==1)
                jugador1.fichas[nroficha] = pos_elegida;
            else
                jugador2.fichas[nroficha] = pos_elegida;
            //tablero.Marcar(jugador, pos_elegida);

        }
    }
}
