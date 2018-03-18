using PetStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetStore.Logic
{
    public class AddAnimal
    {
        public bool AddAnimale(string numeAnimal, string varstaAnimal)
        {
            var myAnimal = new Animal();
            myAnimal.Nume = numeAnimal;
            myAnimal.Varsta = varstaAnimal;
            using (MancareContext _db = new MancareContext())
            {
                _db.Animale.Add(myAnimal);
                _db.SaveChanges();
            }
            return true;
        }
    }
}