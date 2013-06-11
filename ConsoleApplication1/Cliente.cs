using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cliente
{
    class Cliente
    {

        private string nombre, apellido, direccion, localidad, telefono;
        public int codigo;
        private DateTime FechaNac;

        private void CapturarNombre()
        {

            Console.Write("Ingrese su nombre: ");
            nombre = Console.ReadLine();
            if (nombre=="")
            {
                Console.Write("Por Favor Ingrese su nombre: ");
                CapturarNombre();
            }

        }

        private void CapturarApellido()
        {
            Console.Write("Ingrese su apellido: ");
            apellido = Console.ReadLine();
            if (apellido == "")
            {
                Console.Write("Por Favor Ingrese su apellido: ");
                CapturarApellido();
            }
        }

        private void CapturarDireccion()
        {
            Console.Write("Ingrese su dirección: ");
            direccion = Console.ReadLine();
            if (direccion=="")
            {
                Console.Write("Por Favor Ingrese su dirección: ");
                CapturarDireccion();
            }
        }

        private void CapturarCodigo()
        {
            Console.Write("Ingrese Codigo: ");
            try
            {
                codigo = Convert.ToInt32(Console.ReadLine());
            }
            catch{
                Console.Write("Codigo mal ingresado, Ingrese Codigo: ");
                CapturarCodigo();
            }

        }

        private void CapturarLocalidad()
            {
                Console.Write("Ingrese su localidad: ");
                localidad = Console.ReadLine();
            }

        private void CapturarTelefono()
            {
                Console.Write("Por último ingrese su teléfono: ");
                telefono = Console.ReadLine();
            }

        private void CapturarFechaNac()
            {
                Console.Write ("Ingrese su Fecha de Nacimiento: ");
        try {
                FechaNac = Convert.ToDateTime (Console.ReadLine ());
            }
      catch {
                Console.WriteLine("Error al ingresar la fecha de nac. intente nuevamente");
                CapturarFechaNac ();
            }
        }

 
        public string ImprimirFicha() 
            {
                string ficha="FICHA PERSONAL CLIENTE";
                ficha += "\nCodigo: " + codigo;
                ficha+="\nNombre: " + nombre;
                ficha += "\nApellido: " + apellido;
                ficha += "\nDireccion: " + direccion;
                ficha += "\nLocalidad: " + localidad;
                ficha += "\nTelefono: " + telefono;
                ficha += "\nFecha Nac: " + FechaNac.ToShortDateString();
                return ficha;
            }

            public void  CapturarDatos()
            {
                CapturarCodigo();
                CapturarNombre();
                CapturarApellido();
                CapturarDireccion();
                CapturarLocalidad();
                CapturarTelefono();
                CapturarFechaNac();
            }

            public string Presentarse()
            {
                return "Hola Soy: "+nombre+" "+apellido;
               
            }
            public void Listar()
            {
                Console.WriteLine("|{0}|{1}|{2}|{3}|{4}",codigo,nombre,apellido,direccion,localidad);

            }
       

            public string AnunciarDomicilio()
            {
                return "Vivo en: " +direccion+ " - " +localidad;
                
            }

            public string AnunciarEdad()
            {
                int edad;
                DateTime hoy = DateTime.Now;
                if (FechaNac.Month < hoy.Month)
                {
                    edad = (hoy.Year - FechaNac.Year) - 1;

                    if (FechaNac.Month == hoy.Month)
                    {
                        if (FechaNac.Day>hoy.Day)
                        {
                            edad = (hoy.Year - FechaNac.Year) - 1;
                        }
                    }
                }
                else
                {
                    edad = (hoy.Year - FechaNac.Year);
                }


                
                return "Nací en el año " + FechaNac.Year + " y tengo " + edad + " años de edad";
               
            }
            public void Hablar()
            {
                Console.WriteLine(Presentarse());
                Console.WriteLine(AnunciarDomicilio());
                Console.WriteLine(AnunciarEdad());
            }

    }
}
