

namespace EspacioCadeteria
{
     public class Cadete 
    {
        private List<Pedidos> listadopedidos;
        public int Id {get; set;}
        public string Nombre {get; set;}
        public string Direccion {get; set;}
        public string Telefono {get; set;}
        //public List<Pedidos> ListadoPedidos { get; set;} 
        public Cadete()
        {
           listadopedidos= new List<Pedidos>();
        }

        public void TomarPedido(Pedidos pedido)
        {
            listadopedidos.Add(pedido);
          //  return ListadoPedidos;
        }
        public void QuitarPedido(int nropedido)
        {   

            //esto se lo puede reemplazar con comandos linq
            foreach (Pedidos pedido in listadopedidos)
            {
                if (pedido.Numero==nropedido)
                    listadopedidos.Remove(pedido);
            
            }
            
            
        }

        public bool CambiaEstadoPedido(int nroPedido)
        {
            Pedidos pedido=listadopedidos.FirstOrDefault(p => p.Numero == nroPedido);
            pedido.CambiarEstado();
            if (pedido!=null)
            {
                return true;
            }
            return false;

        }

        public void MostrarPedidos()
    {
        foreach(Pedidos pedido in listadopedidos)
        {
            pedido.MostrarPedido();
        }
    }
    }
}