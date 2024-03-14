using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema01.Models
{
    public class Oras
    {
        [Key]
        public int CodOras { get; set; }
        [Required]
        public string? Denumire { get; set; }
        [Required]
        public int NrLocuitori { get; set; }
        [Required]
        [ForeignKey("CodTara")]
        public int CodTara { get; set; }
        public virtual Tara? Tara { get; set; }
    }
}
