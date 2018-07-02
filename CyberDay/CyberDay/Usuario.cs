using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Windows.Forms;

namespace CyberDay
{
    [Serializable]
    class Usuario
    {
        string nombre;
        string mail;
        string clave;
        int Id;
        int saldo;
        List<Producto> lista_de_deseos = new List<Producto>();

        public Usuario(string nombre, string mail, string clave, int id, int saldo)
        {
            this.nombre = nombre;
            this.mail = mail;
            this.clave = clave;
            Id = id;
            this.saldo = saldo;
        }
        public string Clave()
        {
            return this.clave;
        }
        public int ID()
        {
            return this.Id;
        }

        public string Info()
        {
            return this.nombre + "Saldo: $" + this.saldo;
        }
        void comprar()
        {
            int suma = 0;
            foreach (Producto item in lista_de_deseos)
            {
                suma += item.precio;
            }
            if (saldo >= suma)
            {
                lista_de_deseos.Clear();
                saldo -= suma;
                MessageBox.Show("Compra realizada su saldo es de :" + saldo);
            }
            else{
                MessageBox.Show("hubo un error en la compra intente nuevamente");

            }
        }

    }
}
