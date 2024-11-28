using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminSchool.Funciones
{
    class ImgUpdate
    {
        string RutaImg;
        static string Folder = "/Imágenes";

        public ImgUpdate(string _RutaImg)
        {
            RutaImg = _RutaImg;
        }

        public bool GuardarImg()
        {
            try
            {
                string Nombre = Path.GetFileName(RutaImg);
                if(!Directory.Exists(Folder))
                {
                    Directory.CreateDirectory(Folder);
                }
                File.Copy(RutaImg, Folder + "/" + Nombre);
                return true;

            }

            catch (Exception ex)
            {
                Console.Write(ex.ToString());
                return false;
            }
        }

        public bool DeleteImg()
        {
            File.Delete(Folder + "/" + RutaImg);
            return true;
        }

    }
}
