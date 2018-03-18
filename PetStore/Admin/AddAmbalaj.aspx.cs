using PetStore.Models;
using System;
using System.Linq;

namespace PetStore.Admin
{
    public partial class AddAmbalaj : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string ambalajAction = Request.QueryString["AmbalajAction"];
            if (ambalajAction == "add")
            {
                LabelAddStatus.Text = "Ambalaj adaugat";
            }
            if (ambalajAction == "remove")
            {
                LabelRemoveStatus.Text = "Ambalaj sters";
            }
        }
        protected void AddAmbalajButton_Click(Object sender, EventArgs e)
        {
            AddAmbalaj ambalaj = new AddAmbalaj();
            bool addSuccess = ambalaj.AddAmbalaje(AddTip.Text);
            if (addSuccess)
            {
                // Reload the page.
                string pageUrl = Request.Url.AbsoluteUri.Substring(0, Request.Url.AbsoluteUri.Count() - Request.Url.Query.Count());
                Response.Redirect(pageUrl + "?AmbalajAction=add");
            }
            else
            {
                LabelAddStatus.Text = "Unable to add new product to database.";
            }


        }
        public IQueryable GetAmbalaj()
        {
            var _db = new PetStore.Models.MancareContext();
            IQueryable query = _db.Ambalaje;
            return query;
        }
        protected void RemoveAmbalajButton_Click(object sender, EventArgs e)
        {
            using (var _db = new PetStore.Models.MancareContext())
            {
                int ambalajId = Convert.ToInt16(DropDownRemoveAmbalaj.SelectedValue);
                var myItem = (from c in _db.Ambalaje where c.AmbalajID == ambalajId select c).FirstOrDefault();
                if (myItem != null)
                {
                    _db.Ambalaje.Remove(myItem);
                    _db.SaveChanges();

                    // Reload the page.
                    string pageUrl = Request.Url.AbsoluteUri.Substring(0, Request.Url.AbsoluteUri.Count() - Request.Url.Query.Count());
                    Response.Redirect(pageUrl + "?AmbalajAction=remove");
                }
                else
                {
                    LabelRemoveStatus.Text = "Unable to locate product.";
                }
            }
        }

        private bool AddAmbalaje(string tipAmbalaj)
        {
            var myAmbalaj = new Ambalaj();
            myAmbalaj.Tip = tipAmbalaj;           
            using (MancareContext _db = new MancareContext())
            {
                _db.Ambalaje.Add(myAmbalaj);
                _db.SaveChanges();
            }
            return true;
        }
    }
}