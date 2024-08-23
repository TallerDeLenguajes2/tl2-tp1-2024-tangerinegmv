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
        private Cliente cliente;

        public Pedidos(string nombre, string direccion, int tel, string DRD)//esto se hace asi porque la consigna no nos pide una lista de clientes, sino que cuando llega un pedido nace un cliente, y cuando se cancela o despacha un pedido el cliente se va, por eso no  creo un clientte antes, sino directamente en la clase pedidos
        {
            this.cliente = new Cliente(){
                Nombre = nombre,
                Telefono = tel,
                Direccion = direccion,
                DatosReferenciaDireccion = DRD
            };
            
        }

        public int Numero { get ; set ; }//se puede hacer esto y no haría falta la linea 3
        public Estados Estado { get; set; }
    }

    public class Cliente
    {
        private string nombre;
        private string direccion;
        private int telefono;
        public string DatosReferenciaDireccion;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public int Telefono { get => telefono; set => telefono = value; }
    }

    public class Cadete 
    {
        public int Id {get; set;}
        public string Nombre {get; set;}
        public string Direccion {get; set;}
        public int Telefono {get; set;}
        public List<Pedidos> ListadoPedidos { get; set;} 
    }

    public class Cadeteria
    {
        public string Nombre {get; set;}
        public int Telefono { get; set;}
        public List<Cadete> ListadoCadetes { get; set;}
    }

//verdireccion que sea un metodo que devuelva un string 
    
    //en cadete hago el constructor cadete(){new list PEdido}
}//en cadete metodo agregarpedido y quitarpedido
//en constructor crear Constructor en clase pedidos de Clientes cliente, con parametros los campos de cliente