using System;
using SQLite.Net;
using SQLite.Net.Platform.XamarinAndroid;
using System.IO;
using Xamarin.Forms;
using GadoX.Droid;

[assembly: Dependency(typeof(SQLite_Android))]
namespace GadoX.Droid {
	public class SQLite_Android : ISQLite {

		public bool fileExists(string fineName) {
			throw new NotImplementedException();
			}

		private const string DBNAME = "GadoX.db3";

		public SQLiteConnection GetConnection() {
			return GetConnection(DBNAME);
			}

		public SQLiteConnection GetConnection(string DBFileName) {
			return new SQLiteConnection(
				new SQLitePlatformAndroid(),
				Path.Combine(
					Environment.GetFolderPath(Environment.SpecialFolder.Personal),
					DBFileName
				)
			);
			}

		public string GetDBPath() {
			return Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			}

		public void SaveDBFile(string fileName, byte[] file) {
			File.WriteAllBytes(Path.Combine(GetDBPath(), fileName), file);
			}

		public bool FileExists(string fileName) {
			return File.Exists(fileName);
			}
		}
	}

