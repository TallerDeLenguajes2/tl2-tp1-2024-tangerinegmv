
//using EspacioCadete;
using System.Data.SqlTypes;
using System.Security.Principal;

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
        private double comision = 500;
        private List<Pedidos> listadopedidos;
        private List<Cadete> listadocadetes;
  
        public string Nombre { get => nombre; set => nombre = value; }
        public int Telefono { get => telefono; set => telefono = value; }
       // public List<Cadete> ListadoCadetes { get => listadocadetes; set => listadocadetes = value; }

        public Cadeteria()
        {
            this.listadocadetes = new List<Cadete>();
            this. listadopedidos  = new List<Pedidos>();
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
            Pedidos pedidoElegido = listadopedidos.FirstOrDefault(p => p.Numero == nroPedido);
            pedidoElegido.CambiarEstado();
        }    
        
        public void DarAltaPedido2()
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
            Random random = new Random();
            int randomId = random.Next(1,listadocadetes.Count);
           
        }


        // public bool AsignarPedidoACadete(int nropedido)
        // {
           
        //     Console.WriteLine("Ingrese el id del cadete al que le asignará el pedido:");
        //     int.TryParse(Console.ReadLine(), out int idCadete);

        //     Cadete cadeteElegido = listadocadetes.FirstOrDefault(cadete => cadete.Id == idCadete);
        //     if (cadeteElegido != null)
        //     {
        //         return cadeteElegido.TomarPedido(nropedido);
               
        //     }else
        //     {
        //         return false;
        //     }
            
        // }

         public bool ReasignarCadete(int npedido, int cadNuevo)
        {
           bool tarea = AsignarCadeteAPedido(cadNuevo, npedido);
           Pedidos pedido = listadopedidos.FirstOrDefault(p => p.Numero == npedido);
           Cadete cadete = listadocadetes.FirstOrDefault(c => c.Id == cadNuevo);
           if (pedido.Cadete == cadete)
           {
                return true;
           }else{
            return false;
           }

        }

        public double JornalACobrar(int id)
        {
            Cadete cadeteElegido = listadocadetes.FirstOrDefault(c => c.Id == id);
            var pedidosElegidos = from p in listadopedidos
                                    where p.Cadete == cadeteElegido && p.Estado == Estados.completo
                                    select p;
            return pedidosElegidos.Count()*comision;

        }

        public bool  AsignarCadeteAPedido(int idCadete, int nroPedido)
        {
            Pedidos pedidoElegido = listadopedidos.FirstOrDefault(p => p.Numero == nroPedido);
            Cadete cadeteElegido = listadocadetes.FirstOrDefault(c => c.Id == idCadete);
            pedidoElegido.Cadete = cadeteElegido;
            if (pedidoElegido.Cadete != null)
            {
                return true;
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