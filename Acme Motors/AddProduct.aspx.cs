using Acme_Motors.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Acme_Motors
{
    public partial class AddProduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void addVehicleForm_InsertItem()
        {
            var item = new Models.Product();
            TryUpdateModel(item);
            if (ModelState.IsValid)
            {
                using (ProductContext db = new ProductContext())
                {
                    db.Products.Add(item);
                    db.SaveChanges();
                }

            }
        }
        protected void cancelButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ProductList.aspx");
        }

        protected void addVehicleForm_ItemInserted(object sender, FormViewInsertedEventArgs e)
        {
            Response.Redirect("~/ProductList.aspx");
        }
    }
}