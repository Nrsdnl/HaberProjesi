using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HaberFinder.Entities
{
    public class Haber
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [StringLength(50)]
        public string haberbasligi { get; set; }

        [StringLength(250)]
        public string habericerigi { get; set; }
    }
}
