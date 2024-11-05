namespace MauiAppHotel.Views;

public partial class pagamento : ContentPage
{
	public pagamento()
	{
		InitializeComponent();

		pck_pagamento.Items.Add("Pix");
        pck_pagamento.Items.Add("Cartão de crédito");
        pck_pagamento.Items.Add("Cartão de débito");
        pck_pagamento.Items.Add("Boleto");
    }

    private async void BotaoPagar_Clicked(object sender, EventArgs e)
    {
        DisplayAlert("Situação", "Pagamento Efetuado!", "ok");
    }
}