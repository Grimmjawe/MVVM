using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Vytas_Project
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Coupon : ContentPage
    {
        public Coupon()
        {
            InitializeComponent();
            var a1 = new TapGestureRecognizer();
            a1.Tapped += A1_Tapped;
            on1.GestureRecognizers.Add(a1);
            var a2 = new TapGestureRecognizer();
            a2.Tapped += A2_Tapped;
            on2.GestureRecognizers.Add(a2);
            var a3 = new TapGestureRecognizer();
            a3.Tapped += A3_Tapped;
            on3.GestureRecognizers.Add(a3);
        }

        private void A1_Tapped(object sender, System.EventArgs e)
        {
            Button_Clicked(1);
            on1.IsVisible = false;
        }

        private void A2_Tapped(object sender, System.EventArgs e)
        {
            Button_Clicked(2);
            on2.IsVisible = false;
        }

        private void A3_Tapped(object sender, System.EventArgs e)
        {
            Button_Clicked(3);
            on3.IsVisible = false;
        }

        private async void Button_Clicked(int id)
        {
            await Navigation.PushModalAsync(new CouponPack(id));
        }
    }
}