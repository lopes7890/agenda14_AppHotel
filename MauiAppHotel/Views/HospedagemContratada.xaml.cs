namespace MauiAppHotel.Views;

public partial class HospedagemContratada : ContentPage
{
	public HospedagemContratada()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		try
		{
			Navigation.PopAsync();
		}
		catch (Exception ex) 
		{
			DisplayAlert("ops", ex.Message, "ok");

		}
    }
	private async void Pagar_Clicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new pagamento()
		{

		});
	}
}