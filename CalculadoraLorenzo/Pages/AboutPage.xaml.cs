using Android.Accounts;
using CalculadoraLorenzo.Models;

namespace CalculadoraLorenzo.Pages;

public partial class AboutPage : ContentPage
{
    private UsuarioModel _usuario;
    int _count;
    public AboutPage(int count, UsuarioModel usuario)
	{
		InitializeComponent();
        _usuario = usuario;
        _count = count;
    }
   
    private async void btnPerson_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ProfilePage(_count, _usuario));
    }
    private async void btnAbout_Clicked(object sender, EventArgs e)
    {

    }

    private async void btnCal_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new HomePage(_usuario));
    }
}