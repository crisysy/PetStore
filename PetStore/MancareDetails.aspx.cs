using PetStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PetStore
{
    public partial class MancareDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<Mancare> GetMancare([QueryString("mancareID")] int? mancareId)
        {
            var _db = new PetStore.Models.MancareContext();
            IQueryable<Mancare> query = _db.Mancaruri;
            if (mancareId.HasValue && mancareId > 0)
            {
                query = query.Where(p => p.MancareID == mancareId);
            }
            else
            {
                query = null;
            }
            return query;
        }
        public IQueryable<Ambalaj> GetAmbalaj([QueryString("mancareID")] int? mancareId)
        {
            var _db = new PetStore.Models.MancareContext();
            IQueryable<Ambalaj> query = _db.Ambalaje;
            if (mancareId.HasValue && mancareId > 0)
            {
                query = from ambalaj in _db.Ambalaje
                        join mancare in _db.Mancaruri on ambalaj.AmbalajID equals mancare.AmbalajID
                        where ((ambalaj.AmbalajID == mancare.AmbalajID)&&(mancare.MancareID==mancareId))
                        select ambalaj;
            }
            else
            {
                query = null;
            }
            return query;
        }
        public IQueryable<Animal> GetAnimal([QueryString("mancareID")] int? mancareId)
        {
            var _db = new PetStore.Models.MancareContext();
            IQueryable<Animal> query = _db.Animale;
            if (mancareId.HasValue && mancareId > 0)
            {
                query = from animal in _db.Animale
                        join mancare in _db.Mancaruri on animal.AnimalID equals mancare.AnimalID
                        where ((animal.AnimalID == mancare.AnimalID)&&(mancare.MancareID==mancareId))
                        select animal;
            }
            else
            {
                query = null;
            }
            return query;
        }
        public IQueryable<Producator> GetProducatorDetails([QueryString("mancareID")] int? mancareId)
        {
            var _db = new PetStore.Models.MancareContext();
            IQueryable<Producator> query = _db.Producatori;
            if (mancareId.HasValue && mancareId > 0)
            {
                query = from producator in _db.Producatori
                        join mancare in _db.Mancaruri on producator.ProducatorID equals mancare.ProducatorID
                        where ((producator.ProducatorID == mancare.ProducatorID) &&mancare.MancareID==mancareId)
                        select producator;
            }
            else
            {
                query = null;
            }
            return query;
        }
        public IQueryable<Ingredient> GetIngrediente([QueryString("mancareID")] int? mancareId)
        {
            var _db = new PetStore.Models.MancareContext();
            IQueryable<Ingredient> query = _db.Ingrediente;
            if (mancareId.HasValue && mancareId > 0)
            {
                query = from ingrediente in _db.Ingrediente
                        from compozitie in _db.Compozitii
                        from mancare in _db.Mancaruri
                        where ((compozitie.MancareID == mancare.MancareID) && (ingrediente.CompozitieID == compozitie.CompozitieID)&&(mancare.MancareID==mancareId))
                        select ingrediente;
            }
            else
            {
                query = null;
            }
            return query;
        }
    }
    
}