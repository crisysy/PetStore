using PetStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PetStore.Admin
{
    public partial class StocProd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public IQueryable StocRedus()
        {
            var _db = new PetStore.Models.MancareContext();
            IQueryable<Mancare> query = _db.Mancaruri;
            query = from mancare in _db.Mancaruri
                    where mancare.Stoc < 5
                    select mancare;
            return query;
        }
    }
}