using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SQLite;

namespace DevApp.SQLite
{
	[Table("caixa")]
	public class CaixaObj
	{
		[PrimaryKey, AutoIncrement]
		[Column("Id")]
		public int Id { get; set; }

		[Column("OpenedAt")]
		public string OpenedAt { get; set; }

		[Column("ClosedAt")]
		public string ClosedAt { get; set; }

		[Column("Owner")]
		public string Owner { get; set; }

		[Column("IsOpen")]
		public string IsOpen { get; set; }

		[Column("StartValue")]
		public string StartValue { get; set; }

		[Column("TotalLancamentos")]
		public string TotalLancamentos { get; set; }

		[Column("Obs")]
		public string Obs { get; set; }

		[Column("EndValue")]
		public string EndValue { get; set; }

		[Column("EndValueUser")]
		public string EndValueUser { get; set; }

		[Column("Sangria")]
		public string Sangria { get; set; }

		[Column("Despesas")]
		public string Despesas { get; set; }

		[Column("Acrecimos")]
		public string Acrecimos { get; set; }

		[Column("OpenDate")]
		public string OpenDate { get; set; }
	}
}
