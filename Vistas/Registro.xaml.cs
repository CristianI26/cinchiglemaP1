namespace cinchiglemaP1.Vistas;

public partial class Registro : ContentPage
{
	public Registro(string usuario)
	{
		InitializeComponent();
        lblusuario.Text = "El usuario conectado es;" + usuario;
    }

    private void btnCalculo_Clicked_1(object sender, EventArgs e)
    {
        double monto = 1500 - Convert.ToDouble(txtmontoI.Text);
        double aux2 = monto / 4;
        double pago = aux2 * 1.04;
        // double pago = monto + aux3;
        
        txtpagoM.Text = pago.ToString();
        

    }

    private void btnResumen_Clicked(object sender, EventArgs e)
    {

    }
}