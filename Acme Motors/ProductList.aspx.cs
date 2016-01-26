using Acme_Motors.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Acme_Motors
{
    public partial class ProductList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<Product> GetProducts([QueryString("id")] int? categoryId)
        {
            var _db = new Acme_Motors.Models.ProductContext();
            IQueryable<Product> query = _db.Products;
            if (categoryId.HasValue && categoryId > 0)
            {
                query = query.Where(p => p.CategoryID == categoryId);
            }
            return query;
        }

        /*public IQueryable<Product> GetProducts([Control("id")] int? categoryId)
        {
            var _db = new Acme_Motors.Models.ProductContext();
            IQueryable<Product> query = _db.Products;
            if (categoryId.HasValue && categoryId > 0)
            {
                query = query.Where(p => p.CategoryID == categoryId);
            }
            return query;
        }*/

        // The id parameter name should match the DataKeyNames value set on the control
        public void productsGrid_UpdateItem(int ProductID)
        {

            using (ProductContext db = new ProductContext())
            {
                Product item = null;
                // Load the item here, e.g. item = MyDataLayer.Find(id);
                item = db.Products.Find(ProductID);
                if (item == null)
                {
                    // The item wasn't found
                    ModelState.AddModelError("", String.Format("Item with id {0} was not found", ProductID));
                    return;
                }
                TryUpdateModel(item);
                if (ModelState.IsValid)
                {
                    // Save changes here, e.g. MyDataLayer.SaveChanges();
                    db.SaveChanges();
                }
            }               
        }

        // The id parameter name should match the DataKeyNames value set on the control
        public void productsGrid_DeleteItem(int productID)
        {
            using (ProductContext db = new ProductContext())
            {
                var item = new Product { ProductID = productID };
                db.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                try
                {
                    db.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    ModelState.AddModelError("",String.Format("Item with id {0} no longer exists in the database.", productID));
                }
            }
        }
    }
}