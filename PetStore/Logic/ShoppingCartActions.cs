using PetStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetStore.Logic
{
    public class ShoppingCartActions : IDisposable
    {
        public string ShoppingCartId { get; set; }
        private MancareContext _db = new MancareContext();
        public const string CartSessionKey = "CartId";
        public void AddToCart(int id)
        {
            ShoppingCartId = GetCartId();
            var cartItem = _db.ShoppingCartItems.SingleOrDefault(
              c => c.CartId == ShoppingCartId
              && c.MancareID == id);
            if (cartItem == null)
            {
                // Create a new cart item if no cart item exists.                 
                cartItem = new CartItem
                {
                    ItemId = Guid.NewGuid().ToString(),
                    MancareID = id,
                    CartId = ShoppingCartId,
                    Mancare = _db.Mancaruri.SingleOrDefault(
                   p => p.MancareID == id),
                    Quantity = 1,
                    DateCreated = DateTime.Now
                };

                _db.ShoppingCartItems.Add(cartItem);
            }
            else
            {
                // If the item does exist in the cart,                  
                // then add one to the quantity.                 
                cartItem.Quantity++;
            }
            _db.SaveChanges();
        }
        public void Dispose()
        {
            if (_db != null)
            {
                _db.Dispose();
                _db = null;
            }
        }

        public string GetCartId()
        {
            if (HttpContext.Current.Session[CartSessionKey] == null)
            {
                if (!string.IsNullOrWhiteSpace(HttpContext.Current.User.Identity.Name))
                {
                    HttpContext.Current.Session[CartSessionKey] = HttpContext.Current.User.Identity.Name;
                }
                else
                {
                    // Generate a new random GUID using System.Guid class.     
                    Guid tempCartId = Guid.NewGuid();
                    HttpContext.Current.Session[CartSessionKey] = tempCartId.ToString();
                }
            }
            return HttpContext.Current.Session[CartSessionKey].ToString();
        }
        public List<CartItem> GetCartItems()
        {
            ShoppingCartId = GetCartId();

            return _db.ShoppingCartItems.Where(
                c => c.CartId == ShoppingCartId).ToList();
        }        
        public decimal GetTotal()
        {
            ShoppingCartId = GetCartId();
            decimal? total = decimal.Zero;
            total = (decimal?)(from cartItem in _db.ShoppingCartItems
                               where cartItem.CartId == ShoppingCartId
                               select (int?)cartItem.Quantity * cartItem.Mancare.PretVanzare).Sum();
            return total ?? decimal.Zero;
        }
        public ShoppingCartActions GetCart(HttpContext context)
        {
            using(var cart=new ShoppingCartActions())
            {
                cart.ShoppingCartId = cart.GetCartId();
                return cart;
            }
        }

        public void UpdateShoppingCartDatabase(String cartId, ShoppingCartUpdates[] cartItemUpdates)
        {
            using (var db=new PetStore.Models.MancareContext())
            {
                try
                {
                    int CartItemCount = cartItemUpdates.Count();
                    List<CartItem> myCart = GetCartItems();
                    foreach (var cartItem in myCart)
                    {
                        // Iterate through all rows within shopping cart list
                        for (int i = 0; i < CartItemCount; i++)
                        {
                            if (cartItem.Mancare.MancareID == cartItemUpdates[i].ProductId)
                            {
                                if (cartItemUpdates[i].PurchaseQuantity < 1 || cartItemUpdates[i].RemoveItem == true)
                                {
                                    RemoveItem(cartId, cartItem.MancareID);
                                }
                                else
                                {
                                    UpdateItem(cartId, cartItem.MancareID, cartItemUpdates[i].PurchaseQuantity);
                                }
                            }
                        }
                    }
                }
                catch (Exception exp)
                {
                    throw new Exception("ERROR: Unable to Update Cart Database - " + exp.Message.ToString(), exp);
                }
            }
            
        }
        public void RemoveItem(string removeCartID, int removeProductID)
        {
            using (var _db = new PetStore.Models.MancareContext())
            {
                try
                {
                    var myItem = (from c in _db.ShoppingCartItems where c.CartId == removeCartID && c.Mancare.MancareID == removeProductID select c).FirstOrDefault();
                    if (myItem != null)
                    {
                        // Remove Item.
                        _db.ShoppingCartItems.Remove(myItem);
                        _db.SaveChanges();
                    }
                }
                catch (Exception exp)
                {
                    throw new Exception("ERROR: Unable to Remove Cart Item - " + exp.Message.ToString(), exp);
                }
            }
        }

        public void UpdateItem(string updateCartID, int updateProductID, int quantity)
        {
            using (var _db = new PetStore.Models.MancareContext())
            {
                try
                {
                    var myItem = (from c in _db.ShoppingCartItems where c.CartId == updateCartID && c.Mancare.MancareID == updateProductID select c).FirstOrDefault();
                    if (myItem != null)
                    {
                        myItem.Quantity = quantity;
                        _db.SaveChanges();
                    }
                }
                catch (Exception exp)
                {
                    throw new Exception("ERROR: Unable to Update Cart Item - " + exp.Message.ToString(), exp);
                }
            }
        }
        public void EmptyCart()
        {
            ShoppingCartId = GetCartId();
            var cartItems = _db.ShoppingCartItems.Where(
                c => c.CartId == ShoppingCartId);
            foreach (var cartItem in cartItems)
            {
                _db.ShoppingCartItems.Remove(cartItem);
            }
            // Save changes.             
            _db.SaveChanges();
        }

        public int GetCount()
        {
            ShoppingCartId = GetCartId();

            // Get the count of each item in the cart and sum them up          
            int? count = (from cartItems in _db.ShoppingCartItems
                          where cartItems.CartId == ShoppingCartId
                          select (int?)cartItems.Quantity).Sum();
            // Return 0 if all entries are null         
            return count ?? 0;
        }

        public struct ShoppingCartUpdates
        {
            public int ProductId;
            public int PurchaseQuantity;
            public bool RemoveItem;
        }
    }
}