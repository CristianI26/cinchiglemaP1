namespace cinchiglemaP1.Vistas;

public partial class Resumen : ContentPage
{
	public Resumen(string usuario)
	{
		InitializeComponent();
        lblusuario.Text = "El usuario conectado es;" + usuario;
    }
}