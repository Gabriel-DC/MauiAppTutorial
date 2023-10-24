namespace MauiAppTutorial;

public partial class MinhaPagina : ContentPage
{
	public MinhaPagina()
	{
		InitializeComponent();
	}

	private async void Button_OnClicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new MainPage());
	}
}