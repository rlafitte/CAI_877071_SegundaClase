using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SegundaClase.Libreria.Entidades.Kiosko;  // <--------------------------
                                                                    //       |
                                                                    //       |
namespace SegundaClase.Consola                                      //       |
{                                                                   //       |
    class Program                                                   //       |
    {                                                               //       |
        static void Main(string[] args)                             //       |
        {                                                           //       |
            // como instanciar una clase y obtener un objeto        //       |
            //tipo de variable que va a contener esta instancia     //       |
            Producto nombreVariable = new Producto();   //para poder usarla >|

            nombreVariable.PrecioVenta = "40"; // cuando usamos igual llama al get

            Console.WriteLine(nombreVariable.PrecioVenta);


            //Modelar algún problema y tener un programa donde hagamos un set y un get.
            // 5 negocios distintos: veterinaria, restaurant, carta, deporte, almacén

        }
    }
}
