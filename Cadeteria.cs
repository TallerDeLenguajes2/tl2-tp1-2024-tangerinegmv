
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
  
        public string Nombre { get => nombre; set => nombre = value; }
        public int Telefono { get => telefono; set => telefono = value; }
       // public List<Cadete> ListadoCadetes { get => listadocadetes; set => listadocadetes = value; }

        public Cadeteria()
        {
            this.listadocadetes =new List<Cadete>();
        }
        public void AgregarCadetes(Cadete cadete)
        {
            this.listadocadetes.Add(cadete);
        }

         public void MostrarCadetes()
        {
            System.Console.WriteLine("Cadetes:");
            foreach(Cadete cadete in listadocadetes)
            {
                System.Console.WriteLine($"Cadete {cadete.Id}\nNombre: {cadete.Nombre}\nTelefono: {cadete.Telefono}");
            }
        }
        public void CambiarEstadoPedido(int nroPedido)
        {
            foreach(Cadete cadete in listadocadetes)
            {
                
                bool resultado=cadete.CambiaEstadoPedido(nroPedido);
              
            }
        }    
        public void ReasignarPedido()
        {
            
        }
    }

//verdireccion que sea un metodo que devuelva un string 
    
    //en cadete hago el constructor cadete(){new list PEdido}
}//en cadete metodo agregarpedido y quitarpedido
//en constructor crear Constructor en clase pedidos de Clientes cliente, con parametros los campos de cliente