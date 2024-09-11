using EspacioCadeteria;

        

AccesoAdatos datos = new AccesoAdatos();
Cadeteria cadeteria = new Cadeteria();

datos.CargarCadetes("cadetes.csv", cadeteria);
datos.CargarCadeteria("cadeteria.csv", cadeteria);


int opcion = 2;
//Pedidos pedido = null;

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
            cadeteria.DarAltaPedido1(); //este quita el pedido 
            //cadeteria.DarAltaPedido2(); //este agrega un pedido a un cadete
            break;
        case 2:
            Console.WriteLine("Ingrese el nro del pedido:");
            int.TryParse(Console.ReadLine(), out int nroPedido);

            bool asignado = cadeteria.AsignarPedidoACadete(nroPedido);
            if (asignado)
            {
                Console.WriteLine("Pedido asignado con éxito!");
            }else
            {
                Console.WriteLine("No se pudo asignar el pedido");
            }

            
            break;
        case 3:
            System.Console.WriteLine("Ingrese el nro del pedido a cambiar:");
            int.TryParse(Console.ReadLine(), out int nropedido);
            
            cadeteria.CambiarEstadoPedido(nropedido);
            
            
            
            break;
        case 4:
            
            break;
            
    }
}






