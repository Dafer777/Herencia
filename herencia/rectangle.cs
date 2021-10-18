using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HERENCIA
{
    class rectangle
    {

        //clase padre
        //propiedades
        public int length { get; set; }
        public int widht { get; set; }
        

        //asignar datos
        public string getLength()
        {
            
            return "El largo del rectangulo: " + length + ",El ancho del rectangulo es: " + widht;
        }

        public string Area()
        {
            var are = 0;
            are = length * widht;
            return "el area es: " + are;
        }




    }
}
