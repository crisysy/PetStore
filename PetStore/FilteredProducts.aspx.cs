using PetStore.Models;
using System;
using System.Linq;
using System.Web.ModelBinding;

namespace PetStore
{
    public partial class FilteredProducts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public IQueryable<Mancare> GetMancaruri([QueryString("productID")] int? producatorId, [QueryString("ambalajID")] int? ambalajId, [QueryString("numeAnimal")] string numeAnimal, [QueryString("varstaAnimal")] string varstaAnimal)
        {            
            var _db = new PetStore.Models.MancareContext();
            int animalID = (from animal in _db.Animale
                                where ((animal.Nume == numeAnimal) && (animal.Varsta == varstaAnimal))
                                select animal.AnimalID).Single();
            
            IQueryable < Mancare > query = _db.Mancaruri;
            if (producatorId.HasValue && producatorId > 0 && ambalajId.HasValue && ambalajId>0 && numeAnimal.Length>0 && varstaAnimal.Length>0)
            {       
                    query = query.Where(p => p.ProducatorID == producatorId).Where(p => p.AmbalajID == ambalajId).Where(p => p.AnimalID == animalID);
            }            
            else
            {
                query = null;
            }
            return query;
        }
    }
}