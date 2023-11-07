namespace PlacasSolares
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnClicked(object sender, EventArgs e)
        {
          if(IngresaUsuario.Text !=  null && IngresaContraseña.Text != null) 
          {
                await Navigation.PushAsync(new AppShell());
            }
        }
    }
}