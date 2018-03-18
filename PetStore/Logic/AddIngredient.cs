using PetStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetStore.Logic
{
    public class AddIngredient
    {
        public bool AddAIngrediente(string nume, int compozitieId)
        {
            var myIngredient = new Ingredient();
            myIngredient.Nume = nume;
            myIngredient.CompozitieID = compozitieId;
            using (MancareContext _db = new MancareContext())
            {
                _db.Ingrediente.Add(myIngredient);
                _db.SaveChanges();
            }
            return true;
        }
    }
}