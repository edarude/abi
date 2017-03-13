using System;
using Xamarin.Forms;
using SQLite.Net;
using System.Linq;

namespace GadoX {
	public class PainelPrincipalViewModel : BaseViewModel {
		public PainelPrincipalViewModel(INavigation navigation) : base(navigation) {
			var connect = new UnityOfWork();

			_totalDeVacas = connect.GadoRepository.Find(e => e.Genero == Sexo.Fêmea).Count();

		}

		private int _totalDeVacas;
		private Gado _gadoLocal;

		public int TotalDeVacas {
			get{
				return _totalDeVacas;
			}
			set{
				_totalDeVacas = value;
			}
		}
		public Gado GadoLocal {
			get{
				return _gadoLocal;
			}
			set{
				_gadoLocal = value;
				OnPropertyChanged("GadoLocal");
			}
		}

	}
}
