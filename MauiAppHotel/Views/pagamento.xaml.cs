namespace MauiAppHotel.Views;

public partial class pagamento : ContentPage
{
	public pagamento()
	{
		InitializeComponent();

		pck_pagamento.Items.Add("Pix");
        pck_pagamento.Items.Add("Cart�o de cr�dito");
        pck_pagamento.Items.Add("Cart�o de d�bito");
        pck_pagamento.Items.Add("Boleto");
    }

    private async void BotaoPagar_Clicked(object sender, EventArgs e)
    {
        DisplayAlert("Situa��o", "Pagamento Efetuado!", "ok");
    }
}