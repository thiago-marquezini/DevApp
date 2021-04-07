using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SQLite;

namespace DevApp.SQLite
{
    [Table("products")]
    class ProductObj
    {
		[PrimaryKey, AutoIncrement]
		[Column("Id")]
		public int Id { get; set; }

		[Column("Name")]
		public string Name { get; set; }

		[Column("Category")]
		public string Category { get; set; }

		[Column("Active")]
		public string Active { get; set; }

		[Column("CodSistema")]
		public string CodSistema { get; set; }

		[Column("CodPDV")]
		public string CodPDV { get; set; }

		[Column("CodCustom")]
		public string CodCustom { get; set; }

		[Column("Medida")]
		public string Medida { get; set; }

		[Column("PrecoCusto")]
		public string PrecoCusto { get; set; }

		[Column("PrecoVenda")]
		public string PrecoVenda { get; set; }

		[Column("TaxaServico")]
		public string TaxaServico { get; set; }

		[Column("ItemCozinha")]
		public string ItemCozinha { get; set; }

		[Column("Availability")]
		public string Availability { get; set; }

		[Column("EstoqueUnidade")]
		public string EstoqueUnidade { get; set; }

		[Column("ControleEstoque")]
		public string ControleEstoque { get; set; }

		[Column("EstoqueMin")]
		public string EstoqueMin { get; set; }

		[Column("EstoqueMax")]
		public string EstoqueMax { get; set; }

		[Column("FichaTecnica")]
		public string FichaTecnica { get; set; }

		[Column("Imagem")]
		public string Imagem { get; set; }

		[Column("Descricao")]
		public string Descricao { get; set; }
	}

	[Table("product_category")]
	class ProductCategObj
	{
		[PrimaryKey, AutoIncrement]
		[Column("Id")]
		public int Id { get; set; }

		[Column("Name")]
		public string Name { get; set; }
	}

}
