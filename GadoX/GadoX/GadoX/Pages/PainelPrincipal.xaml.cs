using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml.Internals;
using GadoX.Pages;

namespace GadoX {
	public partial class PainelPrincipal : ContentPage {
		public PainelPrincipal() {
			BindingContext = new PainelPrincipalViewModel(Navigation);
			InitializeComponent();

			TotalDeVacas.Text = ((BindingContext as PainelPrincipalViewModel).TotalDeVacas+" Vacas");
		}

		public async void ListaVacas(object sender, EventArgs e){
			await Navigation.PushAsync(new ControleDeParicaoPage());
		}

		//public async void TransfereEquip(Object sender, EventArgs e) {
		//	var view = sender as Image;
		//	var ItemEquip = view.BindingContext;
		//	await Navigation.PushAsync(new TransferenciaPage(ItemEquip as Equipamento));
		//}
		//Xaml: Tapped=""
	}
}
