

namespace EspacioCadeteria
{
     public class Cadete 
    {
        //private List<Pedidos> listadopedidos;
        private int id;
        private string nombre;
        private string direccion;
        private string telefono;
        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }

        
        // public Cadete()
        // {
        //    listadopedidos= new List<Pedidos>();
        // }

        
        // public void QuitarPedido(int nropedido)
        // {   

        //     //con linq
        //     var pedidoElegido = from pedido in listadopedidos
        //                         where pedido.Numero == nropedido 
        //                         select pedido;
        //     foreach (Pedidos pedido in pedidoElegido)
        //     {
        //         listadopedidos.Remove(pedido);
        //     }

            
        // }

        

        

        
    }
}