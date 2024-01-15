namespace cinchiglemaP1.Vistas;

public partial class Login : ContentPage
{
    public Login()
    {
        InitializeComponent();
    }

    private void btnIniciar_Clicked(object sender, EventArgs e)
    {
        string usuario = "estudiante2024";
        string contrasena = "uisrael2024";
        if (txtUsuario.Text == usuario && txtContrasena.Text == contrasena)
        {
            DisplayAlert("Bienvenido", "Usuario : " + usuario, "OK");
            Navigation.PushAsync(new Vistas.Registro(usuario));
        }
        else

        {
            DisplayAlert("alerta", "Credenciales incorectas", "Cancel");
        }
    }

    private void btnAcerca_Clicked(object sender, EventArgs e)
    {
        DisplayAlert("Trabajo realizado por: ", "Cristian Inchiglema", "Cancelar");
    }
}