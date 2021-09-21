using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Entities
{
    public class Usuarios
    {
        [Key]
        public int usuId { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
    }
}
