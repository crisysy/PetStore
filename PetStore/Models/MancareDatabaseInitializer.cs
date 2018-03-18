using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PetStore.Models
{
    public class MancareDatabaseInitializer: DropCreateDatabaseIfModelChanges<MancareContext>
    {
        protected override void Seed(MancareContext context)
        {
            GetAmbalaje().ForEach(a => context.Ambalaje.Add(a));
            GetAnimale().ForEach(a => context.Animale.Add(a));
            GetIngrediente().ForEach(i => context.Ingrediente.Add(i));
            GetProducatori().ForEach(p => context.Producatori.Add(p));
            GetMancaruri().ForEach(m => context.Mancaruri.Add(m));
            GetCompozitii().ForEach(c => context.Compozitii.Add(c));
            GetCartItem().ForEach(ci => context.ShoppingCartItems.Add(ci));
            
        }
        private static List<Ambalaj> GetAmbalaje()
        {
            var ambalaje = new List<Ambalaj>
            {
                //new Ambalaj
                //{
                //    AmbalajID=1,
                //    Tip="Conserva"
                //},
                //new Ambalaj
                //{
                //    AmbalajID=2,
                //    Tip="Plic"
                //},
                //new Ambalaj
                //{
                //    AmbalajID=3,
                //    Tip="Sac"
                //},
                //new Ambalaj
                //{
                //    AmbalajID=4,
                //    Tip="Cutie"
                //},
                //new Ambalaj
                //{
                //    AmbalajID=5,
                //    Tip="Punga"
                //},
                //new Ambalaj
                //{
                //    AmbalajID=6,
                //    Tip="Pachet"
                //},
            };
            return ambalaje;
        }
        private static List<Animal> GetAnimale()
        {
            var animale = new List<Animal>
            {
                //new Animal
                //{
                //    AnimalID=1,
                //    Nume="Caine",
                //    Varsta="Junior"
                //},
                //new Animal
                //{
                //    AnimalID=2,
                //    Nume="Caine",
                //    Varsta="Senior"
                //},
                //new Animal
                //{
                //    AnimalID=3,
                //    Nume="Caine",
                //    Varsta="Toate Varstele"
                //},
                //new Animal
                //{
                //    AnimalID=4,
                //    Nume="Pisica",
                //    Varsta="Junior"
                //},
                //new Animal
                //{
                //    AnimalID=5,
                //    Nume="Pisica",
                //    Varsta="Senior"
                //},
                //new Animal
                //{
                //    AnimalID=6,
                //    Nume="Pisica",
                //    Varsta="Toate Varstele"
                //},
                //new Animal
                //{
                //    AnimalID=7,
                //    Nume="Iepure",
                //    Varsta="Junior"
                //},
                //new Animal
                //{
                //    AnimalID=8,
                //    Nume="Iepure",
                //    Varsta="Senior"
                //},
                //new Animal
                //{
                //    AnimalID=9,
                //    Nume="Iepure",
                //    Varsta="Toate Varstele"
                //},
                //new Animal
                //{
                //    AnimalID=10,
                //    Nume="Peste",
                //    Varsta="Junior"
                //},
                //new Animal
                //{
                //    AnimalID=11,
                //    Nume="Peste",
                //    Varsta="Senior"
                //},
                //new Animal
                //{
                //    AnimalID=12,
                //    Nume="Peste",
                //    Varsta="Toate Varstele"
                //},
                //new Animal
                //{
                //    AnimalID=13,
                //    Nume="Hamster",
                //    Varsta="Junior"
                //},
                //new Animal
                //{
                //    AnimalID=14,
                //    Nume="Hamster",
                //    Varsta="Senior"
                //},
                //new Animal
                //{
                //    AnimalID=15,
                //    Nume="Hamster",
                //    Varsta="Toate Varstele"
                //},
                //new Animal
                //{
                //    AnimalID=16,
                //    Nume="Papagal",
                //    Varsta="Junior"
                //},
                //new Animal
                //{
                //    AnimalID=17,
                //    Nume="Papagal",
                //    Varsta="Senior"
                //},
                //new Animal
                //{
                //    AnimalID=18,
                //    Nume="Papagal",
                //    Varsta="Toate Varstele"
                //},
            };
            return animale;
        }
        private static List<Ingredient> GetIngrediente()
        {
            var ingrediente = new List<Ingredient>
            {
                //new Ingredient
                //{
                //    IngredientID=1,
                //    Nume="Bivol",
                //    CompozitieID=1                    
                //},
                //new Ingredient
                //{
                //    IngredientID=2,
                //    Nume="Bizon",
                //    CompozitieID=1
                //},
                //new Ingredient
                //{
                //    IngredientID=3,
                //    Nume="Caprioara",
                //    CompozitieID=2
                //},
                //new Ingredient
                //{
                //    IngredientID=4,
                //    Nume="Curcan",
                //    CompozitieID=2
                //},
                //new Ingredient
                //{
                //    IngredientID=5,
                //    Nume="Fazan",
                //    CompozitieID=2
                //},
                //new Ingredient
                //{
                //    IngredientID=6,
                //    Nume="Hering",
                //    CompozitieID=3
                //},
                //new Ingredient
                //{
                //    IngredientID=7,
                //    Nume="Macrou",
                //    CompozitieID=3
                //},
                //new Ingredient
                //{
                //    IngredientID=8,
                //    Nume="Merluciu",
                //    CompozitieID=3
                //},
                //new Ingredient
                //{
                //    IngredientID=9,
                //    Nume="Miel",
                //    CompozitieID=4,
                //},
                //new Ingredient
                //{
                //    IngredientID=10,
                //    Nume="Mistret",
                //    CompozitieID=4,
                //},
                //new Ingredient
                //{
                //    IngredientID=11,
                //    Nume="Pastrav",
                //    CompozitieID=5
                //},
                //new Ingredient
                //{
                //    IngredientID=12,
                //    Nume="Peste Oceanic",
                //    CompozitieID=5
                //},
                //new Ingredient
                //{
                //    IngredientID=13,
                //    Nume="Platica",
                //    CompozitieID=5
                //},
                //new Ingredient
                //{
                //    IngredientID=14,
                //    Nume="Porc",
                //    CompozitieID=6
                //},
                //new Ingredient
                //{
                //    IngredientID=15,
                //    Nume="Pui",
                //    CompozitieID=6
                //},
                //new Ingredient
                //{
                //    IngredientID=16,
                //    Nume="Rata",
                //    CompozitieID=6
                //},
                //new Ingredient
                //{
                //    IngredientID=17,
                //    Nume="Ren",
                //    CompozitieID=7
                //},
                //new Ingredient
                //{
                //    IngredientID=18,
                //    Nume="Somon",
                //    CompozitieID=8
                //},
                //new Ingredient
                //{
                //    IngredientID=19,
                //    Nume="Ton",
                //    CompozitieID=8
                //},
                //new Ingredient
                //{
                //    IngredientID=20,
                //    Nume="Vita",
                //    CompozitieID=7
                //},
            };
            return ingrediente;
        }
        private static List<Producator> GetProducatori()
        {
            var producatori = new List<Producator>
            {
                //new Producator
                //{
                //    ProducatorID=1,
                //    Nume="Canagan",
                //    Adresa="242 Jellicoe Street Te Puke 3119 New Zealand",
                //    Telefon="+6562738981"
                //},
                //new Producator
                //{
                //    ProducatorID=2,
                //    Nume="Royal Canin",
                //    Adresa="C.Floreasca 169 A,FBP,C.A,Et.7,S.1,București",
                //    Telefon="+40212330515"
                //},
                //new Producator
                //{
                //    ProducatorID=3,
                //    Nume="VeggiePets",
                //    Adresa="Unit D, DBP,12 Hampshire PO9 2NJ",
                //    Telefon="02392453355"
                //},
                //new Producator
                //{
                //    ProducatorID=4,
                //    Nume="Tetra Fish",
                //    Adresa="3001 Commerce St., Blacksburg, VA 24060-6671",
                //    Telefon="1-800-526-0650"
                //},
                //new Producator
                //{
                //    ProducatorID=5,
                //    Nume="ACANA",
                //    Adresa="400 Plaza Drive Secaucus, NJ 07094 USA",
                //    Telefon="1-800-275-1414"
                //},
                //new Producator
                //{
                //    ProducatorID=6,
                //    Nume="Fresh Pet",
                //    Adresa="P. O. Box 2157 Secaucus, NJ 07096 – 2157",
                //    Telefon="866-789-3737"
                //},
            };
            return producatori;
        }
        private static List<Mancare> GetMancaruri()
        {
            var mancaruri = new List<Mancare>
            {
                //new Mancare
                //{
                //    MancareID=1,
                //    Denumire="CANAGAN Dog Grain Free Vanat",
                //    ProducatorID=1,
                //    AnimalID=1,
                //    AmbalajID=3,
                //    Gramaj=1000.0,
                //    Stoc=10,
                //    PretAchizitie=20.0,
                //    PretVanzare=27.0,
                //    DataExpirare=DateTime.Now.AddMonths(8),
                //    ImagePath="CANAGANDogGrainFreeVanat.png"
                //},
                //new Mancare
                //{
                //    MancareID=2,
                //    Denumire="ACANA Caprioara si curcan",
                //    ProducatorID=5,
                //    AnimalID=2,
                //    AmbalajID=3,
                //    Gramaj=1500.0,
                //    Stoc=7,
                //    PretAchizitie=38.80,
                //    PretVanzare=45.00,
                //    DataExpirare=DateTime.Now.AddDays(30),
                //    ImagePath="ACANAMielsiMere.png"
                //},               

            };
            return mancaruri;
        }
        private static List<Compozitie> GetCompozitii()
        {
            var compozitii = new List<Compozitie>
            {
                //new Compozitie
                //{
                //    CompozitieID=1,
                //    MancareID=1
                //},
                //new Compozitie
                //{
                //    CompozitieID=2,
                //    MancareID=2
                //}
            };
            return compozitii;
        }
        private static List<CartItem> GetCartItem()
        {
            var cartitem = new List<CartItem>
            {

            };
            return cartitem;
        }
        
    }
}