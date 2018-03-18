using PetStore.Models;
using System;
using System.Linq;
using System.Data.Entity.Infrastructure;
using System.Data.Entity;

namespace PetStore.Admin
{
    public partial class GridViewMancare : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public IQueryable<Mancare> MancareGrid_GetData()
        {
            MancareContext db = new MancareContext();
            var query = db.Mancaruri;
            return query;
        }

        // The id parameter name should match the DataKeyNames value set on the control
        public void MancareGrid_UpdateItem(int mancareID)
        {
            using (MancareContext db = new MancareContext())
            {
                Mancare item = null;
                item = db.Mancaruri.Find(mancareID);
                if (item == null)
                {
                    ModelState.AddModelError("",
                      String.Format("Item with id {0} was not found", mancareID));
                    return;
                }
                TryUpdateModel(item);
                if (ModelState.IsValid)
                {
                    db.SaveChanges();
                }
            }
        }

        // The id parameter name should match the DataKeyNames value set on the control
        
    }
}