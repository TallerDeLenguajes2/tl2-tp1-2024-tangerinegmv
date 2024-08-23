//comando Split para archivo csv
namespace EspacioCadeteria
{
    public enum Estados
    {
        
    }
    public class Pedidos
    {
        //private int numero;
        public string obs;
        private List<Cliente> clientes;

        public int Numero { get ; set ; }//se puede hacer esto y no haría falta la linea 3
        public List<Cliente> Clientes { get => clientes; set => clientes = value; }
        public Estados Estado { get; set; }
    }

    public class Cliente
    {
        private string nombre;
        private string direccion;
        private int telefono;
        
    }
    //en cadete hago el constructor cadete(){new list PEdido}
}//en cadete metodo agregarpedido y quitarpedido