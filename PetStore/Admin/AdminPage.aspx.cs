using PetStore.Models;
using System;
using System.Data;
using System.Linq;

namespace PetStore.Admin
{
    public partial class AdminPage : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {            
           
        }
        //Actions
        protected void ApplyDiscountExpirationDateBtn_Click(Object sender, EventArgs e)
        {
            using (var context = new MancareContext())
            {
                var mancare = context.Mancaruri.SqlQuery("UPDATE dbo.Mancare SET PretVanzare=PretVanzare*0.9 WHERE MancareID IN (SELECT m.MancareID FROM dbo.Mancare m WHERE m.DataExpirare IN (SELECT TOP 2 m2.DataExpirare FROM dbo.Mancare m2 ORDER BY m2.DataExpirare))");
            }
            Response.Redirect("SuccessReducere.aspx");
        }
        protected void ApplyDiscountStocGrateranimalBtn_Click(Object sender, EventArgs e)
        {
            using (var context = new MancareContext())
            {
                var mancare = context.Mancaruri.SqlQuery("UPDATE dbo.Mancare SET PretVanzare=PretVanzare*0.9 WHERE MancareID IN (SELECT m.MancareID FROM dbo.Mancare m WHERE m.Stoc > (SELECT AVG(m2.Stoc) FROM dbo.Mancare m2 WHERE m.AnimalID=m2.AnimalID GROUP BY m2.AnimalID))");
            }
            Response.Redirect("SuccessReducere.aspx");
        }
        protected void AddProducatorBtn_Click(Object sender, EventArgs e)
        {
            Response.Redirect("AddProducator.aspx");
        }
        protected void AddAmbalajBtn_Click(Object sender, EventArgs e)
        {
            Response.Redirect("AddAmbalaj.aspx");
        }
        protected void AddMancareBtn_Click(Object sender, EventArgs e)
        {
            Response.Redirect("AddMancare.aspx");
        }
        protected void AddAnimalBtn_Click(Object sender, EventArgs e)
        {
            Response.Redirect("AddAnimal.aspx");
        }
        protected void AddIngredientBtn_Click(Object sender, EventArgs e)
        {
            Response.Redirect("AddIngredient.aspx");
        }
        //Information
        protected void LowerThanFiveBtn_Click(Object sender, EventArgs e)
        {
            Response.Redirect("StocProd.aspx");
        }
        protected void MaxStocProdBtn_Click(Object sender, EventArgs e)
        {
            Response.Redirect("MaxStocProd.aspx");
        }
        protected void GridViewIngredienteCompozitieBtn_Click(Object sender, EventArgs e)
        {
            Response.Redirect("IngredienteCompozitie.aspx");
        }
        protected void GridViewStocPerProducatorBtn_Click(Object sender, EventArgs e)
        {
            Response.Redirect("StocPerProducator.aspx");
        }
        //GridView
        protected void GridViewMancareBtn_Click(Object sender, EventArgs e)
        {
            Response.Redirect("GridViewMancare.aspx");
        }
        protected void GridViewProducatorBtn_Click(Object sender, EventArgs e)
        {
            Response.Redirect("GridViewProducator.aspx");
        }
        

    }
}