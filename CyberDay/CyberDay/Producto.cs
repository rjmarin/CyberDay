using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberDay
{
    
[Serializable]
    class Producto : Information
    {
        public string nombre;
        string descrip;
        string marca;
        public int precio;
        public int stock;
        public int ID;

        public Producto(string nombre, string descrip, string marca, int precio, int stock, int ID)
        {
            this.nombre = nombre;
            this.descrip = descrip;
            this.marca = marca;
            this.precio = precio;
            this.stock = stock;
            this.ID = ID;

        }

        public string Info()
        {
            string s = "";
            s += "nombre: " + nombre + Environment.NewLine + "descripcion: " + descrip + Environment.NewLine + "marca: " + marca + Environment.NewLine + "precio: $" + precio.ToString() + Environment.NewLine +"stock: " + stock;
            return s;
        }

        public string Infi()
        {
            string s = "";
            s += "nombre: " + nombre  + " | marca: " + marca + " | precio: $" + precio.ToString();
            return s;
        }
    }
}
