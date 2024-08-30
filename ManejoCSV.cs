using EspacioCadete;
namespace EspacioCSV
{
    class AccesoAdatos
    {
        public bool ExisteArchivo(string path)
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