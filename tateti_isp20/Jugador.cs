using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections; 

namespace tateti_isp20
{
    public class Jugador
    {
        //declaracion de propiedades
        public Hashtable fichas;//diccionario de fichas
        public string tipo_ficha;//tipo de ficha con la que juega

        public Jugador(string tipoficha)// metodo constructor - y le llega por parametro un texto "tipoficha"
        {
            fichas = new Hashtable();// inicializamos la propiedad
            //definimos tres fichas y le damos valor 0
            fichas.Add(1,0);
            fichas.Add(2,0);
            fichas.Add(3,0);
            tipo_ficha=tipoficha;//almaceno el parametro tipoficha en tipo_ficha
        }
    }
}
