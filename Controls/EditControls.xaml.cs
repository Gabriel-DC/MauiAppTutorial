namespace MauiAppTutorial.Controls;

public partial class EditControls : ContentPage
{
	public EditControls()
	{
		InitializeComponent();
        this.BindingContext = this;
        this.IsBusy = false;
        BtnLogin.Clicked += BtnLogin_Clicked;
	}

    private async void BtnLogin_Clicked(object sender, EventArgs e)
    {
        this.IsBusy = true;

        await Task.Delay(8000);

        Application.Current.MainPage =
            new NavigationPage(new MainPage());
    }

    private void Entry1_TextChanged(object sender, TextChangedEventArgs e)
    {
        
    }

    private void Entry1_Completed(object sender, EventArgs e)
    {

    }

    private async void Button1_Clicked(object sender, EventArgs e)
    {
        //await ProgressBar.ProgressTo(0.9, 2000, Easing.Linear);
    }
}