using PetStore.Models;
using System;
using System.Linq;

namespace PetStore.Admin
{
    public partial class AddMancare : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string mancareAction = Request.QueryString["MancareAction"];
            if (mancareAction == "add")
            {
                LabelAddStatus.Text = "Mancare added!";
            }
            if (mancareAction == "remove")
            {
                LabelRemoveStatus.Text = "Mancare removed!";
            }
        }
        protected void AddMancareButton_Click(object sender, EventArgs e)
        {
            Boolean fileOK = false;
            String path = Server.MapPath("~/Content/");
            if (AddImagePath.HasFile)
            {
                String fileExtension = System.IO.Path.GetExtension(AddImagePath.FileName).ToLower();
                String[] allowedExtensions = { ".gif", ".png", ".jpeg", ".jpg" };
                for (int i = 0; i < allowedExtensions.Length; i++)
                {
                    if (fileExtension == allowedExtensions[i])
                    {
                        fileOK = true;
                    }
                }
            }
            if (fileOK)
            {
                try
                {
                    // Save to Images folder.
                    AddImagePath.PostedFile.SaveAs(path + AddImagePath.FileName);
                    // Save to Images/Thumbs folder.
                    AddImagePath.PostedFile.SaveAs(path + "Thumbs/" + AddImagePath.FileName);
                }
                catch (Exception ex)
                {
                    LabelAddStatus.Text = ex.Message;
                }

                // Add product data to DB.
                AddMancare mancare = new AddMancare();
                bool addSuccess = mancare.AddMancaruri(AddDenumire.Text, DropDownAddProducator.SelectedValue,
                    AddNumeAnimal.Text, AddVarstaAnimal.Text,
                    DropDownAddAmbalaj.SelectedValue, AddGramaj.Text, AddStoc.Text, AddPretAchizitie.Text,
                    AddPretVanzare.Text, AddDataExpirare.Text, AddImagePath.FileName);
                if (addSuccess)
                {
                    // Reload the page.
                    string pageUrl = Request.Url.AbsoluteUri.Substring(0, Request.Url.AbsoluteUri.Count() - Request.Url.Query.Count());
                    Response.Redirect(pageUrl + "?MancareAction=add");
                }
                else
                {
                    LabelAddStatus.Text = "Unable to add new food to database.";
                }
            }
            else
            {
                LabelAddStatus.Text = "Unable to accept file type.";
            }
        }
        public IQueryable GetProducator()
        {
            var _db = new PetStore.Models.MancareContext();
            IQueryable query = _db.Producatori;
            return query;
        }        
        public IQueryable GetAmbalaj()
        {
            var _db = new PetStore.Models.MancareContext();
            IQueryable query = _db.Ambalaje;
            return query;
        }
        public IQueryable GetMancare()
        {
            var _db = new PetStore.Models.MancareContext();
            IQueryable query = _db.Mancaruri;
            return query;
        }
        protected void RemoveMancareButton_Click(object sender, EventArgs e)
        {
            using (var _db = new PetStore.Models.MancareContext())
            {
                int mancareId = Convert.ToInt16(DropDownRemoveMancare.SelectedValue);
                var myItem = (from c in _db.Mancaruri where c.MancareID == mancareId select c).FirstOrDefault();
                if (myItem != null)
                {
                    _db.Mancaruri.Remove(myItem);
                    _db.SaveChanges();

                    // Reload the page.
                    string pageUrl = Request.Url.AbsoluteUri.Substring(0, Request.Url.AbsoluteUri.Count() - Request.Url.Query.Count());
                    Response.Redirect(pageUrl + "?MancareAction=remove");
                }
                else
                {
                    LabelRemoveStatus.Text = "Unable to locate product.";
                }
            }
        }
        private bool AddMancaruri(string denumireMancare, string producatorIDMancare, string AnimalNume,string AnimalVarsta, string ambalajIDMancare,
            string gramajMancare, string stocMancare, string pretAchizitiemancare, string pretVanzareMancare, string dataExpirareMancare, string imagineMancare)
        {
            MancareContext _db = new MancareContext();
            var myMancare = new Mancare();
            myMancare.Denumire = denumireMancare;
            myMancare.ProducatorID = Convert.ToInt32(producatorIDMancare);
            myMancare.AnimalID = Convert.ToInt32((from animal in _db.Animale
                                                 where ((animal.Nume == AnimalNume) && (animal.Varsta == AnimalVarsta))
                                                 select animal.AnimalID).SingleOrDefault());               
            myMancare.AmbalajID = Convert.ToInt32(ambalajIDMancare);
            myMancare.Gramaj = Convert.ToDouble(gramajMancare);
            myMancare.Stoc = Convert.ToInt32(stocMancare);
            myMancare.PretAchizitie = Convert.ToDouble(pretAchizitiemancare);
            myMancare.PretVanzare = Convert.ToDouble(pretVanzareMancare);
            myMancare.DataExpirare = Convert.ToDateTime(dataExpirareMancare);
            myMancare.ImagePath = imagineMancare;
            using (_db)
            {
                _db.Mancaruri.Add(myMancare);
                NewMethod(_db);
            }
            return true;
        }

        private static void NewMethod(MancareContext _db)
        {
            _db.SaveChanges();
        }
    }
}
