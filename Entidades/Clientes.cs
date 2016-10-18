using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Entidades
{
    public class Clientes
    {
        [Key]

        public int ClienteId { get; set; }
        public string Nombres { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int LimiteCredito { get; set; }
    }
}
