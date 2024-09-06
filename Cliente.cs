using EspacioCadeteria;
namespace EspacioCliente
{
     public class Cliente
    {
        private string nombre;
        private string direccion;
        private string telefono;
        public string DatosReferenciaDireccion;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }

        
       
    }
}