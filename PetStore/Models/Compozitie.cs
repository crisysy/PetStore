using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PetStore.Models
{
    public class Compozitie
    {
        [ScaffoldColumn(false)]
        public int CompozitieID { get; set; }
        public int? MancareID { get; set; }
        public virtual Mancare Mancare { get; set; }
        public virtual ICollection<Ingredient> Ingrediente { get; set; }
    }
}