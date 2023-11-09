using System.Globalization;

namespace MauiAppTutorial.Controls;

public partial class SetValueControls : ContentPage
{
    public SetValueControls()
    {
        InitializeComponent();        
    }

    private async void CheckBox1_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        await DisplayAlert("CheckBox", e.Value ? "Marcado" : "Desmarcado", "Ok");
    }

    private void Slider1_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        double valor = Math.Round(Slider1.Value, 2);
        LblSlider.Text = valor.ToString();
    }

    private void Stepper1_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        double value = e.NewValue;
        LblStepper.Text = $"Valor do Stepper {value}";
    }

    private async void Switch1_Toggled(object sender, ToggledEventArgs e)
    {
        await DisplayAlert("Switch", e.Value ? "On" : "Off", "Ok");
    }

    private async void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
    {
        CultureInfo culture = new("pt-BR");
        var date = (sender as DatePicker).Date;
        await DisplayAlert("Data Selecionada", date.ToString("d", culture), "Ok");
    }

    private async void Time1_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
    {
        if(Time1 is not null)
        {
            var selectedTime = Time1.Time.ToString(@"hh\:mm");
            await DisplayAlert("Hora Selecionada", selectedTime, "Ok");
        }
    }
}