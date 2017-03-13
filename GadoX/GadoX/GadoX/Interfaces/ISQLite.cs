using System;
using SQLite.Net;

namespace GadoX {
	public interface ISQLite {

        SQLiteConnection GetConnection();

		SQLiteConnection GetConnection(string DBFileName);

		string GetDBPath();

		void SaveDBFile(string fileName, byte[] file);

		bool fileExists(string fineName);

		}
	}
