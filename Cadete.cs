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
        public int Telefono {get; set;}
        public List<Pedidos> ListadoPedidos { get; set;} 
        public Cadete()
        {
            new List<Pedidos>();
        }

        public List<Pedidos> tomarPedido(Pedidos pedido)
        {
            ListadoPedidos.Add(pedido);
            return ListadoPedidos;
        }
        public List<Pedidos> quitarPedido(Pedidos pedido)
        {
            ListadoPedidos.Remove(pedido);
            return ListadoPedidos;
        }
    }
}