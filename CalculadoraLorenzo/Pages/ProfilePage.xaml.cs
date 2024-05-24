using CalculadoraLorenzo.Models;

namespace CalculadoraLorenzo.Pages;

public partial class ProfilePage : ContentPage
{

    private UsuarioModel _usuario;
    int _count = 0;
    public ProfilePage(int count, UsuarioModel usuario)
	{
		InitializeComponent();
        _usuario = usuario;

        _count = count;

        Contador.Text = count.ToString();

        txtName.Text = _usuario.Name;
        txtEmail.Text = _usuario.Email;
	}

    private async void btnPerson_Clicked(object sender, EventArgs e)
    {

    }
    private async void btnAbout_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AboutPage(_count, _usuario));
    }

    private async void btnCal_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new HomePage(_usuario));
    }
}