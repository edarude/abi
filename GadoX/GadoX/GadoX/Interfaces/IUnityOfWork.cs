using System;
namespace GadoX {
	public interface IUnityOfWork {
        //comitar tabela
        void Commit();

		//rollback is an operation which returns the database to some previous state
		void Rollback();

		//sair de tabela
		void Dispose();
	}
}
