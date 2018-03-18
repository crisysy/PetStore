using PetStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PetStore.Admin
{
    public partial class StocPerProducator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public IQueryable<Producator> StocPerProducatorGrid_GetData()
        {
            MancareContext db = new MancareContext();
            var query = db.Producatori.Include(p => p.Mancare);
            return query;
        }
    }
}