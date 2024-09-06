using EspacioCadeteria;
using EspacioCliente;
using EspacioPedidos;
namespace EspacioCadete
{
     public class Cadete 
    {
        public int Id {get; set;}
        public string Nombre {get; set;}
        public string Direccion {get; set;}
        public string Telefono {get; set;}
        public List<Pedidos> ListadoPedidos { get; set;} 
        public Cadete()
        {
            new List<Pedidos>();
        }

        public List<Pedidos> TomarPedido(Pedidos pedido)
        {
            ListadoPedidos.Add(pedido);
            return ListadoPedidos;
        }
        public List<Pedidos> QuitarPedido(Pedidos pedido)
        {
            ListadoPedidos.Remove(pedido);
            return ListadoPedidos;
        }

        

        public void MostrarPedidos()
    {
        foreach(Pedidos pedido in ListadoPedidos)
        {
            pedido.MostrarPedido();
        }
    }
    }
}