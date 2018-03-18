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
    public partial class StocPerProducer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public IQueryable<Compozitie> CompozitieGrid_GetData()
        {
            MancareContext db = new MancareContext();
            var query = db.Compozitii.Include(s=>s.Ingrediente);
            return query;
        }
    }
}