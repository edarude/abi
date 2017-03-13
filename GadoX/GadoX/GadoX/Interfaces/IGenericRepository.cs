using System;
using System.Collections.Generic;

namespace GadoX {
	public interface IGenericRepository<T, TKey> : IGenericReadOnlyRepository<T, TKey> where T : new() {
		int Add(T entity);
		int Delete(T entity);
		int Delete(TKey key);
		int Drop();
		int Update(T entity);
		T Create();
		int InsertAll(IEnumerable<T> list);
		int UpdateAll(IEnumerable<T> list);
		int AddOrUpdate(T entity);
		int AddOrUpdateAll(IEnumerable<T> list);
		void CreateTable();
	}
}
