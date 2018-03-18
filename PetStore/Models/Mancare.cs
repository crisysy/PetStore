using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PetStore.Models
{
    public class Mancare
    {
        [ScaffoldColumn(false)]
        public int MancareID { get; set; }
        [Required, StringLength(50), Display(Name ="Food title")]
        public string Denumire { get; set; }        
        public virtual Producator Producator { get; set; }
        public virtual Animal Animal { get; set; }
        public virtual Ambalaj Ambalaj { get; set; }
        public int? ProducatorID { get; set; }
        public int? AnimalID { get; set; }
        public int? AmbalajID { get; set; }
        [Required, Range(50.0, 10000.0)]
        public double Gramaj { get; set; }
        [Required, Range(0,200)]
        public int Stoc { get; set; }
        [Required, Range(0.50, 100.0)]
        public double PretAchizitie { get; set; }
        [Required, Range(1.50, 300.0)]
        public double PretVanzare { get; set; }
        [Required]
        public DateTime DataExpirare { get; set; }
        public string ImagePath { get; set; }
    }
}