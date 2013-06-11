using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Cliente
{
    class Program
    {
        static void Main(string[] args) 
        {
            SistemaClientes sistema = new SistemaClientes(); // creo un objeto llamado sistema basado en la clase Sistemaclientes
            sistema.Iniciar(); // llamamos al metodo inicar de sistemaclientes
        } 
    }
}
