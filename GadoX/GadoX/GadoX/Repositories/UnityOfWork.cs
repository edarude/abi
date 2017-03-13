using System;
using Xamarin.Forms;
using SQLite.Net;

namespace GadoX {
	public class UnityOfWork : IUnityOfWork {

		protected static object DBLocker = new object();

		public UnityOfWork(){
			DB = DependencyService.Get<ISQLite>().GetConnection();
			_VacaRepository = new GenericRepository<Vaca, int>(DB, DBLocker);
			_GadoRepository = new GenericRepository<Gado, int>(DB, DBLocker);
			_SituacaoRepository = new GenericRepository<Situacao, int>(DB, DBLocker);

			lock(DBLocker){
				DB.CreateTable<Vaca>();
				DB.CreateTable<Gado>();
				DB.CreateTable<Situacao>();
			}
		}

		private readonly SQLiteConnection DB;
		private IGenericRepository<Vaca, int> _VacaRepository;
		private IGenericRepository<Gado, int> _GadoRepository;
		private IGenericRepository<Situacao, int> _SituacaoRepository;

		public IGenericRepository<Vaca,int> VacaRepository {
			get{
				return _VacaRepository;
			}
		}

		public IGenericRepository<Gado,int> GadoRepository {
			get{
				return _GadoRepository;
			}
		}

		public IGenericRepository<Situacao,int> SituacaoRepository {
			get{
				return _SituacaoRepository;
			}
		}

		public void BeginTransaction() {
			DB.BeginTransaction();
		}

		public void Commit() {
			DB.Commit();
		}

		public void Dispose() {
			DB.Dispose();
		}

		public void Rollback() {
			DB.Rollback();
		}
	}
}
