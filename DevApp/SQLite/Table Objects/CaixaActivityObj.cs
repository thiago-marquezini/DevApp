using SQLite;

namespace DevApp.SQLite
{
	[Table("caixa_activity")]
	public class CaixaActivityObj
	{
		[PrimaryKey, AutoIncrement]
		[Column("Id")]
		public int Id { get; set; }

		[Indexed]
		[Column("IdCaixa")]
		public int IdCaixa { get; set; }

		[Column("DataHora")]
		public string DataHora { get; set; }

		[Column("Descricao")]
		public string Descricao { get; set; }

		[Column("Entrada")]
		public string Entrada { get; set; }

		[Column("Saida")]
		public string Saida { get; set; }

		[Column("FormaPgto")]
		public string FormaPgto { get; set; }

		[Column("Tipo")]
		public string Tipo { get; set; }

		[Column("IdPedido")]
		public string IdPedido { get; set; }

		[Column("Direction")]
		public string Direction { get; set; }
	}
}
