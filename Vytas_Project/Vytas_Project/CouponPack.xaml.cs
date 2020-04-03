using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Vytas_Project
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CouponPack : ContentPage
    {
        int Id;
        public CouponPack(int id)
        {   
            Id = id;
            InitializeComponent();
            lbl.Text = new Random().Next(1000,9999) + "";
        }
    }
}