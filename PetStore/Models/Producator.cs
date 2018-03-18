using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PetStore.Models
{
    public class Producator
    {
        [ScaffoldColumn(false)]
        public int ProducatorID { get; set; }
        [Required, StringLength(50), Display(Name ="Producer")]
        public string Nume { get; set; }
        [Required, StringLength(200), Display(Name ="Address")]
        public string Adresa { get; set; }
        [Required, StringLength(15), Display(Name ="Phone Number")]
        public string Telefon { get; set; }
        public virtual ICollection<Mancare> Mancare { get; set; }
    }
}