using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GadoX.ViewModels;

using Xamarin.Forms;

namespace GadoX.Pages {
    public partial class ControleDeParicaoPage : ContentPage {
        public ControleDeParicaoPage() {
            BindingContext = new ControleDeParicaoViewModel(Navigation);
            InitializeComponent();

            VacasGrid.SelectionChanged += VacasGrid_SelectionChanged;

        }

        private async void VacasGrid_SelectionChanged(object sender, Syncfusion.SfDataGrid.XForms.GridSelectionChangedEventArgs e) {
            await Navigation.PushAsync(new DetalheDeVaca(e.AddedItems[0] as Gado));
        }
    }
}
