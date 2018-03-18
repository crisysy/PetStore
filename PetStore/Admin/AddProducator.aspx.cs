using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PetStore.Logic;
using PetStore.Models;

namespace PetStore.Admin
{
    public partial class AddProducator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string producerAction = Request.QueryString["ProducerAction"];
            if (producerAction == "add")
            {
                LabelAddStatus.Text = "Producator adaugat";
            }
            if (producerAction == "remove")
            {
                LabelRemoveStatus.Text = "Producator sters";
            }
        }
        protected void AddProducerButton_Click(Object sender, EventArgs e)
        {
            AddProducator producers = new AddProducator();
            bool addSuccess = producers.AddProducatori(AddNume.Text, AddAdresa.Text, AddTelefon.Text);
            if (addSuccess)
            {
                // Reload the page.
                string pageUrl = Request.Url.AbsoluteUri.Substring(0, Request.Url.AbsoluteUri.Count() - Request.Url.Query.Count());
                Response.Redirect(pageUrl + "?ProducerAction=add");
            }
            else
            {
                LabelAddStatus.Text = "Unable to add new product to database.";
            }          

        }        

        public IQueryable GetProducers()
        {
            var _db = new PetStore.Models.MancareContext();
            IQueryable query = _db.Producatori;
            return query;
        }
        protected void RemoveProducerButton_Click(object sender, EventArgs e)
        {
            using (var _db = new PetStore.Models.MancareContext())
            {
                int producerId = Convert.ToInt16(DropDownRemoveProducer.SelectedValue);
                var myItem = (from c in _db.Producatori where c.ProducatorID == producerId select c).FirstOrDefault();
                if (myItem != null)
                {
                    _db.Producatori.Remove(myItem);
                    _db.SaveChanges();

                    // Reload the page.
                    string pageUrl = Request.Url.AbsoluteUri.Substring(0, Request.Url.AbsoluteUri.Count() - Request.Url.Query.Count());
                    Response.Redirect(pageUrl + "?ProducerAction=remove");
                }
                else
                {
                    LabelRemoveStatus.Text = "Unable to locate product.";
                }
            }
        }
        private bool AddProducatori(string numeProducator, string adresaProducator, string telefonProducator)
        {
            var myProducator = new Producator();
            myProducator.Nume = numeProducator;
            myProducator.Adresa = adresaProducator;
            myProducator.Telefon = telefonProducator;
            using (MancareContext _db = new MancareContext())
            {
                _db.Producatori.Add(myProducator);
                _db.SaveChanges();
            }
            return true;
        }
    }
}