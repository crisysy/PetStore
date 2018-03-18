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
    public partial class FilteredByIngredient : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public IQueryable<Mancare> GetMancaruri([QueryString("ingredientId")] int? ingredientId, [QueryString("CompozitieId")] int? CompozitieId)
        {
            var _db = new PetStore.Models.MancareContext();
            IQueryable<Mancare> query = _db.Mancaruri;
            if (ingredientId.HasValue && CompozitieId.HasValue )
            {
                query = from mancare in _db.Mancaruri
                        join compozitie in _db.Compozitii on mancare.MancareID equals compozitie.MancareID
                        where ((compozitie.CompozitieID == CompozitieId) && (mancare.MancareID == compozitie.MancareID))
                        select mancare;

            }
            else
            {
                query = null;
            }
            return query;
        }
    }
}