using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using GadoX.Pages;

namespace GadoX.ViewModels {
    class DetalheDeVacaViewModel : BaseViewModel {
        public DetalheDeVacaViewModel(Gado Vaca, INavigation navigation) : base(navigation) {
            _vacaSelecionada = Vaca;

            var connection = new UnityOfWork();
            _filhosDaVacaSelecionada = connection.GadoRepository.Find(e => e.IdVacaMae == _vacaSelecionada.IDGado).ToList();
        }

        private List<Gado> _filhosDaVacaSelecionada;
        private Gado _vacaSelecionada;
        private string _idadeDaVacaText;
        private string _totalDeCriasText;
        private string _totalDeMortesText;
        private string _intervaloMedioText;
        private Command _novaParicaoCommand;

        public List<Gado> FilhosDaVacaSelecionada {
            get {
                return _filhosDaVacaSelecionada;
            }
            set {
                _filhosDaVacaSelecionada = value;
            }
        }

        public Gado VacaSelecionada {
            get {
                return _vacaSelecionada;
            }
            set {
                _vacaSelecionada = value;
            }
        }

        public string NumeracaoDaVaca {
            get {
                return ("Vaca nº " + _vacaSelecionada.Numeracao);
            }
        }

        public string IdadeDaVacaText {
            get {
                return ("Idade: " + _idadeDaVacaText);
            }
            set {
                _idadeDaVacaText = value;
            }
        }
        public string TotalDeCriasText {
            get {
                return _totalDeCriasText;
            }
            set {
                _totalDeCriasText = value;
            }
        }
        public string TotalDeMortesText {
            get {
                return _totalDeMortesText;
            }
            set{
                _totalDeMortesText = value;
            }
        }
        public string IntervaloMedioText {
            get {
                return _intervaloMedioText;
            }
            set {
                _intervaloMedioText = value;
            }
        }

        public Command NovaParicaoCommand {
            get {
                return _novaParicaoCommand ?? (_novaParicaoCommand = new Command((obj) => AdicionaNovaParicao(obj)));
            }
        }

        public async void AdicionaNovaParicao(Object obj) {
            await Navigation.PushAsync(new NovaParicao(VacaSelecionada));
        }
    }
}
