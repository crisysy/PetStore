using PetStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PetStore.Admin
{
    public partial class AddIngredient : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string ingredientAction = Request.QueryString["IngredientAction"];
            if (ingredientAction == "add")
            {
                LabelAddStatus.Text = "Ingredient adaugat!";
            }
            if (ingredientAction == "remove")
            {
                LabelRemoveStatus.Text = "Ingredient sters!";
            }
        }
        protected void AddIngredientButton_Click(Object sender, EventArgs e)
        {
            AddIngredient ingredient = new AddIngredient();
            bool addSuccess = ingredient.AddIngrediente(AddNume.Text, DropDownAddCompozitieID.SelectedValue);
            if (addSuccess)
            {
                // Reload the page.
                string pageUrl = Request.Url.AbsoluteUri.Substring(0, Request.Url.AbsoluteUri.Count() - Request.Url.Query.Count());
                Response.Redirect(pageUrl + "?IngredientAction=add");
            }
            else
            {
                LabelAddStatus.Text = "Unable to add new product to database.";
            }

        }
        private bool AddIngrediente(string nume, string compId)
        {
            var myIngredient = new Ingredient();
            myIngredient.Nume = nume;
            myIngredient.CompozitieID = Convert.ToInt32(compId);
            using (MancareContext _db = new MancareContext())
            {
                _db.Ingrediente.Add(myIngredient);
                _db.SaveChanges();
            }
            return true;
        }
        public IQueryable GetCompozitie()
        {
            var _db = new PetStore.Models.MancareContext();
            IQueryable query = _db.Compozitii;
            return query;
        }
        public IQueryable GetIngredient()
        {
            var _db = new PetStore.Models.MancareContext();
            IQueryable query = _db.Ingrediente;
            return query;
        }
        protected void RemoveIngredientButtonButton_Click(object sender, EventArgs e)
        {
            using (var _db = new PetStore.Models.MancareContext())
            {
                int ingredientId = Convert.ToInt16(DropDownRemoveIngredient.SelectedValue);
                var myItem = (from c in _db.Ingrediente where c.IngredientID == ingredientId select c).FirstOrDefault();
                if (myItem != null)
                {
                    _db.Ingrediente.Remove(myItem);
                    _db.SaveChanges();

                    // Reload the page.
                    string pageUrl = Request.Url.AbsoluteUri.Substring(0, Request.Url.AbsoluteUri.Count() - Request.Url.Query.Count());
                    Response.Redirect(pageUrl + "?IngredientAction=remove");
                }
                else
                {
                    LabelRemoveStatus.Text = "Unable to locate product.";
                }
            }
        }
    }
}