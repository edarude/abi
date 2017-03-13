using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using SQLite.Net;

namespace GadoX {
	public class GenericReadOnlyRepository<T, TKey> : IGenericReadOnlyRepository<T, TKey> where T : class, new(){
		public object Locker {
			get;
			set;
			}

		public GenericReadOnlyRepository(SQLiteConnection context, object locker) {
			Context = context;
			Locker = locker;
			}

		public IEnumerable<T> Query(string query) {
			lock (Locker) {
				return Context.Query<T>(query);
				}
			}

		public GenericReadOnlyRepository() {
			}


		#region Context

		private SQLiteConnection _context;

		protected SQLiteConnection Context {
			get {
				return _context;
				}
			set {
				_context = value;
				}
			}

		#endregion

		#region IGenericReadOnlyRepository implementation

		public IEnumerable<T> GetAll() {
			lock (Locker) {
				return Context.Table<T>();
				}
			}

		public IEnumerable<T> Find(Expression<Func<T, bool>> predicate) {
			lock (Locker) {
				return Context.Table<T>().Where(predicate);
				}
			}

		public T GetById(TKey id) {
			lock (Locker) {
				return Context.Get<T>(id);
				}
			}

		#endregion
		}
	}
