using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using Microsoft.Maui.Controls;
using System.Threading.Tasks;

namespace PlacasSolares.Views;

public partial class DetallesPage : ContentPage
{
	public DetallesPage()
	{
		InitializeComponent();
	}

    private async void añadirFoto(object sender, EventArgs e)
    {
        var foto = await MediaPicker.CapturePhotoAsync();
        if (foto != null)
        {
            var memoriaStream = await foto.OpenReadAsync();
            Galeria.Source = ImageSource.FromStream(() => memoriaStream);
            Galeria.MaximumWidthRequest = 100;
            Galeria.MaximumHeightRequest = 100;
        }
    }
    private async void Guardar(object sender, EventArgs e)
	{
        CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
        var toast = Toast.Make("Datos guardados correctamente", ToastDuration.Long, textSize: 32);
        await toast.Show(cancellationTokenSource.Token);
    }

    private void Entry_TextChanged(object sender, TextChangedEventArgs e)
    {
        Editor entry = (Editor)sender;
        string oldText = e.OldTextValue;
        string newText = e.NewTextValue;
        string myText = entry.Text;
    }

    private void Entry_Completed(object sender, EventArgs e)
    {
        string text = ((Editor)sender).Text;    
    }

    private async void Mapa(object sender, TappedEventArgs e)
    {
        var location = new Location(47.645160, -122.1306032);
        var options = new MapLaunchOptions { Name = "Microsoft Building 25" };

        try
        {
            await Map.Default.OpenAsync(location, options);
        }
        catch (Exception ex)
        {
            // No map application available to open
        }
    }
}