using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace GadoX.Pages {
    public partial class NovaParicao : ContentPage {
        public NovaParicao(Gado VacaSelecionada) {
            InitializeComponent();

            PickerDeSexo.SelectedIndex = 1;
            PickerDeSexo.Items.Add("Macho");
            PickerDeSexo.Items.Add("Fêmea");
            
            
        }
    }
}
