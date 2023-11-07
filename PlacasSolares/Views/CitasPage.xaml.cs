using PlacasSolares.Models.Entities;

namespace PlacasSolares.Views;

public partial class CitasPage : ContentPage
{
	public CitasPage()
	{
        Cliente cliente = new Cliente();
        InitializeComponent();
        Lista.ItemsSource = listaClientes.ListadoClientes();
    }

    private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new DetallesPage());
    }
}