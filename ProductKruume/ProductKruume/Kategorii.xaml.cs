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
    public partial class Kategorii : ContentPage
    {
        StackLayout stackLayout;
        ImageButton masoK, MolocnieK;
        public Kategorii()
        {
            masoK = new ImageButton()
            {
                Source = ("vidy_miasa.jpg"),
                Margin = new Thickness(70, 50, 70, 0),
            };
            MolocnieK = new ImageButton()
            {
                Source = ("molocnie.jpg"),
                Margin = new Thickness(70, 50, 70, 0),
            };
          
            stackLayout = new StackLayout()
            {
                Children = { masoK, MolocnieK}
            };
            masoK.Clicked += MasoK_ClickedAsync;
            MolocnieK.Clicked += MolocnieK_ClickedAsync;

            stackLayout.Spacing = 15;
            ScrollView scrollView = new ScrollView();
            scrollView.Content = stackLayout;
            this.Content = scrollView;
        }

        private async void MolocnieK_ClickedAsync(object sender, EventArgs e)
        {
            KorzinaTable korzina = new KorzinaTable();
            MolokoPage molokoPagee = new MolokoPage();
            molokoPagee.BindingContext = korzina;
            await Navigation.PushAsync(molokoPagee);
        }

        private async void MasoK_ClickedAsync(object sender, EventArgs e)
        {

            KorzinaTable korzina = new KorzinaTable();
            MainMaso masoPage = new MainMaso();
            masoPage.BindingContext = korzina;
            await Navigation.PushAsync(masoPage);
        }
    }
}