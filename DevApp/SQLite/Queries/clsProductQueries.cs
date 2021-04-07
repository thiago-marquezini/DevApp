using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SQLite;

using DevApp.Global;

namespace DevApp.SQLite
{
    class clsProductQueries
    {
        public List<ProductObj> ListProducts(SQLiteConnection db)
        {
            return db.Table<ProductObj>().ToList();
        }

        public List<ProductCategObj> ListProductCategories(SQLiteConnection db)
        {
            return db.Table<ProductCategObj>().ToList();
        }

        public List<ProductObj> GetProductInfo(SQLiteConnection db, int ProductId)
        {
            return db.Table<ProductObj>().Where(t => t.Id == ProductId).ToList();
        }

        public bool AddProduct(SQLiteConnection db, ProductObj Product)
        {
            if (db.Insert(Product) > 0) { return true; } return false;
        }

        public bool UpdateProductInfo(SQLiteConnection db, ProductObj Product)
        {
            if (db.Update(Product) > 0) { return true; } return false;
        }
    }
}
