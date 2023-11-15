using MauiAppTutorial.Models;

namespace MauiAppTutorial.Controls;

public partial class NotifyBinding : ContentPage
{
	Produto product = new();

	public NotifyBinding()
	{
		InitializeComponent();
		product = new Produto
		{
			Nome = "Iphone 5",
			Preco = 5000m,
			Estoque = 5
		};

		BindingContext = product;
	}

    private async void BtnAtualiza_Clicked(object sender, EventArgs e)
    {
		product.Nome = "Galaxy SamSung 10";
		product.Estoque = 3;
		product.Preco = 2000m;

		await DisplayAlert("Produto Atualizado",
			$"{product.Nome} - {product.Preco} - {product.Estoque}", "OK");
    }
}