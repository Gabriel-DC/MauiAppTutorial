using MauiAppTutorial.Models;

namespace MauiAppTutorial.Controls;

public partial class CollectionControls : ContentPage
{
	public CollectionControls()
	{
		InitializeComponent();
		BindingContext = new FotoViewModel();
	}

    private async void AlertaCinto_OnChanged(object sender, ToggledEventArgs e)
    {
		await DisplayAlert("Alerta Cinto Segurança",
			"Você selecionou/deselecionou este acessório", "OK");
    }
}