using PetStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PetStore.Admin
{
    public partial class AddAnimal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string animalAction = Request.QueryString["AnimalAction"];
            if (animalAction == "add")
            {
                LabelAddStatus.Text = "Animal adaugat!";
            }
            if (animalAction == "remove")
            {
                LabelRemoveStatus.Text = "Animal sters!";
            }
        }
        protected void AddAnimalButton_Click(object sender, EventArgs e)
        {
            // Add product data to DB.
            AddAnimal mancare = new AddAnimal();
            bool addSuccess = mancare.AddAnimale(AddNume.Text,AddVarsta.Text);
            if (addSuccess)
            {
                // Reload the page.
                string pageUrl = Request.Url.AbsoluteUri.Substring(0, Request.Url.AbsoluteUri.Count() - Request.Url.Query.Count());
                Response.Redirect(pageUrl + "?AnimalAction=add");
            }
            else
            {
                LabelAddStatus.Text = "Unable to add new animal to database.";
            }               
        }
        protected void RemoveAnimalButton_Click(object sender, EventArgs e)
        {
            using (var _db = new PetStore.Models.MancareContext())
            {
                string numeAnimal= StergeNumeAnimal.Text;
                string varstaAnimal = StergeVarstaAnimal.Text;
                var myItem = (from c in _db.Animale where ((c.Nume == numeAnimal)&&(c.Varsta==varstaAnimal)) select c).FirstOrDefault();
                if (myItem != null)
                {
                    _db.Animale.Remove(myItem);
                    _db.SaveChanges();

                    // Reload the page.
                    string pageUrl = Request.Url.AbsoluteUri.Substring(0, Request.Url.AbsoluteUri.Count() - Request.Url.Query.Count());
                    Response.Redirect(pageUrl + "?AnimalAction=remove");
                }
                else
                {
                    LabelRemoveStatus.Text = "Unable to locate animal.";
                }
            }
        }
        private bool AddAnimale(string nume, string varsta)
        {
            var myAnimal = new Animal();
            myAnimal.Nume = nume;
            myAnimal.Varsta = varsta;
            using (MancareContext _db = new MancareContext())
            {
                _db.Animale.Add(myAnimal);
                _db.SaveChanges();
            }
            return true;
        }

    }
}