using MauiAppTutorial.Models;

namespace MauiAppTutorial;

public partial class MinhaPagina : ContentPage
{
	public MinhaPagina()
	{
		InitializeComponent();
	}

  //  private void BtnBind_Clicked(object sender, EventArgs e)
  //  {
		//Produto product = new()
		//{
		//	Nome = "Iphone 5",
		//	Preco = 5000m,
		//	Estoque = 5
		//};

		//Binding nameBinding = new()
		//{
		//	Source = product,
		//	Path = "Nome",
		//	StringFormat = "Produto: {0}"
		//};

  //      Binding priceBinding = new()
  //      {
  //          Source = product,
  //          Path = "Preco",
  //          StringFormat = "Preco: {0}"
  //      };

  //      Binding stockBinding = new()
  //      {
  //          Source = product,
  //          Path = "Estoque",
  //          StringFormat = "Estoque: {0}"
  //      };

  //      LblNome.SetBinding(Label.TextProperty, nameBinding);
  //      LblPreco.SetBinding(Label.TextProperty, priceBinding);
  //      LblEstoque.SetBinding(Label.TextProperty, stockBinding);
  //  }
}