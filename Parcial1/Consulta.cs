using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entidades;
using BLL;
using DAL;

namespace Parcial1
{
    public partial class Consulta : Form
    {
        public Consulta()
        {
            InitializeComponent();
        }

        List<Clientes> lista = new List<Clientes>();

        private void buscarBtn_Click(object sender, EventArgs e)
        {
            if (FiltrocomboBox.SelectedIndex == 0)
             lista = ClientesBLL.GetLista(filtroTextBox.Text);
            if (FiltrocomboBox.SelectedIndex == 1)
                lista = ClientesBLL.GetLista(Utilidades.StringToInt(filtroTextBox.Text));
            if(String.IsNullOrEmpty(filtroTextBox.Text))
            {
                lista = ClientesBLL.GetLista();
            }
                
            DatosdataGridView.DataSource = lista;
        }

    }
}
