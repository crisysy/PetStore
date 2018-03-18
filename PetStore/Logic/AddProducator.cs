using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PetStore.Models;

namespace PetStore.Logic
{
    public class AddProducator
    {
        public bool AddProducatori(string numeProducator, string adresaProducator, string telefonProducator)
        {
            var myProducator = new Producator();
            myProducator.Nume = numeProducator;
            myProducator.Adresa = adresaProducator;
            myProducator.Telefon = telefonProducator;
            using (MancareContext _db = new MancareContext())
            {
                _db.Producatori.Add(myProducator);
                _db.SaveChanges();
            }
            return true;
        }
    }
}