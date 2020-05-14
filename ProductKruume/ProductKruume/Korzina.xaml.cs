using System;
using Xamarin.Forms;


namespace ProductKruume
{

    public partial class Korzina : ContentPage
    {
        
        public Korzina()
        {
            
            InitializeComponent();


            

        }
        protected override void OnAppearing()
        {
            KorzinaList.ItemsSource = App.Database.GetItems();
            base.OnAppearing();
        }

        private async void KorzinaList_ItemSelectedAsync(object sender, SelectedItemChangedEventArgs e)
        {
            KorzinaTable selectedMaso = (KorzinaTable)e.SelectedItem;
            MainMaso MasoPage = new MainMaso();
            MasoPage.BindingContext = selectedMaso;
            await Navigation.PushAsync(MasoPage);
        }

        private async void Button_ClickedAsync(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new Zakaz());
        }
    }
}