using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProductKruume
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainMaso : ContentPage
    {
        int cena=0;
        int cenax = 0;
        int i;
        public MainMaso()
        {
            InitializeComponent();
            
            var korzina = (KorzinaTable)BindingContext;
            int i = (int)kol.Value;
            masocena.Text = Convert.ToString(cena)+"€/kg";
            showkol.Text = Convert.ToString(i + "kg");
        }
        private void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            switch (picker.SelectedItem)
            {
                case "Говядина": imagemaso.Text = "govadina.jpg"; masoimage.Source = "govadina.jpg"; masoname.Text = "Говядина";cena = 7; break;
                case "Свинина": imagemaso.Text = "svinina.jpg"; masoimage.Source = "svinina.jpg"; masoname.Text = "Свинина"; cena = 3; break;
                case "Курица": imagemaso.Text = "kurica.jpg"; masoimage.Source = "kurica.jpg"; masoname.Text = "Курица"; cena = 2; break;
                case "Индейка": imagemaso.Text = "indeika.jpg"; masoimage.Source = "indeika.jpg"; masoname.Text = "Индейка"; cena = 3; break;
                case "Утка": imagemaso.Text = "utka.jpg"; masoimage.Source = "utka.jpg"; masoname.Text = "Утка"; cena = 4; break;
                case "Рыба": imagemaso.Text = "riba.jpg"; masoimage.Source = "riba.jpg"; masoname.Text = "Рыба"; cena = 6; break;
            }
            masocena.Text = Convert.ToString(cena) + "€/kg";
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            
            var korzina = (KorzinaTable)BindingContext;
            Class.buy=Class.buy + korzina.Pricee;
            if (!String.IsNullOrEmpty(korzina.Name))
            {
                App.Database.SaveItem(korzina);
            }
            
            this.Navigation.PopAsync();
        }

        private void Stepper_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            int i = (int)kol.Value;
            showkol.Text= Convert.ToString( i+ "kg");           
            cenax = i * cena;
            masocena.Text = Convert.ToString(cenax + "€/kg");
            cenax = 0;
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            var korzina = (KorzinaTable)BindingContext;
            App.Database.DeleteItem(korzina.Id);
            this.Navigation.PopAsync();
        }
    }
}