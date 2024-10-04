
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
        private List<Pedidos> listadopedidos;
  
        public string Nombre { get => nombre; set => nombre = value; }
        public int Telefono { get => telefono; set => telefono = value; }

        public Cadeteria()
        {
            this.listadocadetes =new List<Cadete>();
            this.listadopedidos = new List<Pedidos>();
        }
        public void AgregarCadetes(Cadete cadete)
        {
            this.listadocadetes.Add(cadete);
        }

        public float JornalACobrar(int id)
        {
            float jornal = 0;
            foreach (Pedidos p in listadopedidos)
            {
                if (p.Cadete.Id == id)
                {

                    if (p.Estado == Estados.completo)
                    {
                        jornal = jornal + 500 ;
                    }
                }
            }
            return jornal;
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
           Pedidos pedidoElegido = listadopedidos.FirstOrDefault(p => p.Numero == nroPedido);
           pedidoElegido.CambiarEstado();
        }    
        
        public bool DarAltaPedido()
        {
        
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
            listadopedidos.Add(pedido);
            // Random random = new Random();
            // int randomId = random.Next(1,listadocadetes.Count);
            // Cadete cadeteElegido = listadocadetes.FirstOrDefault(cadete => cadete.Id == 1);
            // bool tarea = cadeteElegido.TomarPedido(pedido);
            return true;
           
        }


        public bool AsignarCadeteAPedido(int nropedido, int idCadete)
        { 
            Cadete cadeteElegido = listadocadetes.FirstOrDefault(cadete => cadete.Id == idCadete);
            Pedidos pedidoElegido = listadopedidos.FirstOrDefault(p => p.Numero == nropedido);
            if (pedidoElegido != null && listadopedidos.Contains(pedidoElegido))
            {
               if (cadeteElegido != null && listadocadetes.Contains(cadeteElegido))
               {
                 pedidoElegido.TomarPedido(cadeteElegido);
                 return true;
               }else
               {
                return false;
               }
               
            }else
            {
                return false;
            }
            
        }

        

        public void ReasignarCadete(int cadAnt, int nroPedido, int cadNuevo)
        {
            Cadete cadAnterior = listadocadetes.FirstOrDefault(c => c.Id == cadAnt);
            Cadete cadeteNuevo = listadocadetes.FirstOrDefault(c => c.Id == cadNuevo);
            if (listadocadetes.Contains(cadeteNuevo))
            {
                bool tarea = AsignarCadeteAPedido(nroPedido, cadNuevo);
               
            }

        }
    }
}
