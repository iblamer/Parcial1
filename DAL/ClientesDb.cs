using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using Entidades;

namespace DAL
{
    public class ClientesDb : DbContext
    {
        public ClientesDb() : base("name = ConStr")
        {
                
        }

        public virtual DbSet<Clientes> Cliente { get; set; }
    }
}
