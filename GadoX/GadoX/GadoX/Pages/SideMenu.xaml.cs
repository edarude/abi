using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace GadoX {
	public partial class SideMenu : MasterDetailPage {
		public SideMenu() {
			InitializeComponent();

			Detail = new NavigationPage(new PainelPrincipal());
		}
	}
}
