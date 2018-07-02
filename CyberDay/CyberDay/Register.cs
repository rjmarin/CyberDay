using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CyberDay
{
    public partial class Register : Form
    {
        Data data = Data.Deserialize_Product("data.bin");
        public Register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool hay_error = false;
            string nombre = text_nombre.Text;
            string apellido = text_apellido.Text;
            string mail = text_correo.Text;
            string clave = text_clave.Text;
            int id = data.last_user_id + 1;
            try
            {
                Usuario nuevo = new Usuario(nombre + " " +apellido, mail, clave, id, 0);
            }
            catch ( Exception exc)
            {

                MessageBox.Show("Register failed" + exc.Message, "Error");
                hay_error = true;

            }
            if (!hay_error)
            {
                Usuario nuevo = new Usuario(nombre + " " + apellido, mail, clave, id, 0);
                data.usuarios.Add(nuevo);
                Data.Serialize_Product("data.bin", data);
                MessageBox.Show("Registration complete\nId number: " + id);
                this.Close();
            }

        }
    }
}
