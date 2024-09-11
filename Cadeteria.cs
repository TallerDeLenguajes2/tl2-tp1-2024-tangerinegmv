
//using EspacioCadete;
namespace EspacioCadeteria
//comando Split para archivo csv
{
    public enum Estados
    {
        completo,
        enCurso
    }
   

    public class Cadeteria
    {
        private string nombre;
        private int telefono;
      
        private List<Cadete> listadocadetes;
  
        public string Nombre { get => nombre; set => nombre = value; }
        public int Telefono { get => telefono; set => telefono = value; }
       // public List<Cadete> ListadoCadetes { get => listadocadetes; set => listadocadetes = value; }

        public Cadeteria()
        {
            this.listadocadetes =new List<Cadete>();
        }
        public void AgregarCadetes(Cadete cadete)
        {
            this.listadocadetes.Add(cadete);
        }

         public void MostrarCadetes()
        {
           Console.WriteLine("Cadetes:");
            foreach(Cadete cadete in listadocadetes)
            {
               Console.WriteLine($"Cadete {cadete.Id}\nNombre: {cadete.Nombre}\nTelefono: {cadete.Telefono}");
            }
        }
        public void CambiarEstadoPedido(int nroPedido)
        {
            foreach(Cadete cadete in listadocadetes)
            {
                
               cadete.CambiaEstadoPedido(nroPedido);
              
            }
        }    
        public void DarAltaPedido1()
        {
            
           Console.WriteLine("Ingrese el nro del pedido:");
            int.TryParse(Console.ReadLine(), out int nropedido);

            foreach(Cadete cadete in listadocadetes)
            {
               cadete.QuitarPedido(nropedido);
            }

          
        }
        public void DarAltaPedido2()
        {
            
            Console.WriteLine("Ingrese el nro del pedido:");
            int.TryParse(Console.ReadLine(), out int nropedido);

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
            Pedidos pedido = new Pedidos(nombre, direccion, telefono, DRD); 
            Random random = new Random();
            int randomId = random.Next(1,listadocadetes.Count);
            Cadete cadeteElegido = listadocadetes.FirstOrDefault(cadete => cadete.Id == randomId);
            bool tarea = cadeteElegido.TomarPedido(pedido.Numero);
           
        }


        public bool AsignarPedidoACadete(int nropedido)
        {
           
            Console.WriteLine("Ingrese el id del cadete al que le asignará el pedido:");
            int.TryParse(Console.ReadLine(), out int idCadete);

            Cadete cadeteElegido = listadocadetes.FirstOrDefault(cadete => cadete.Id == idCadete);
            if (cadeteElegido != null)
            {
                return cadeteElegido.TomarPedido(nropedido);
               
            }else
            {
                return false;
            }
            
        }
    }

//verdireccion que sea un metodo que devuelva un string 
    
    //en cadete hago el constructor cadete(){new list PEdido}
}//en cadete metodo agregarpedido y quitarpedido
//en constructor crear Constructor en clase pedidos de Clientes cliente, con parametros los campos de cliente