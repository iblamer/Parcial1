using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using DAL;

namespace BLL
{
    public class ClientesBLL
    {
        public static bool Insertar(Clientes cliente)
        {
            bool retorno = false;
            try
            {
                var db = new ClientesDb();

                db.Cliente.Add(cliente);
                db.SaveChanges();

                retorno = true;
            }
            catch(Exception)
            {
                throw;
            }

            return retorno;
        }

        public static Clientes Buscar(int id)
        {
            var db = new ClientesDb();

            return db.Cliente.Find(id);
        }

        public static void Eliminar (int id)
        {
            var db = new ClientesDb();
            Clientes c = (from cliente in db.Cliente
                          where id == cliente.ClienteId
                          select cliente).FirstOrDefault();
            db.Cliente.Remove(c);
            db.SaveChanges();
        }

        public static List<Clientes> GetLista()
        {
            List<Clientes> lista = new List<Clientes>();
            var db = new ClientesDb();

            lista = db.Cliente.ToList();

            return lista;
        }

        public static void Update(int id, Clientes cliente)
        {
            var db = new ClientesDb();

            Clientes c = db.Cliente.Find(id);

            c.Nombres = cliente.Nombres;
            c.FechaNacimiento = cliente.FechaNacimiento;
            c.LimiteCredito = cliente.LimiteCredito;

            db.SaveChanges();
        }

        public static List<Clientes> GetLista(int id)
        {
            List<Clientes> lista = new List<Clientes>();
            var db = new ClientesDb();

            lista = db.Cliente.Where(l => l.ClienteId == id).ToList();

            return lista;
        }

        public static List<Clientes> GetLista(string nombre)
        {
            List<Clientes> lista = new List<Clientes>();
            var db = new ClientesDb();

            lista = db.Cliente.Where(c => c.Nombres == nombre).ToList();

            return lista;
        }

        public static List<Clientes> GetLista (DateTime date)
        {
            List<Clientes> lista = new List<Clientes>();

            var db = new ClientesDb();

            return lista;
        }


    }
}
