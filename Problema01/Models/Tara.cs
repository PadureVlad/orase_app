using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema01.Models
{
    public class Tara
    {
        [Key]
        public int CodTara { get; set; }
        [Required]
        public string? Denumire { get; set; }
        [Required]
        public string? Continent { get; set; }
    }
}
