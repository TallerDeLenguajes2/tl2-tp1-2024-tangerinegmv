

namespace EspacioCadeteria
{
     public class Cadete 
    {
        private List<Pedidos> listadopedidos;
        private int id;
        private string nombre;
        private string direccion;
        private string telefono;
        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }

        
        public Cadete()
        {
           listadopedidos= new List<Pedidos>();
        }

        public bool TomarPedido(int nropedido)
        {
            Pedidos pedidoElegido = listadopedidos.FirstOrDefault(pedido => pedido.Numero == nropedido);
            if(pedidoElegido != null)
            {
              listadopedidos.Add(pedidoElegido);
              return true;
            }else
            {
                return false;
            }
            
        }
        public void QuitarPedido(int nropedido)
        {   
         //con linq
            var pedidoElegido = from pedido in listadopedidos
                                where pedido.Numero == nropedido 
                                select pedido;
            foreach (Pedidos pedido in pedidoElegido)
            {
                listadopedidos.Remove(pedido);
            }

            
            
        }

        public void CambiaEstadoPedido(int nroPedido)
        {
            //Pedidos pedido=listadopedidos.FirstOrDefault(p => p.Numero == nroPedido);
            var pedidoElegido = from pedido in listadopedidos
                                where pedido.Numero == nroPedido 
                                select pedido;
            foreach (Pedidos pedido in pedidoElegido)
            {
                pedido.CambiarEstado();
            }

        }

        public void MostrarPedidos()
        {
            foreach(Pedidos pedido in listadopedidos)
            {
                pedido.MostrarPedido();
            }
        }
        public Pedidos ReasignarCadete(int nroPedido )
        {
            Pedidos pedidoElegido = listadopedidos.FirstOrDefault(p => p.Numero == nroPedido);
            return pedidoElegido;

        }
    }
}