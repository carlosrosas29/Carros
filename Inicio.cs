using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaCarros
{
    class inicio
    {
        public string placas;
        public string marca;
        public string modelo;
        public string telefono;
        public string año;
        public void add(string placas, string marca, string modelo, string telefono, string año)
        {
            inicio a = new inicio();
            this.placas = placas;
            this.marca = marca;
            this.modelo = modelo;
            this.telefono = telefono;
            this.año = año;
        }
        public string p
        {
            get { return placas; }
            set { placas = value; }
        }
        public string a
        {
            get { return año; }
            set { año = value; }
        }
        public string m
        {
            get { return marca; }
            set { marca = value; }
        }
        public string mo
        {
            get { return modelo; }
            set { modelo = value; }
        }
        public string t
        {
            get { return telefono; }
            set { telefono = value; }
        }
    }
}
