using EspacioCadeteria;

        

//AccesoAdatos datos = new AccesoAdatos();
Cadeteria cadeteria = new Cadeteria();

Console.WriteLine("1 - Cargar CSV");
Console.WriteLine("2 - Cargar JSON");
Console.WriteLine("Ingrese una opcion:");
int.TryParse(Console.ReadLine(), out int eleccion);
if (eleccion == 1)
{
    AccesoCSV datos = new AccesoCSV();
    datos.CargarCadetes("cadetes.csv", cadeteria);
    datos.CargarCadeteria("cadeteria.csv", cadeteria);
}else
{
    AccesoJSON datos = new AccesoJSON();
    datos.CargarCadetes("cadetes.json", cadeteria);
    datos.CargarCadeteria("cadeteria.json", cadeteria);
}



int opcion = 2;
//Pedidos pedido = null;


while(opcion != 6)
{
    Console.WriteLine("1 - Dar de alta un pedido");
    Console.WriteLine("2 - Asignar cadete a un pedido");
    Console.WriteLine("3 - Cambiar estado de un pedido");
    Console.WriteLine("4 - Reasignar pedido a otro cadete");
    Console.WriteLine("5 - Calcular Jornal a cobrar");
    Console.WriteLine("6 - Salir");


    System.Console.WriteLine("Ingrese una opcion:");
    int.TryParse(Console.ReadLine(), out opcion);
    switch(opcion)
    {
        case 1:
            Console.WriteLine("----------Carga Del Cliente----------");
            Console.WriteLine("Ingrese el nombre del cliente:");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese la direccion del cliente:");
            string direccion = Console.ReadLine();
            Console.WriteLine("Ingrese el numero del cliente(sin codigo de area):");
            string telefono = Console.ReadLine();
            Console.WriteLine("Ingrese algun dato de referencia de la direccion:");
            string DRD = Console.ReadLine();
            Console.WriteLine("-------------------------------------");
            bool tarea = cadeteria.DarAltaPedido(nombre, direccion, telefono, DRD); 
            if (tarea)
            {
               Console.WriteLine("Pedido tomado con éxito!");
            }else
            {
                Console.WriteLine("No se pudo tomar el pedido");
             
            }
            break;
        case 2:
            Console.WriteLine("Ingrese el nro del pedido:");
            int.TryParse(Console.ReadLine(), out int nroPedido);

            Console.WriteLine("Ingrese el ID del cadete:");
            int.TryParse(Console.ReadLine(), out int idCadete);

            bool asignado = cadeteria.AsignarCadeteAPedido(nroPedido, idCadete);
            if (asignado)
            {
                Console.WriteLine("Pedido asignado con éxito!");
            }else
            {
                Console.WriteLine("No se pudo asignar el pedido");
            }

            
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
        case 5:
             Console.WriteLine("Ingrese el id del cadete:");
            int.TryParse(Console.ReadLine(), out int idCad);
            float jornal = cadeteria.JornalACobrar(idCad);
            Console.WriteLine("Jornal a cobrar del cadete es: $ "+ jornal);
            break;

    }
}




