
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
       
        public void CambiarEstadoPedido(int nroPedido)
        {
           Pedidos pedidoElegido = listadopedidos.FirstOrDefault(p => p.Numero == nroPedido);
           pedidoElegido.CambiarEstado();
        }    
        
        public bool DarAltaPedido(string nombre, string direccion, string telefono, string DRD)
        {
        
            Pedidos pedido = new Pedidos(nombre, direccion, telefono, DRD); 
            listadopedidos.Add(pedido);
            
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
