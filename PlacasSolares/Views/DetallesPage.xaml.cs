using System.Threading.Tasks;

namespace PlacasSolares.Views;

public partial class DetallesPage : ContentPage
{
	public DetallesPage()
	{
		InitializeComponent();
	}

    private void añadirFoto(object sender, EventArgs e)
    {
    }
    private async void Guardar(object sender, EventArgs e)
	{
        CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
        //await Toast.Make("Howdy, I'm a Toast!",
        //          ToastDuration.Long,
        //          16)
        //    .Show(cancellationTokenSource.Token);
    }
}