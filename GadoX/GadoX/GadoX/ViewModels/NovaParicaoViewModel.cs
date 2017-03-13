using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GadoX.ViewModels {
    class NovaParicaoViewModel : BaseViewModel {
        public NovaParicaoViewModel(Gado VacaMae, INavigation navigation) : base(navigation) {

        }

        private Gado _novoGado;
        private bool _isMorto;
        private DateTime _dataDeNascimento;
        private string _observacoesDaParicao;

    }
}
