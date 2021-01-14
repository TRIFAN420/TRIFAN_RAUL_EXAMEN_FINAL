using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TRIFAN_RAUL_EXAMEN_FINAL.Models
{
    public class Restaurant
    {
        public int ID { get; set; }
       
        public string Preparat { get; set; }
        public string Descriere { get; set; }
        public string Gramaj { get; set; }
        [Column(TypeName = "decimal(6, 2)")]
        public decimal Pret { get; set; }
    }
}