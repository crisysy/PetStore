using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PetStore.Models
{
    public class Ingredient
    {
        [ScaffoldColumn(false)]
        public int IngredientID { get; set; }
        [Required, StringLength(30), Display(Name ="Ingredient Name")]
        public string Nume { get; set; }
        public int? CompozitieID { get; set; }
        public virtual Compozitie Compozitie { get; set; }
    }
}