using PetStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PetStore
{
    public partial class AddFilters : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public IQueryable FilterProducator()
        {
            var _db = new PetStore.Models.MancareContext();
            IQueryable query = _db.Producatori;
            return query;
        }
        public IQueryable FilterAmbalaj()
        {
            var _db = new PetStore.Models.MancareContext();
            IQueryable query = _db.Ambalaje;
            return query;
        }
        
        
        protected void ApplyFiltersButtonButton_Click(Object sender, EventArgs e)
        {
            int prodId = Convert.ToInt32(DropDownFilterProducator.SelectedValue);
            int ambaId = Convert.ToInt32(DropDownFilterAmbalaj.SelectedValue);
            string numeAnimal = AddNumeAnimal.Text;
            string varstaAnimal = AddVarstaAnimal.Text;
            Response.Redirect(String.Format("FilteredProducts.aspx?productID={0}&ambalajID={1}&numeAnimal={2}&varstaAnimal={3}", prodId, ambaId, numeAnimal, varstaAnimal));
        }
        //"MancareDetails.aspx?mancareID=<%#:Item.MancareID%>"
        
    }
}