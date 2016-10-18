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
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void guardarBtn_Click(object sender, EventArgs e)
        {
            Clientes cliente = new Clientes();

            llenarClases(cliente);

            if(ClientesBLL.Insertar(cliente))
            {
                MessageBox.Show("Se a guardado el cliente");
            }
            
        }

        public void llenarClases(Clientes cliente)
        {
            cliente.Nombres = NombretextBox.Text;
            cliente.FechaNacimiento = DateTime.Parse(FechamaskedTextBox.Text);
            cliente.LimiteCredito = int.Parse(LimitetextBox.Text);
        }

        private void NombretextBox_TextChanged( object sender, EventArgs e)
        {

        }

        public bool Search()
        {
            if (ClientesBLL.Buscar(Utilidades.StringToInt(IdtextBox.Text)) == null)
            {
                MessageBox.Show("Id no existe");
                return false;
            }
            else
            {
                return true;
            }
        }


        private void eliminarBtn_Click(object sender, EventArgs e)
        {
            if (Search())
            {
                ClientesBLL.Eliminar(Utilidades.StringToInt(IdtextBox.Text));
                MessageBox.Show("Se elimino el ciente");
            }
            else
            {
                MessageBox.Show("El id no existe");
                    
            }
        }

        private void buscarBtn_Click(object sender, EventArgs e)
        {
            if(Search())
            {
                Fill(ClientesBLL.Buscar(Utilidades.StringToInt(IdtextBox.Text)));
            }
        }

        private void Fill(Clientes cliente)
        {
            NombretextBox.Text = cliente.Nombres;
            FechamaskedTextBox.Text = cliente.FechaNacimiento.ToString();
            LimitetextBox.Text = cliente.LimiteCredito.ToString(); 
        }

        private void ConsultalinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Consulta c = new Consulta();
            c.Show();
        }

        private void modificarBtn_Click(object sender, EventArgs e)
        {
            Clientes cliente = new Clientes();
            cliente.Nombres = NombretextBox.Text;
            cliente.LimiteCredito = int.Parse(LimitetextBox.Text);
            cliente.FechaNacimiento = Convert.ToDateTime(FechamaskedTextBox.Text);

            ClientesBLL.Update(Utilidades.StringToInt(IdtextBox.Text), cliente);

            MessageBox.Show("Se a actualizado el usuario");
        }
    }
}
