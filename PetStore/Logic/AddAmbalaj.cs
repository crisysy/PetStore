using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PetStore.Models;

namespace PetStore.Logic
{
    public class AddAmbalaj
    {
        public bool AddAmbalaje(string tipAmbalaj)
        {
            var myAmbalaj = new Ambalaj();
            myAmbalaj.Tip = tipAmbalaj;           
            using (MancareContext _db = new MancareContext())
            {
                _db.Ambalaje.Add(myAmbalaj);
                _db.SaveChanges();
            }
            return true;
        }
    }
}