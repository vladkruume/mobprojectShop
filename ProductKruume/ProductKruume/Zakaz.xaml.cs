using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProductKruume
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Zakaz : ContentPage
    {
        StackLayout stackLayout;
        Entry Name, Adress;
        Button Zakazat;
        Label Zakazz ,Namez,Adressz;
        public Zakaz()
        {
            
            Name = new Entry();
            Zakazz = new Label();
            
            Namez = new Label();
            Namez.Text = "Имя";
            Adressz = new Label();
            Adressz.Text = "Адрес";
            Zakazz.IsVisible = false;
            Zakazat = new Button();
            Zakazat.Text = "Заказать";
            Zakazat.BackgroundColor = Color.FromHex("#76A21E");
            Adress = new Entry();

            stackLayout = new StackLayout()
            {
                Children = { Namez,Name,Adressz, Adress,Zakazat,Zakazz }
            };
            

            stackLayout.Spacing = 15;
            ScrollView scrollView = new ScrollView();
            scrollView.Content = stackLayout;
            this.Content = scrollView;
            Zakazat.Clicked += Zakazat_Clicked;


        }

        private void Zakazat_Clicked(object sender, EventArgs e)
        {
            Zakazz.IsVisible = true;
            Zakazz.Text = Name.Text+" ,ваш заказ будет доставлен по адресу "+Adress.Text+" .Оплата курьеру!";
            Name.IsVisible = false;
            Adress.IsVisible = false;
            Namez.IsVisible = false;
            Adressz.IsVisible = false;
            Zakazat.IsVisible = false;
            
        }
    }
    }
