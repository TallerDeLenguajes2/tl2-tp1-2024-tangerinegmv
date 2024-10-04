using System.Diagnostics.Contracts;
namespace EspacioCadeteria
{
    public class Pedidos
    {
         private static int contador = 0;
        public string obs;
        private Cliente cliente;
        private Cadete cadete;

        public Pedidos(string nombre, string direccion, string tel, string DRD)//esto se hace asi porque la consigna no nos pide una lista de clientes, sino que cuando llega un pedido nace un cliente, y cuando se cancela o despacha un pedido el cliente se va, por eso no  creo un clientte antes, sino directamente en la clase pedidos
        {
            cliente = new Cliente(){
                Nombre = nombre,
                Telefono = tel,
                Direccion = direccion,
                DatosReferenciaDireccion = DRD
            };
            Estado = Estados.enCurso;
            Numero = ++contador;
            
        }

        private int numero;
        private Estados estado;
        public int Numero { get => numero; set => numero = value; }
        public Estados Estado { get => estado; set => estado = value; }
        public Cadete Cadete { get => cadete; set => cadete = value; }

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
        public void MostrarPedido()
        {
            System.Console.WriteLine($"---------------------------\nPedido {Numero}\nEstado: {Estado}\nObservaciones: {obs}\n---------------------------");
        }
         
        public void CambiarEstado()
        {
           if (Estado == Estados.enCurso)
           {
             Estado = Estados.completo;
           }else
           {
            Estado = Estados.enCurso;
           }
           
        
           
        }

        public void TomarPedido(Cadete cadete)
        {
            Cadete = cadete;
        }

       

    }
}