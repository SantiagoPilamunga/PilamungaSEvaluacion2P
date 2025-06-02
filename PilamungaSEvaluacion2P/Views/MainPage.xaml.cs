using PilamungaSEvaluacion2P.Views;

namespace PilamungaSEvaluacion2P
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }


        private void ChistesBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ChistesPage());
        }

        private void AboutBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AboutPage());
        }
    }

}
