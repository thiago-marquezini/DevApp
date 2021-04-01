using System;
using System.IO;

using SQLite;

namespace DevApp.SQLite
{
	class SQLiteCipher
    {
		private string DatabaseName;
		private string DatabasePass = "123456";

		private SQLiteConnection EncryptedDB;

		public SQLiteCipher()
        {
			this.DatabaseName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "DevAppSQLite3.db");
			this.EncryptedDB  = new SQLiteConnection(new SQLiteConnectionString(DatabaseName, true)); // key: DatabasePass
		}

		public SQLiteConnection Connection()
        {
			return this.EncryptedDB;
        }

		public void SetupDB()
        {
			this.EncryptedDB.DropTable<UserObj>();
			this.EncryptedDB.DropTable<CaixaObj>();
			this.EncryptedDB.DropTable<CaixaActivityObj>();

			this.EncryptedDB.CreateTable<UserObj>();
			this.EncryptedDB.CreateTable<CaixaObj>();
			this.EncryptedDB.CreateTable<CaixaActivityObj>();

			var Admin = new UserObj { Name = "admin", Password = "123456", Level = "1", DisplayName = "Thiago Marquezini", Activity = "1" };
			this.EncryptedDB.Insert(Admin);
		}
    }
}
