using SQLite.Net.Attributes;
using System;
namespace GadoX {
	public class Gado {
		[PrimaryKey]
		public int IDGado {
			get;
			set;
		}

		public int MesDeNascimento {
			get;
			set;
		}

		public int AnoDeNascimento {
			get;
			set;
		}

		public Sexo Genero {
			get;
			set;
		}

		public int? Numeracao {
			get;
			set;
		}

		public int IdVacaMae {
			get;
			set;
		}

		public int IDSituacao {
			get;
			set;
		}

		public bool IsTouro {
			get;
			set;
		}

        public int NumeroDeCrias {
            get;
            set;
        }
    }
}
