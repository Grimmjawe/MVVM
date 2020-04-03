using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Vytas_Project
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Pack : ContentPage
    {
        MainPage manu;
        public Pack()
        {
            InitializeComponent();
            Set();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            Set();
            await Navigation.PushModalAsync(new Korzina());
        }

        void Set()
        {
            Change(1, "Cheeseburger Spicy", Convert.ToInt16(lbl1.Text));
            Change(2, "Cheeseburger Or", Convert.ToInt16(lbl2.Text));
            Change(3, "Grand Texas Zinger", Convert.ToInt16(lbl3.Text));
        }

        private void Change(int v, string name, int c)
        {
            var food = new Data();
            food.Id = v;
            food.index = name;
            food.count = c;
            App.Database.SaveItem(food);
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            lbl1.Text = (Convert.ToInt16(lbl1.Text) < 4) ? (Convert.ToInt16(lbl1.Text) + 1).ToString() : "5";
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            lbl1.Text = (Convert.ToInt16(lbl1.Text) > 0) ? (Convert.ToInt16(lbl1.Text) - 1).ToString() : "0";
        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            lbl2.Text = (Convert.ToInt16(lbl2.Text) < 4) ? (Convert.ToInt16(lbl2.Text) + 1).ToString() : "5";
        }

        private void Button_Clicked_4(object sender, EventArgs e)
        {
            lbl2.Text = (Convert.ToInt16(lbl2.Text) > 0) ? (Convert.ToInt16(lbl2.Text) - 1).ToString() : "0";
        }

        private void Button_Clicked_5(object sender, EventArgs e)
        {
            lbl3.Text = (Convert.ToInt16(lbl3.Text) < 4) ? (Convert.ToInt16(lbl3.Text) + 1).ToString() : "5";
        }

        private void Button_Clicked_6(object sender, EventArgs e)
        {
            lbl3.Text = (Convert.ToInt16(lbl3.Text) > 0) ? (Convert.ToInt16(lbl3.Text) - 1).ToString() : "0";
        }
    }
}