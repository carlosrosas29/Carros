using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TiendaCarros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        inicio a = new inicio();
        carro m = new carro();
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //agregar
            txtPlacas.Text = Convert.ToString(a.placas);
            txtMarca.Text = Convert.ToString(a.marca);
            txtModelo.Text = Convert.ToString(a.modelo);
            txtTelefono.Text = Convert.ToString(a.telefono);
            txtAño.Text = Convert.ToString(a.año);
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            txtMostrar.Text = Convert.ToString(m.listar());
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}
