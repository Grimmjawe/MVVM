using System;
using System.Collections.Generic;
using System.Net.Mail;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Vytas_Project
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Korzina : ContentPage
    {
        double cost;
        IList<Data> list2;
        IEnumerable<Data> list;
        public Korzina()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            (list, cost, list2) = App.Database.GetItems();
            foodlist.ItemsSource = list;
            Cost.Text = "Total: " + Convert.ToString(cost) + "€";
            base.OnAppearing();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            SendMail("kfcapptest@gmail.com");
            if(mail.Text.Trim() != "")
            {
                SendMail(mail.Text);
            }
            await Navigation.PopModalAsync();
        }

        private void SendMail(string email)
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            mail.From = new MailAddress("kfcapptest@gmail.com");
            mail.To.Add(email);
            mail.Subject = "KFC Order";
            string zakaz = "";


            for (int i = 0; i < list2.Count; i++)
            {
                if(list2[i].count != 0)
                {
                    zakaz += list2[i].index + " : " + list2[i].count + "\n";
                }
            }
            zakaz += cost + "€\n";
            if (email != "kfcapptest@gmail.com")
            {
                zakaz += "Статус: готовится";
            }

            mail.Body = zakaz;

            SmtpServer.Port = 587;
            SmtpServer.Host = "smtp.gmail.com";
            SmtpServer.EnableSsl = true;
            SmtpServer.UseDefaultCredentials = false;
            SmtpServer.Credentials = new System.Net.NetworkCredential("kfcapptest@gmail.com", "vytasapptest");
            SmtpServer.Send(mail);
        }
    }
}