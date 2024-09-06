using EspacioCadete;
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
        public string Nombre {get; set;}
        public int Telefono { get; set;}
        public List<Cadete> ListadoCadetes { get; set;}

        public void AgregarCadetes(Cadete cadete)
        {
            ListadoCadetes.Add(cadete);
        }

         public void MostrarCadetes()
    {
        System.Console.WriteLine("Cadetes:");
        foreach(Cadete cadete in ListadoCadetes)
        {
            System.Console.WriteLine($"Cadete {cadete.Id}\nNombre: {cadete.Nombre}\nTelefono: {cadete.Telefono}");
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