using EspacioCadeteria;

        

AccesoAdatos datos = new AccesoAdatos();
Cadeteria cadeteria = new Cadeteria();

datos.CargarCadetes("cadetes.csv", cadeteria);
datos.CargarCadeteria("cadeteria.csv", cadeteria);


int opcion = 2;
//Pedidos pedido = null;


while(opcion != 5)
{
    Console.WriteLine("1 - Dar de alta un pedido");
    Console.WriteLine("2 - Asignar pedido a un cadete");
    Console.WriteLine("3 - Cambiar estado de un pedido");
    Console.WriteLine("4 - Reasignar pedido a otro cadete");
    Console.WriteLine("5 - Salir");


    System.Console.WriteLine("Ingrese una opcion:");
    int.TryParse(Console.ReadLine(), out opcion);
    switch(opcion)
    {
        case 1:
            bool tarea = cadeteria.DarAltaPedido2(); 
            if (tarea)
            {
               Console.WriteLine("Pedido tomado con éxito!");
            }else
            {
                Console.WriteLine("No se pudo tomar el pedido");
             
            }
            break;
        case 2:
            // Console.WriteLine("Ingrese el nro del pedido:");
            // int.TryParse(Console.ReadLine(), out int nroPedido);

            // bool asignado = cadeteria.AsignarPedidoACadete(nroPedido);
            // if (asignado)
            // {
            //     Console.WriteLine("Pedido asignado con éxito!");
            // }else
            // {
            //     Console.WriteLine("No se pudo asignar el pedido");
            // }

            
            break;
        case 3:
            Console.WriteLine("Ingrese el nro del pedido a cambiar:");
            int.TryParse(Console.ReadLine(), out int nropedido);
            
            cadeteria.CambiarEstadoPedido(nropedido);
            
            
            
            break;
        case 4:
            Console.WriteLine("Ingrese el id del cadete original:");
            int.TryParse(Console.ReadLine(), out int cadeteAnterior);
            Console.WriteLine("Ingrese el nro del pedido :");
            int.TryParse(Console.ReadLine(), out int npedido);
            Console.WriteLine("Ingrese el id del nuevo cadete:");
            int.TryParse(Console.ReadLine(), out int cadeteNuevo);

            cadeteria.ReasignarCadete(cadeteAnterior, npedido, cadeteNuevo);

            break;
            
    }
}






