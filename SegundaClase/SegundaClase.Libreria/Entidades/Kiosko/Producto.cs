using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundaClase.Libreria.Entidades.Kiosko
{
    public class Producto
    {
        // atributos o variables de clase
        // mod acceso en atributo por defecto es privado
        private  double precioCosto;
        private  double precioVenta;
        private  double volumen;
        private string nombre;

        //los atributos se acceden mediante propiedades

        //como se hace una propiedad
        //[modificador de acceso] --> quién puede acceder hasta ahí. contiene tipo y nombre
        // dentro de la propiedad hacemos el acceso de lectura y el de escritura
        public string PrecioVenta //tener en cuenta caseSensitive, no es lo mismo que precioVenta de linea 14
        {
            // acá estamos encapsulando, hacemos privado el atributo pero permitimos utilizarlo con PrecioVenta
            get //acceso de lectura
            {
                return "$ " + this.precioVenta.ToString();
            }
            set //acceso de escritura. el valor que me dan lo chequeo y  puedo asignárselo a la variable.
            {
                this.precioVenta = Convert.ToDouble(value);
            }

        }

        public double Volumen
        {
            get
            {
                return this.volumen;
            }
            set
            {
                this.volumen = value;
            }
        }



    }
}
