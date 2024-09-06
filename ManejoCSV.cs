using EspacioCadete;
using EspacioCadeteria;
namespace EspacioCSV
{
    class AccesoAdatos
    {
        public static bool ExisteArchivo(string path)
        {
            FileInfo file = new FileInfo(path); //crep un objeto archivo y path es la ruta donde esta el archivo
            if(file.Exists && file.Length > 0)
            {
                return true;
            }else
            {
                return false;
            }
        }

        public void CargarCadetes(string path, Cadeteria cadeteria)
        {
            if(ExisteArchivo(path))
            {
                StreamReader x = new StreamReader(path); //Levanto el archivo csv
                string lineas= x.ReadLine(); //en esta linea se lee una linea de un arhivo, y comienzo con la primera linea del csv
                while(lineas != null)//Con el while voy iterando linea por linea hasta que llegue a una vacia
                {
                    Cadete cadete = new Cadete();
                    string [] campos = lineas.Split(','); //lineas.Split(',') devuelve un arreglo cuyos campos son cada elemento entre comas
                    int.TryParse(campos[0], out int id);
                    cadete.Id = id;
                    cadete.Nombre = campos[1];
                    cadete.Direccion = campos[2];
                    cadete.Telefono = campos[3];
                    cadeteria.AgregarCadetes(cadete);
                    lineas = x.ReadLine();
                }
            }
        }

        public void CargarCadeteria(string path, Cadeteria cadeteria)
        {
            if(ExisteArchivo(path))
            {
            StreamReader x = new StreamReader(path); //Levanto el archivo csv
            string lineas= x.ReadLine(); //en esta linea se lee una linea de un arhivo, y comienzo con la primera linea del csv
                string [] campos = lineas.Split(','); //lineas.Split(',') devuelve un arreglo cuyos campos son cada elemento entre comas
                cadeteria.Nombre = campos[0];
                int.TryParse(campos[1], out int telefono);
                cadeteria.Telefono = telefono;
            }
        }

        public void ObtenerDatosCadete(string path)
        {
            Cadete cadete = new Cadete();
            if(ExisteArchivo(path))
            {
                StreamReader x = new StreamReader(path); //Levanto el archivo csv
                string lineas = x.ReadLine(); //en esta linea se lee una linea de un arhivo, y comienzo con la primera linea del csv
                while(lineas != null)//Con el while voy iterando linea por linea hasta que llegue a una vacia
                {
                lineas = x.ReadLine();
                string [] campos = lineas.Split(','); //lineas.Split(',') devuelve un arreglo cuyos campos son cada elemento entre comas
                }
            }
        }


    }
}