using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PetStore.Models
{
    public class Animal
    {
        [ScaffoldColumn(false)]
        public int AnimalID { get; set; }
        [Required, StringLength(50),Display(Name ="Animal Type")]
        public string Nume { get; set; }
        [Required, StringLength(20), Display(Name ="Age Level")]
        public string Varsta { get; set; }
    }
}