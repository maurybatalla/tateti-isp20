using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Cliente
{
    public class SistemaClientes
    {
        ArrayList clientes = new ArrayList(); // por el lugar en donde esta pasa a ser un propiedad que hace referencia a un objeto

       public SistemaClientes ()
       {
           Console.WriteLine("Cargando el Sistema de Clientes");
       }

       public void Iniciar() // metodo publico que lo unico que hace es llamar al menu
       {
           Menu();
       }

       private void ListarClientes()
       {
           foreach (Cliente cli in clientes)
           {//recorre el array clientes y crea un objeto cli del tipo cliente por cada uno de los arreglos
              cli.Listar();
           }
       }

       private void BorrarCliente(int id_borrar)
       {
           foreach (Cliente cli in clientes)
           {//recorre el array clientes y crea un objeto cli del tipo cliente por cada uno de los arreglos
               if (cli.codigo == id_borrar)//si encuentra el codgio de cliente igual el codigo a eliminar
               {
                   clientes.Remove(cli);//lo remueve del array
                   break;
               }
           }
       }

       private void Menu()
       {
            int opcion = 0;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Carga de Clientes");
                Console.WriteLine("1- Cargar un Nuevo Cliente");
                Console.WriteLine("2-Listar Clientes Cargados");
                Console.WriteLine("3-Borrar un Cliente");
                Console.WriteLine("4-Salir");
                Console.WriteLine("Ingrese el numero de la opcion a realizar");
                try
                {
                    opcion = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Error En la Opcion Ingresada");
                }

                switch (opcion) // analiza la variable opcion
                {
                    case 1:// si opcion es 1 hace lo que esta abjo
                        Cliente cliente = new Cliente();//creo el ojeto cliente basado en la clase clientes
                        cliente.CapturarDatos();
                        clientes.Add(cliente);//lo incorporo al array
                        break;// al final de cada case es obligatorio poner un brak
                    case 2:
                        ListarClientes();
                        Console.ReadLine();
                        break;
                    case 3:
                        ListarClientes();
                        Console.Write("Ingrese el número del Cliente a Eliminar: ");
                        int eliminar_cliente =Convert.ToInt32(Console.ReadLine());
                        BorrarCliente(eliminar_cliente);
                        ListarClientes();
                        Console.ReadLine();
                        break;
                    case 4:
                        return;

                }
            }
        }

    }
}
