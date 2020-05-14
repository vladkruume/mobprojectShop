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
    public partial class MolokoPage : ContentPage
    {
        int cena = 0;
        int cenax = 0;
        int i;
        public MolokoPage()
        {
            BackgroundColor = Color.White;
            InitializeComponent();

            var korzina = (KorzinaTable)BindingContext;
            int i = (int)kol.Value;
            masocena.Text = Convert.ToString(cena) + "€/kg";
            showkol.Text = Convert.ToString(i + "kg");
        }
        private void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (picker.SelectedItem)
            {
                case "Молоко": imagemaso.Text = "moloko.jpg"; masoimage.Source = "moloko.jpg"; masoname.Text = "Молоко"; cena = 1; break;
                case "Сливки": imagemaso.Text = "slivki.png"; masoimage.Source = "slivki.png"; masoname.Text = "Сливки"; cena = 2; break;
                case "Сыр": imagemaso.Text = "sir.png"; masoimage.Source = "sir.png"; masoname.Text = "Сыр"; cena = 3; break;
                case "Масло": imagemaso.Text = "maslo.jpg"; masoimage.Source = "maslo.jpg"; masoname.Text = "Масло"; cena = 4; break;
                case "Кефир": imagemaso.Text = "kefir.jpg"; masoimage.Source = "kefir.jpg"; masoname.Text = "Кефир"; cena = 1; break;
            }
            masocena.Text = Convert.ToString(cena) + "€/kg";
        }
        private void Button_Clicked(object sender, EventArgs e)
        {

            var korzina = (KorzinaTable)BindingContext;
            Class.buy = Class.buy + korzina.Pricee;
            if (!String.IsNullOrEmpty(korzina.Name))
            {
                App.Database.SaveItem(korzina);
            }

            this.Navigation.PopAsync();
        }

        private void Stepper_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            int i = (int)kol.Value;
            showkol.Text = Convert.ToString(i + "kg");
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