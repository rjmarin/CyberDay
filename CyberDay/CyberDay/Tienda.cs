using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberDay
{
    [Serializable]
    class Tienda : Information
    {
        string nombre;
        public List<Producto> productos = new List<Producto>();
        public List<Producto> ofertas = new List<Producto>();

        public Tienda(string nombre)
        {
            this.nombre = nombre;
        }

        public string Infi()
        {
            string s = "";
            s += "Nombre tienda: " + nombre;
            return s;
        }
        public string Info()
        {
            string s = "";
            s += "Tienda: " + nombre + "Productos Destacados" + Environment.NewLine;
            for (int i = 0; i < 5; i++)
            {
                s += ofertas[i].Infi();
                s += Environment.NewLine;
            }
            return s;
        }
    }

}
