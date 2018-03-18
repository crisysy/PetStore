using PetStore.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PetStore.Admin
{
    public partial class MaxStocProd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public IQueryable MaxStocProducator()
        {
            var context = new MancareContext();
            //IQueryable<Producator> producatori = context.Producatori;
            //IQueryable<Mancare> mancare = context.Mancaruri;
            IDictionary<int, int> producators = new Dictionary<int, int>();   
            
            foreach(var p in context.Producatori)
            {
                int stocPerProducer = 0;
                foreach(var m in context.Mancaruri)
                {
                    if (p.ProducatorID == m.ProducatorID)
                    {
                        stocPerProducer += m.Stoc;
                    }
                }
                producators.Add(p.ProducatorID, stocPerProducer);
            }
            var res = producators.OrderByDescending(i => i.Value);
            var pID = res.First();
            IQueryable<Producator> maxStocProducator = from pr in context.Producatori
                                                       where pr.ProducatorID == pID.Key
                                                 select pr;
            return maxStocProducator;
        }
    }
}