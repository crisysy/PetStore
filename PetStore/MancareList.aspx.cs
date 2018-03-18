using PetStore.Models;
using System;
using System.Linq;
using System.Web.ModelBinding;

namespace PetStore
{
    public partial class MancareList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void AddFiltersIngredienteButton_Click(Object sender, EventArgs e)
        {
            Response.Redirect("AddFilterIngredient.aspx");
        }


        public IQueryable<Mancare> GetMancaruri([QueryString("id")] int? producatorId)
        {
            var _db = new PetStore.Models.MancareContext();
            IQueryable<Mancare> query = _db.Mancaruri;
            if (producatorId.HasValue && producatorId > 0)
            {
                query = query.Where(p => p.ProducatorID == producatorId);
            }
            return query;
        }
        public void AddFiltersButton_Click(Object sender, EventArgs e)
        {
            Response.Redirect("AddFilters.aspx");
        }
    }
}