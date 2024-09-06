using EspacioCadeteria;
using EspacioCadete;
using EspacioCliente;
using EspacioCSV;
using EspacioPedidos;

namespace Main
{
    public class Program
    {
        ﻿// See https://aka.ms/new-console-template for more information
        //Estado conviene más hacerlo enum ya que quizás en un futuro además de realizado y no realizado, quizas agregar en camino no sería posible si asignara bool
        //Hacer un campo publico no esta bien visto, siempre se trabaja con campos y atributos privados, mientras que las propiedades y los metodos pueden ser publicos
        

        public void Interfaz()
        {
            AccesoAdatos datos = new AccesoAdatos();
            Cadeteria cadeteria = new Cadeteria();

            datos.CargarCadetes("cadetes.csv", cadeteria);
            datos.CargarCadeteria("cadeteria.csv", cadeteria);

            
        int opcion = 2;
        Pedidos pedido = null;

        while(opcion <=4  && opcion >= 1)
        {
            System.Console.WriteLine("1 - Dar de alta un pedido");
            System.Console.WriteLine("2 - Asignar pedido a un cadete");
            System.Console.WriteLine("3 - Cambiar estado de un pedido");
            System.Console.WriteLine("4 - Reasignar pedido a otro cadete");
            System.Console.WriteLine("5 - Salir");


            System.Console.WriteLine("Ingrese una opcion:");
            int.TryParse(Console.ReadLine(), out opcion);
            switch(opcion)
            {
                case 1:
                    System.Console.WriteLine("----------Carga Del Cliente----------");
                    System.Console.WriteLine("Ingrese el nombre del cliente:");
                    string nombre = Console.ReadLine();
                    System.Console.WriteLine("Ingrese la direccion del cliente:");
                    string direccion = Console.ReadLine();
                    System.Console.WriteLine("Ingrese el numero del cliente(sin codigo de area):");
                    string telefono = Console.ReadLine();
                    System.Console.WriteLine("Ingrese algun dato de referencia de la direccion:");
                    string DRD = Console.ReadLine();
                    System.Console.WriteLine("-------------------------------------");
                    pedido = new Pedidos(nombre, direccion, telefono, DRD);
                    break;
                case 2:
                    int nroCadete;
                    if(pedido != null)
                    {
                        cadeteria.MostrarCadetes();
                        System.Console.WriteLine("Ingrese el id del cadete que asignara el pedido:");
                        int.TryParse(Console.ReadLine(), out nroCadete);
                        cadeteria.ListadoCadetes[nroCadete].TomarPedido(pedido);
                        pedido = null;
                    }else
                    {
                        System.Console.WriteLine("No se dio de alta ningun pedido, no fue posible asignar");
                    }
                    break;
                case 3:
                    cadeteria.MostrarCadetes();
                    System.Console.WriteLine("Ingrese el nro de cadete del cual cambiara el estado del pedido:");
                    int.TryParse(Console.ReadLine(), out nroCadete);

                    Cadete cadete = cadeteria.ListadoCadetes[nroCadete-1]; 
                    cadete.MostrarPedidos();
                    
                    System.Console.WriteLine("Ingrese el nro del pedido a cambiar:");
                    int.TryParse(Console.ReadLine(), out int nroPedido);
                    pedido = cadete.ListadoPedidos.FirstOrDefault(p => p.Numero == nroPedido);
                    pedido.CambiarEstado();
                    break;
                case 4:
                   
                    break;
                    
            }
        }

        }
      
        

    }
}