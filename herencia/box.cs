using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HERENCIA
{
    class box:rectangle
    {
        //clase hija
        public int height { get; set; }


        public string heigh()
        {
            return "La altura del rectangulo es:" + height;
        }


        //metodo de formula sobre volumen
        public string volumen()
        {
            var volumen = 0;
            volumen = length * widht * height;

            return "Volumen: "+ volumen;
        }
    }
}
