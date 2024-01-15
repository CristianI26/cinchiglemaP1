namespace cinchiglemaP1.Vistas;

public partial class Login : ContentPage
{
    public Login()
    {
        InitializeComponent();
    }

    private void btnIniciar_Clicked(object sender, EventArgs e)
    {
        string usuario = txtUsuario.Text;
        string contrasena = txtContrasena.Text;
        if (txtUsuario.Text == "estudiante2024" && "uisrael2024" == contrasena)
        {
            DisplayAlert("Bienvenido", "Usuario : " + usuario, "OK");
            Navigation.PushAsync(new Vistas.Registro(usuario));
        }
        if (txtUsuario.Text == "examen1" && txtContrasena.Text == "parcial1")
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