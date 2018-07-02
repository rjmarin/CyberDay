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
        Data data = Data.Deserialize_Product("dato.bin");

        public Form1()
        {
            InitializeComponent();

        }


        private void button_buscar_Click(object sender, EventArgs e)
        {
            
            Data.Serialize_Product("dato.bin", data);
            
        }

        private void text_buscador_TextChanged(object sender, EventArgs e)
        {
            listbuscador.Items.Clear();
            if (text_buscador.Text.Length >2)
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
    }
}
