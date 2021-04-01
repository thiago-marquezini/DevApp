using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SQLite;

namespace DevApp.SQLite
{
	[Table("users")]
	public class UserObj
	{
		[PrimaryKey, AutoIncrement]
		[Column("Id")]
		public int Id { get; set; }

		[Column("Name")]
		public string Name { get; set; }

		[Column("Password")]
		public string Password { get; set; }

		[Column("Level")]
		public string Level { get; set; }

		[Column("Activity")]
		public string Activity { get; set; }

		[Column("DisplayName")]
		public string DisplayName { get; set; }

	}
}
