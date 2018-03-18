using PetStore.Models;
using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;

namespace PetStore.Admin
{
    public partial class GridViewProducator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public IQueryable<Producator> ProducatorGrid_GetData()
        {
            MancareContext db = new MancareContext();
            var query = db.Producatori;
            return query;
        }

        // The id parameter name should match the DataKeyNames value set on the control
        public void ProducatorGrid_UpdateItem(int producatorID)
        {
            using (MancareContext db = new MancareContext())
            {
                Producator item = null;
                item = db.Producatori.Find(producatorID);
                if (item == null)
                {
                    ModelState.AddModelError("",
                      String.Format("Item with id {0} was not found", producatorID));
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