using EspacioCliente;
using EspacioCadeteria;
namespace EspacioPedidos
{
    public class Pedidos
    {
        //private int numero;
        public string obs;
        private Cliente cliente;

        public Pedidos(string nombre, string direccion, int tel, string DRD)//esto se hace asi porque la consigna no nos pide una lista de clientes, sino que cuando llega un pedido nace un cliente, y cuando se cancela o despacha un pedido el cliente se va, por eso no  creo un clientte antes, sino directamente en la clase pedidos
        {
            cliente = new Cliente(){
                Nombre = nombre,
                Telefono = tel,
                Direccion = direccion,
                DatosReferenciaDireccion = DRD
            };
            
        }

        public int Numero { get ; set ; }//se puede hacer esto y no haría falta la linea 3
        public Estados Estado { get; set; }

        public string VerDireccionCliente()
        {
            return cliente.Direccion;
        }

        public void VerDatoscliente()
        {
            Console.WriteLine(cliente.Nombre);
            Console.WriteLine(cliente.Direccion);
            Console.WriteLine(cliente.Telefono);
            Console.WriteLine(cliente.DatosReferenciaDireccion);
        }

    }
}