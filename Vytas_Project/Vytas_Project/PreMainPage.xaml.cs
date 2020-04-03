using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Vytas_Project
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PreMainPage : ContentPage
    {
        public PreMainPage()
        {
            InitializeComponent();
            var tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.Tapped += (s, e) => {
                Application.Current.MainPage = new NavigationPage(new MainPage());
            };
            SL.GestureRecognizers.Add(tapGestureRecognizer);
        }
    }
}