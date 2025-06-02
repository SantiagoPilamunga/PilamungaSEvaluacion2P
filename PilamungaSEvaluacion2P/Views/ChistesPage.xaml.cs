using PilamungaSEvaluacion2P.Repository;

namespace PilamungaSEvaluacion2P.Views;

public partial class ChistesPage : ContentPage
{
    private readonly ChistesRepository ChisteRepository = new();
    public ChistesPage()
	{
		InitializeComponent();
		GenerarChiste();
	}
    private async void GenerarChiste()
    {
        Chistetxt.Text = "Chiste";
        try
        {
            var Chiste = await ChisteRepository.ObtenerChiste();
            Chistetxt.Text = $"{Chiste.Setup}\n\n{Chiste.Punchline}";
        }
        catch
        {
            Chistetxt.Text = "No se pudo cargar el chiste.";
        }
    }
    private void OtroChisteBtn_Clicked(object sender, EventArgs e)
    {
        GenerarChiste();
    }
}