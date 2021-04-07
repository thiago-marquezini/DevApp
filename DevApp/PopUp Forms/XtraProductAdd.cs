using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
using DevApp.Child_Forms;
using DevApp.SQLite;

namespace DevApp.PopUp_Forms
{
    public partial class XtraProductAdd : DevExpress.XtraEditors.XtraForm
    {
        XtraMDIProdutos frmProducts;

        List<ProductCategObj> ProductCategories;
        CultureInfo CultureBR = new CultureInfo("pt-BR");

        private SQLiteCipher ProductsConnection = new SQLiteCipher();
        private clsProductQueries ProductQueries = new clsProductQueries();

        private List<ProductObj> ProductInfo;

        private bool IsEdit = false;
        private int ProductId = -1;

        private string ValidErrorMsg = "";

        public XtraProductAdd(XtraMDIProdutos _frmProducts, bool _IsEdit, int _ProductId = -1)
        {
            InitializeComponent();

            this.frmProducts = _frmProducts;
            this.IsEdit = _IsEdit;
            this.ProductId = _ProductId;

            GetProductCategories();
        }

        private void XtraProductAdd_Load(object sender, EventArgs e)
        {
            ProductCategories.ForEach(delegate (ProductCategObj Category)
            {
                comboProductCategory.Properties.Items.Add(Category.Name);
            });

            if (this.IsEdit)
            {
                GetProductInfo(this.ProductId);
            }
        }

        public void GetProductCategories()
        {
            ProductCategories = ProductQueries.ListProductCategories(ProductsConnection.Connection());
        }

        public void GetProductInfo(int ProductId)
        {
            this.ProductInfo = ProductQueries.GetProductInfo(ProductsConnection.Connection(), ProductId);

            // INFO
            editProductName.Text = ProductInfo[0].Name;
            comboProductCategory.SelectedIndex = Int32.Parse(ProductInfo[0].Category);
            radioProductMedida.SelectedIndex = Int32.Parse(ProductInfo[0].Medida);
            editPrecoCusto.Text = string.Format(CultureBR, "{0:c}", Convert.ToDecimal(ProductInfo[0].PrecoCusto));
            editPrecoVenda.Text = string.Format(CultureBR, "{0:c}", Convert.ToDecimal(ProductInfo[0].PrecoVenda));
            SwitchActiveProduct.IsOn = (ProductInfo[0].Active == "Ativo") ? true : false;
            editCodSistema.Text = ProductInfo[0].CodSistema;
            editCodPersonalizado.Text = ProductInfo[0].CodCustom;
            memoProductDescricao.Text = ProductInfo[0].Descricao;

            // DETALHES
            chkProductIsentoTaxa.Checked = (ProductInfo[0].TaxaServico == "1") ? true : false;
            chkProductCozinha.Checked = (ProductInfo[0].ItemCozinha != "-1") ? true : false;
            comboProductCozinha.SelectedIndex = (ProductInfo[0].ItemCozinha != "-1") ? Int32.Parse(ProductInfo[0].ItemCozinha) : -1;

            // ESTOQUE
            chkProductEstoqueControle.Checked = (ProductInfo[0].ControleEstoque == "Controlado") ? true : false;
            editProductEstoqueMin.Text = ProductInfo[0].EstoqueMin;
            editProductEstoqueAtual.Text = ProductInfo[0].EstoqueUnidade;
        }

        public void UpdateProduct()
        {
            // INFO
            this.ProductInfo[0].Name = editProductName.Text;
            this.ProductInfo[0].Category = comboProductCategory.SelectedIndex.ToString();
            this.ProductInfo[0].Medida = radioProductMedida.SelectedIndex.ToString();
            this.ProductInfo[0].PrecoCusto = editPrecoCusto.Text.Replace("R$ ", "");
            this.ProductInfo[0].PrecoVenda = editPrecoVenda.Text.Replace("R$ ", "");
            this.ProductInfo[0].Active = SwitchActiveProduct.IsOn ? "Ativo" : "Inativo";
            this.ProductInfo[0].CodSistema = editCodSistema.Text;
            this.ProductInfo[0].CodCustom = editCodPersonalizado.Text;

            // DETALHES
            this.ProductInfo[0].Descricao = memoProductDescricao.Text;
            this.ProductInfo[0].TaxaServico = chkProductIsentoTaxa.Checked ? "1" : "0";
            this.ProductInfo[0].ItemCozinha = chkProductCozinha.Checked ? comboProductCozinha.SelectedIndex.ToString() : "-1";

            // ESTOQUE
            this.ProductInfo[0].ControleEstoque = chkProductEstoqueControle.Checked ? "Controlado" : "Sem Controle";
            this.ProductInfo[0].EstoqueMin = editProductEstoqueMin.Text;

            if (ValidateFields(this.ProductInfo[0]))
            {
                if (ProductQueries.UpdateProductInfo(ProductsConnection.Connection(), this.ProductInfo[0]))
                {
                    GetProductInfo(this.ProductInfo[0].Id);
                    frmProducts.GetProducts();
                    XtraMessageBox.Show("O produto foi atualizado com sucesso!", "Produto atualizado!", MessageBoxButtons.OK);
                    this.Close();
                }
            }
            else
            {
                XtraMessageBox.Show(this.ValidErrorMsg, "Aviso", MessageBoxButtons.OK);
            }
        }

        public void AddProduct()
        {
            var NewProduct = new ProductObj
            {
                // INFO
                Name = editProductName.Text,
                Category = comboProductCategory.SelectedIndex.ToString(),
                Active = SwitchActiveProduct.IsOn ? "Ativo" : "Inativo",
                CodSistema = editCodSistema.Text,
                CodPDV = editCodSistema.Text,
                CodCustom = editCodPersonalizado.Text,
                Medida = radioProductMedida.SelectedIndex.ToString(),
                PrecoCusto = editPrecoCusto.Text.Replace("R$ ", ""),
                PrecoVenda = editPrecoVenda.Text.Replace("R$ ", ""),

                // DETALHES
                TaxaServico = chkProductIsentoTaxa.Checked ? "1" : "0",
                ItemCozinha = chkProductCozinha.Checked ? comboProductCozinha.SelectedIndex.ToString() : "-1",
                Imagem = "",
                Descricao = memoProductDescricao.Text,
                Availability = "pdv;mobile;online",

                // ESTOQUE
                EstoqueUnidade = "10",
                ControleEstoque = chkProductEstoqueControle.Checked ? "Controlado" : "Sem Controle",
                EstoqueMin = editProductEstoqueMin.Text,
                EstoqueMax = "0",

                // INSUMOS
                FichaTecnica = "0"
            };

            if (ValidateFields(NewProduct))
            {
                if (ProductQueries.AddProduct(ProductsConnection.Connection(), NewProduct))
                {
                    GetProductInfo(NewProduct.Id);
                    frmProducts.GetProducts();
                    XtraMessageBox.Show("Produto adicionado com sucesso!", "Produto adicionado!", MessageBoxButtons.OK);
                    this.Close();
                }
            }
            else
            {
                XtraMessageBox.Show(this.ValidErrorMsg, "Aviso", MessageBoxButtons.OK);
            }
        }

        private bool ValidateFields(ProductObj Product)
        {
            if ((Product.Name.Length <= 5)) { ValidErrorMsg = "O nome do produto deve conter ao menos 6 caracteres."; return false; }
            if ((Int32.Parse(Product.Category) == -1)) { ValidErrorMsg = "A categoria do produto deve ser selecionada."; return false; }
            if ((Product.PrecoCusto.Replace("R$ ", "").Length == 0)) { ValidErrorMsg = "O preco de custo deve ser preenchido."; return false; }
            if ((Product.PrecoVenda.Replace("R$ ", "").Length == 0)) { ValidErrorMsg = "O preco de venda deve ser preenchido."; return false; }
            if ((Product.CodSistema.Length == 0)) { ValidErrorMsg = "O codigo do sistema deve ser preenchido com um valor positivo."; return false; }
            if ((Product.CodCustom.Length == 0)) { ValidErrorMsg = "O codigo personalizado deve ser preenchido com um valor positivo."; return false; }

            return true;
        }

        private void btnEditProductPic_Click(object sender, EventArgs e)
        {
            picProductImage.LoadImage();
        }

        private void btnResetPic_Click(object sender, EventArgs e)
        {
            picProductImage.Image = null;
        }

        private void chkProductCozinha_CheckedChanged(object sender, EventArgs e)
        {
            CheckEdit Check = sender as CheckEdit;

            comboProductCozinha.Enabled = Check.Checked;
            lblProductSelectCozinha.Enabled = Check.Checked;
        }

        private void XtraProductAdd_FormClosing(object sender, FormClosingEventArgs e)
        {
            ProductsConnection.Connection().Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnProductSave_Click(object sender, EventArgs e)
        {
            if (this.IsEdit) { UpdateProduct(); } else { AddProduct(); }
        }
    }
}