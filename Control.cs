using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaCarros
{
    class carro
    {
        inicio a = new inicio();
        public string[] Vcar = new string[15];
        int i ;
        public void agregar(string placas, string marca, string modelo, string telefono, string año)
        {
            placas = a.placas;
            marca = a.marca;
            modelo = a.modelo;
            telefono = a.telefono;
            año = a.año;
            for(i=0; i<Vcar.Length; i++)
            {
                Vcar[i] = placas + marca + modelo + telefono + año;
            }
        }
        public void buscar()
        {
            
        }
        public void eliminar()
        {

        }
        public void insertar()
        {

        }
        public string listar()
        {
            string vec = "";
            for (int i = 0; i < Vcar.Length; i++)
            {
                vec += "[" + i + "] = " + Vcar[i] + Environment.NewLine;
            }
            return vec;
        }
    }
}
