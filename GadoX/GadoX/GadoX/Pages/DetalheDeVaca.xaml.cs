using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GadoX.ViewModels;

using Xamarin.Forms;

namespace GadoX.Pages {
    public partial class DetalheDeVaca : ContentPage {
        public DetalheDeVaca(Gado Vaca) {
            BindingContext = new DetalheDeVacaViewModel(Vaca, Navigation);
            InitializeComponent();
        }
    }
}
