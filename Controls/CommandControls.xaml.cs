namespace MauiAppTutorial.Controls;

public partial class CommandControls : ContentPage
{
	public CommandControls()
	{
		InitializeComponent();
	}

    private async void BtnDemo_Clicked(object sender, EventArgs e)
    {
		await LblDemo.RelRotateTo(360, 2000);
		await DisplayAlert("Button", "Tarefa concluída", "Ok");
    }

    private async void BtnImageDemo_Clicked(object sender, EventArgs e)
    {
        await LblDemo.RelRotateTo(360, 5000);
    }

    private async void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        RadioButton selectedRadioButton = sender as RadioButton;

        if (LblSelectedPet is not null)
        {
            LblSelectedPet.Text = $"Selecionou: {selectedRadioButton.Value}!";
            LblSelectedPet.FontSize = 20;
        }
    }

    private async void SwipeItem_Invoked(object sender, EventArgs e)
    {
        await DisplayAlert("SwipeView", "Elemento tocado", "Ok");
    }
}