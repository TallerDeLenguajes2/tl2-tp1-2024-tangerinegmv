using EspacioCadeteria;
namespace EspacioCliente
{
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
}