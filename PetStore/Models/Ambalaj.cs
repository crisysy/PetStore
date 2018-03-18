using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PetStore.Models
{
    public class Ambalaj
    {
        [ScaffoldColumn(false)]
        public int AmbalajID { get; set; }
        [Required, StringLength(50), Display(Name ="Package Type")]
        public string Tip { get; set; }
    }
}