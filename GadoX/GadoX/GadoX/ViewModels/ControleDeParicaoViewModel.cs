using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using GadoX.Pages;

namespace GadoX.ViewModels {
    class ControleDeParicaoViewModel : BaseViewModel {
        public ControleDeParicaoViewModel(INavigation navigation) : base(navigation) {
            var connection = new UnityOfWork();
            
            _numeroDeVacas = connection.GadoRepository.Find(e => e.Genero == Sexo.Fêmea).Count();
            _totalDeVacasText = ("Total de vacas: " + _numeroDeVacas);
            _listaDeVacas = connection.GadoRepository.Find(e => e.Genero == Sexo.Fêmea && e.Numeracao != null).ToList();
        }

        private List<Gado> _listaDeVacas;
        private string _totalDeVacasText;
        private int _numeroDeVacas;
        private Command _abreDetalheDeVada;
        
        public List<Gado> ListaDeVacas {
            get {
                return _listaDeVacas;
            }
            set {
                _listaDeVacas = value;
            }
        }
        public string TotalDeVacasText {
            get {
                return _totalDeVacasText;
            }
            set {
                _totalDeVacasText = value;
            }
        }

        public int NumeroDeVacas {
            get {
                return _numeroDeVacas;
            }
            set {
                _numeroDeVacas = value;
            }
        }
        public Command AbreDetalheDeVacaCommand {
            get {
                return _abreDetalheDeVada ?? (_abreDetalheDeVada = new Command((obj) => AbreDetalheDeVaca(obj)));
            }
        }

        private async void AbreDetalheDeVaca(object obj) {
            await Navigation.PushAsync(new DetalheDeVaca(obj as Gado));
        }
    }
}
