using PetStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PetStore
{
    public partial class AddFilterIngredient : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        public IQueryable FilterIngredient()
        {
            var _db = new PetStore.Models.MancareContext();
            IQueryable query = _db.Ingrediente;
            return query;
        }

        protected void ApplyFiltersIngredientButton_Click(Object sender, EventArgs e)
        {
            int ingredientId = Convert.ToInt32(DropDownFilterIngredient.SelectedValue);
            MancareContext _db = new MancareContext();
            int? CompozitieId = (from ingredient in _db.Ingrediente
                               where ingredient.IngredientID == ingredientId
                               select ingredient.CompozitieID).Single();
            Response.Redirect(String.Format("FilteredByIngredient.aspx?ingredientId={0}&CompozitieId={1}", ingredientId, CompozitieId));
        }
    }
}