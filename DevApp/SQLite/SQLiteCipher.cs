using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using Dropbox.Api;
using Dropbox.Api.Files;
using SQLite;

namespace DevApp.SQLite
{
	class SQLiteCipher
    {
		private string DatabaseName;
		/* private string DatabasePass = "123456"; key: DatabasePass */

		private SQLiteConnection EncryptedDB;

		public SQLiteCipher()
        {
			this.DatabaseName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "DevAppSQLite3.db");
			this.EncryptedDB  = new SQLiteConnection(new SQLiteConnectionString(DatabaseName, true));
		}

		public SQLiteConnection Connection()
        {
			return this.EncryptedDB;
        }

		public void SetupDB()
        {
			//this.EncryptedDB.DropTable<UserObj>();
			//this.EncryptedDB.DropTable<CaixaObj>();
			//this.EncryptedDB.DropTable<CaixaActivityObj>();
			//this.EncryptedDB.DropTable<ProductObj>();
			//this.EncryptedDB.DropTable<ProductCategObj>();

			//this.EncryptedDB.CreateTable<UserObj>();
			//this.EncryptedDB.CreateTable<CaixaObj>();
			//this.EncryptedDB.CreateTable<CaixaActivityObj>();
			//this.EncryptedDB.CreateTable<ProductObj>();
			//this.EncryptedDB.CreateTable<ProductCategObj>();


			//var Admin = new UserObj { Name = "admin", Password = "123456", Level = "1", DisplayName = "Thiago Marquezini", Activity = "1" };
			//this.EncryptedDB.Insert(Admin);
		}

		public async void DropboxBackup()
		{
			using (var dbx = new DropboxClient("YOUR ACCESS TOKEN"))
			{
				var full = await dbx.Users.GetCurrentAccountAsync();
				Console.WriteLine("{0} - {1}", full.Name.DisplayName, full.Email);

				using (var mem = new MemoryStream(Encoding.UTF8.GetBytes("asd")))
				{
					var updated = await dbx.Files.UploadAsync("DevApp Backups/" + "Database.db", WriteMode.Overwrite.Instance, body: mem);
					Console.WriteLine("Saved {0}/{1} rev {2}", "DevApp Backups", "Database.db", updated.Rev);
				}
			}
		}
	}
}
