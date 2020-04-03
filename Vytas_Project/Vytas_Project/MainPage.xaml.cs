using Xamarin.Forms;

namespace Vytas_Project
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Btn_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new Pack(), false);
        }

        private async void btn_Clicked_1(object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new Coupon(), false);
        }
    }
}
