using PetStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetStore.Logic
{
    public class AddMancare
    {
        public bool AddMancaruri(string denumireMancare, int producatorIDMancare, int AnimalIDMancare, int ambalajIDMancare, 
            double gramajMancare, int stocMancare, double pretAchizitiemancare, double pretVanzareMancare, DateTime dataExpirareMancare,string imagineMancare)
        {
            var myMancare = new Mancare();
            myMancare.Denumire = denumireMancare;
            myMancare.ProducatorID = producatorIDMancare;
            myMancare.AnimalID = AnimalIDMancare;
            myMancare.AmbalajID = ambalajIDMancare;
            myMancare.Gramaj = gramajMancare;
            myMancare.Stoc = stocMancare;
            myMancare.PretAchizitie = pretAchizitiemancare;
            myMancare.PretVanzare = pretVanzareMancare;
            myMancare.DataExpirare = dataExpirareMancare;
            myMancare.ImagePath = imagineMancare;
            using (MancareContext _db = new MancareContext())
            {
                _db.Mancaruri.Add(myMancare);
                _db.SaveChanges();
            }
            return true;
        }
    }
}