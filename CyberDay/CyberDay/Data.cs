using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace CyberDay
{
    class Data
    {
        public List<Producto> productos = new List<Producto>();
        public List<Producto> descuentos = new List<Producto>();
        public List<Usuario> usuarios = new List<Usuario>();
        public List<Tienda> tiendas = new List<Tienda>();


        public Data()
        {
            this.Fill();
        }
        void Fill()
        {
            Random random = new Random();
            List<string> nombres = new List<string>();
            List<string> apellidos = new List<string>();
            List<string> direccions = new List<string>();
            List<string> descripcions = new List<string>();
            List<String> nombre_p = new List<string>();
            List<string> nom_weed = new List<string>();
            List<string> nom_sem = new List<string>();
            List<string> marca = new List<string>();

            Tienda t = new Tienda("Psico-activo");
            tiendas.Add(t);
            Tienda t1 = new Tienda("bola8");
            tiendas.Add(t1);
            Tienda t2 = new Tienda("peter´s grows");
            tiendas.Add(t2);
            Tienda t3 = new Tienda("grow shop420");
            tiendas.Add(t3);
            Tienda t4 = new Tienda("LA PERNA");
            tiendas.Add(t4);
            marca.Add("kali krusher");
            marca.Add("de la China");
            marca.Add("bulldog");
            marca.Add("peacemaker");
            marca.Add("Chill");
            marca.Add("Supreme");
            marca.Add("Ignite");

            nombre_p.Add("moledor");
            nombre_p.Add("bong");
            nombre_p.Add("bong");
            nombre_p.Add("pipa");
            nombre_p.Add("bucket");
            nombre_p.Add("papelillos");
            nombre_p.Add("tips");
            nombre_p.Add("quimicos");
            nombre_p.Add("fertilizante");
            nombres.Add("jaime");
            nombres.Add("peter");
            nombres.Add("rai");
            nombres.Add("hugo");
            nombres.Add("tomas");
            nombres.Add("sergio");
            nombres.Add("camila");
            nombres.Add("andrea");
            apellidos.Add("marin");
            apellidos.Add("de la fuente");
            apellidos.Add("marcahnt");
            apellidos.Add("olivares");
            apellidos.Add("fuchs");
            apellidos.Add("grand");
            direccions.Add("basel");
            descripcions.Add("mala");
            descripcions.Add("buena");
            descripcions.Add("super mala");
            descripcions.Add("super buena");
            descripcions.Add("piola");
            descripcions.Add("pa chuparse los mocos");
            descripcions.Add("un manjar de dios");
            nom_weed.Add("barley");
            nom_sem.Add("S.hare Hordeum leporinum");
            nom_weed.Add("barnyardgrass");
            nom_sem.Add("S.Echinochloa crus - galli");
            nom_weed.Add("bermudagrass");
            nom_sem.Add("S.Cynodon dactylon");
            nom_weed.Add("bindweed");
            nom_sem.Add("S.Convolvulus arvensis");
            nom_weed.Add("skunk");
            nom_sem.Add("S. skunk");
            nom_weed.Add("superskunk");
            nom_sem.Add("S. superskunk");
            nom_weed.Add("orange kush");
            nom_sem.Add("S. orange kush");
            nom_weed.Add("white widow");
            nom_sem.Add("S. white widow");
            nom_weed.Add("moby dick");
            nom_sem.Add("S. moby dick");
            nom_weed.Add("kritical diesel");
            nom_sem.Add("S. kritical diesel");
            nom_weed.Add("og kush");
            nom_sem.Add("S. og kush");
            nom_weed.Add("purple kush");
            nom_sem.Add("S. purple kush");
            nom_weed.Add("pinaple express");
            nom_sem.Add("S. pinaple express");
            nom_weed.Add("og rocket");
            nom_sem.Add("S. og rocket");
            nom_weed.Add("lemon haze");
            nom_sem.Add("S. lemon haze");
            nom_weed.Add("amnesia");
            nom_sem.Add("S. amnesia");
            nom_weed.Add("crystal coma");
            nom_sem.Add("S. crystal coma");
            nom_weed.Add("east coast sour diesel");
            nom_sem.Add("S. east coast sour diesel");
            nom_weed.Add("green candy");
            nom_sem.Add("S. green candy");

            int c = 0;

            for (int i = 0; i < 100; i++)
            {
                int np = random.Next(nombre_p.Count-1);
                int mc = random.Next(marca.Count-1);
                int ds = random.Next(descripcions.Count-1);
                int ns = random.Next(nom_sem.Count-1);
                c += 1;
                int stock = random.Next(50);
                int precio = random.Next(50000);

                Producto p = new Producto(nombre_p[np], descripcions[ds], marca[mc], precio, stock, c);
                productos.Add(p);

            }
            for (int i = 0; i < 100; i++)
            {
                int ds = random.Next(descripcions.Count-1);
                int ns = random.Next(nom_sem.Count-1);
                c += 1;
                int stock = random.Next(50);
                int precio = random.Next(3, 15);

                Producto p = new Producto(nom_sem[ns], descripcions[ds], "", precio * 1000, stock, c);
                productos.Add(p);

            }
            for (int i = 0; i < 50; i++)
            {
                string nombre = "";
                int ds = random.Next(descripcions.Count-1);
                int ns = random.Next(nombres.Count-1);
                nombre += nombres[ns];
                int ap = random.Next(apellidos.Count-1);
                nombre += " ";
                nombre += apellidos[ap];
                c += 1;
                int saldo = random.Next(150000000);
                Usuario x = new Usuario(nombre,apellidos[ap], "", c, saldo);
                usuarios.Add(x);

            }

           
            for (int i = 0; i < productos.Count; i++ )
            {
                foreach (Tienda item in tiendas)
                {
                    if (i<productos.Count)
                    {
                        item.productos.Add(productos[i]);
                        i++;
                    }
                    else
                    {
                        break;
                    }
                   
                }
            }

            foreach (Tienda item in tiendas)
            {
                int r = random.Next(70);
                for (int i = 0; i < 50; i++)
                {
                    int rr = random.Next(70);
                    int q =random.Next(33);
                    int new_precio = item.productos[q].precio *(rr / 100);
                    item.productos[q].precio -= new_precio;
                    descuentos.Add(item.productos[q]);
                    item.ofertas.Add(item.productos[q]);
                    
                }
               
            }
            








        }

        public static void Serialize_Product(string file_name, Data lista)
        {
            string file = @"..\..\" + file_name;
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, file);
                using (Stream stream = File.Open(path, FileMode.Create))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, lista);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        public static Data Deserialize_Product(string file_name)
        {
            Data output;
            string file = @"..\..\" + file_name;
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, file);
                using (Stream stream = File.Open(path, FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();

                    output = (Data)bin.Deserialize(stream);
                }
                return output;
            }
            catch (Exception e)
            {
                output = new Data();
                return output;
            }

        }
    }
}
