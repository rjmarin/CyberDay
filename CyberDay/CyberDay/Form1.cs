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

    public partial class Form1 : Form
    {
        Data data = new Data();
        List<Producto> Out_Productos = new List<Producto>();

        public Form1()
        {
            InitializeComponent();
            panel_user.Visible = true;
            panel_wishlist.Visible = false;

            panel_user.Location = new Point(0, 0);
            foreach (string item in data.nombre_p)
            {
                combo_categoria.Items.Add(item);
            }
            Data.Serialize_Product("data.txt", data);
        }


        private void button_buscar_Click(object sender, EventArgs e)
        {
            
            Data.Serialize_Product("data.bin", data);
            
        }

        private void text_buscador_TextChanged(object sender, EventArgs e)
        {
            Out_Productos.Clear();
            listbuscador.Items.Clear();
            if (text_buscador.Text.Length > 2)
            {
                foreach (Producto item in data.productos)
                {
                    
                    if(item.Infi().Contains(text_buscador.Text))
                    {
                        listbuscador.Items.Add(item.Infi());
                    }
                    
                }
                foreach (Tienda item in data.tiendas)
                {
                    if (item.Infi().Contains(text_buscador.Text))
                    {
                        listbuscador.Items.Add(item.Infi());
                    }
                }
            }
        }

        private void listbuscador_SelectedIndexChanged(object sender, EventArgs e)
        {
            text_info.Text = "";
            foreach (Producto item in data.productos)
            {
                if (listbuscador.SelectedItem.ToString() == item.Infi())
                {
                    text_info.Text = item.Info();
                }
            }
            foreach (Tienda item in data.tiendas)
            {
                if (listbuscador.SelectedItem.ToString() == item.Infi())
                {
                    text_info.Text = item.Info();
                }
            }


        }

        private void listbuscador_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listbuscador.Items.Clear();
            IEnumerable<Producto> output = data.productos.Where(item => item.Infi().Contains(text_buscador.Text));
            if (text_buscador.Text == "")
            {

            }
            else
            {
                foreach (Producto item in output)
                {
                    listbuscador.Items.Add(item.Infi());
                }
            }
        }

        private void LogIn_Click(object sender, EventArgs e)
        {
            foreach (Usuario persona in data.usuarios)
            {
                if (text_user.Text == persona.ID().ToString() && text_clave.Text == persona.Clave())
                {
                    panel_user.Visible = false;
                    label_bienvenida.Text += "Bienvenido " + persona.Info();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Register a = new Register();
            a.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel_wishlist.Visible = true;
            box_lista_deseos.Items.Clear();
            foreach (Usuario i in data.usuarios)
            {
                if (label_bienvenida.Text == "Bienvenido " + i.Info())
                {
                    foreach (Producto item in i.lista_de_deseos)
                    {

                        box_lista_deseos.Items.Add(item.Infi());
                    }


                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (Usuario i in data.usuarios)
            {
                if (label_bienvenida.Text == "Bienvenido " + i.Info())
                {

                    foreach (Producto it in data.productos)
                    {
                        if (listbuscador.SelectedItem.ToString() == it.Infi())
                        {
                            MessageBox.Show(it.Infi());
                            i.lista_de_deseos.Add(it);
                        }
                    }

                }
            }
        }

        private void button_salir_Click(object sender, EventArgs e)
        {
            panel_wishlist.Visible = false;
        }

        private void box_lista_deseos_SelectedIndexChanged(object sender, EventArgs e)
        {
            info_lista_deseos.Text = "";
            foreach (Producto item in data.productos)
            {
                if (box_lista_deseos.SelectedItem.ToString() == item.Infi())
                {
                    info_lista_deseos.Text = item.Info();
                }
            }
        }
    }
}
