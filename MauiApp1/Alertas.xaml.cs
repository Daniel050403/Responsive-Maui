namespace MauiApp1;

public partial class Alertas : ContentPage
{
	public Alertas()
	{
		InitializeComponent();
	}

    private async void Config_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("Configuracion", true);
    }

    private async void Admin_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("Admistrador", true);

    }

    private async void aler_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("Alertas", true);
    }
}