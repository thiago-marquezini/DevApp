using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Globalization;

using DevApp.PopUp_Forms;
using DevApp.SQLite;

namespace DevApp.Child_Forms
{
    public partial class XtraMDIProdutos : DevExpress.XtraEditors.XtraForm
    {
        List<ProductCategObj> ProductCategories;
        CultureInfo CultureBR = new CultureInfo("pt-BR");

        private SQLiteCipher ProductsConnection = new SQLiteCipher();
        private clsProductQueries ProductQueries = new clsProductQueries();

        public XtraMDIProdutos()
        {
            InitializeComponent();

            GetProductCategories();
            GetProducts();
        }

        private void XtraMDIProdutos_Load(object sender, EventArgs e)
        {
            
        }

        public void GetProducts()
        {
            List<ProductObj> Products = ProductQueries.ListProducts(ProductsConnection.Connection());
            gridProdutos.DataSource = Products;
        }

        public void GetProductCategories()
        {
            ProductCategories = ProductQueries.ListProductCategories(ProductsConnection.Connection());
        }

        public string GetProductCategory(int CatId)
        {
            string CategoryName = "";

            if (ProductCategories.Count > 0)
            {
                ProductCategories.ForEach(delegate (ProductCategObj Category)
                {
                    if (Category.Id == CatId)
                    {
                        CategoryName = Category.Name;
                    }
                });
            }  
            return CategoryName;
        }


        private void gridViewProdutos_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            ColumnView view = sender as ColumnView;

            if (e.Column.FieldName == "Category" && e.ListSourceRowIndex != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
            {
                if (e.Value.ToString().Length > 0)
                {
                    e.DisplayText = GetProductCategory(Int32.Parse(e.Value.ToString()));
                }

            }

            if (e.Column.FieldName == "PrecoCusto" && e.ListSourceRowIndex != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
            {
                if (e.Value.ToString().Length > 0)
                {
                    decimal price = Convert.ToDecimal(e.Value);
                    e.DisplayText = string.Format(CultureBR, "{0:c}", price);

                    e.Column.AppearanceCell.ForeColor = Color.Red;
                }

            }

            if (e.Column.FieldName == "PrecoVenda" && e.ListSourceRowIndex != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
            {
                if (e.Value.ToString().Length > 0)
                {
                    decimal price = Convert.ToDecimal(e.Value);
                    e.DisplayText = string.Format(CultureBR, "{0:c}", price);

                    e.Column.AppearanceCell.ForeColor = Color.Green;
                }
            }

        }

        private void gridViewProdutos_CustomDrawCell(object sender, RowCellCustomDrawEventArgs e)
        {
            if (e.Column.FieldName == "CodSistema")
            {
                if (e.DisplayText.Length > 0)
                {
                    Brush brush = new SolidBrush(Color.DimGray);
                    Rectangle r = e.Bounds;
                    e.Graphics.FillRectangle(brush, r.X, r.Y, 3, r.Height);
                    e.Appearance.DrawString(e.Cache, "    " + e.DisplayText, r);
                    e.Handled = true;
                }
            }

            if (e.Column.FieldName == "PrecoCusto")
            {
                if (e.DisplayText.Length > 0)
                {
                    String RawNumber = e.DisplayText.Replace("R$ ", "").Replace(".", "").Replace(",", "");
                    if (Int32.Parse(RawNumber) > 0)
                    {
                        Brush brush = new SolidBrush(Color.Red);
                        Rectangle r = e.Bounds;
                        e.Graphics.FillRectangle(brush, r.X, r.Y, 3, r.Height);
                        e.Appearance.DrawString(e.Cache, "    " + e.DisplayText, r);
                        e.Handled = true;
                    }
                }
            }

            if (e.Column.FieldName == "PrecoVenda")
            {
                if (e.DisplayText.Length > 0)
                {
                    String RawNumber = e.DisplayText.Replace("R$ ", "").Replace(".", "").Replace(",", "");
                    if (Int32.Parse(RawNumber) > 0)
                    {
                        Brush brush = new SolidBrush(Color.Green);
                        Rectangle r = e.Bounds;
                        e.Graphics.FillRectangle(brush, r.X, r.Y, 3, r.Height);
                        e.Appearance.DrawString(e.Cache, "    " + e.DisplayText, r);
                        e.Handled = true;
                    }
                }
            }

            if (e.Column.FieldName == "ControleEstoque")
            {
                if (e.DisplayText.Length > 0)
                {
                    if (e.DisplayText == "Sem Controle")
                    {
                        Brush brush = new SolidBrush(Color.Gray);
                        Rectangle r = e.Bounds;
                        e.Graphics.FillRectangle(brush, r.X, r.Y, 3, r.Height);
                        e.Appearance.DrawString(e.Cache, "    " + e.DisplayText, r);
                        e.Handled = true;

                    } else if (e.DisplayText == "Controlado")
                    {
                        Brush brush = new SolidBrush(Color.Blue);
                        Rectangle r = e.Bounds;
                        e.Graphics.FillRectangle(brush, r.X, r.Y, 3, r.Height);
                        e.Appearance.DrawString(e.Cache, "    " + e.DisplayText, r);
                        e.Handled = true;
                    }
                }
            }

            if (e.Column.FieldName == "Active")
            {
                if (e.DisplayText == "Inativo")
                {
                    Brush brush = new SolidBrush(Color.Red);
                    Rectangle r = e.Bounds;
                    e.Graphics.FillRectangle(brush, r.X, r.Y, 3, r.Height);
                    e.Appearance.DrawString(e.Cache, "    " + e.DisplayText, r);
                    e.Handled = true;

                } else if (e.DisplayText == "Ativo")
                {
                    Brush brush = new SolidBrush(Color.Green);
                    Rectangle r = e.Bounds;
                    e.Graphics.FillRectangle(brush, r.X, r.Y, 3, r.Height);
                    e.Appearance.DrawString(e.Cache, "    " + e.DisplayText, r);
                    e.Handled = true;
                }
            }
        }

        private void gridViewProdutos_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.Column.FieldName == "Active" && e.RowHandle == view.DataRowCount - 1)
            {
                //
            }
        }

        private void btnProductPrint_Click(object sender, EventArgs e)
        {
        }

        private void btnProductAdd_Click(object sender, EventArgs e)
        {
            XtraProductAdd AddProduct = new XtraProductAdd(this, false);
            AddProduct.Text = "Adicionar Produto";
            AddProduct.WindowState = FormWindowState.Normal;
            AddProduct.ShowDialog();
        }

        private void btnProductEdit_Click(object sender, EventArgs e)
        {
            if (gridViewProdutos.FocusedRowHandle >= 0)
            {
                int ProductId = Int32.Parse(gridViewProdutos.GetFocusedRowCellValue("Id").ToString());

                XtraProductAdd AddProduct = new XtraProductAdd(this, true, ProductId);
                AddProduct.Text = "Editar Produto";
                AddProduct.WindowState = FormWindowState.Normal;
                AddProduct.ShowDialog();
            }
        }

        private void XtraMDIProdutos_FormClosing(object sender, FormClosingEventArgs e)
        {
            ProductsConnection.Connection().Close();
        }

        private void gridViewProdutos_DoubleClick(object sender, EventArgs e)
        {
            if (gridViewProdutos.FocusedRowHandle >= 0)
            {
                int ProductId = Int32.Parse(gridViewProdutos.GetFocusedRowCellValue("Id").ToString());

                XtraProductAdd AddProduct = new XtraProductAdd(this, true, ProductId);
                AddProduct.Text = "Editar Produto";
                AddProduct.WindowState = FormWindowState.Normal;
                AddProduct.ShowDialog();
            }
        }
    }
}