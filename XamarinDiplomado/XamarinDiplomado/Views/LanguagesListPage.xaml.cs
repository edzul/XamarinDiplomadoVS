using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using XamarinDiplomado.Models;

namespace XamarinDiplomado.Views
{
    public partial class LanguagesListPage : ContentPage
    {
        public LanguagesListPage()
        {
            InitializeComponent();
            lvwItems.ItemSelected += Language_Selected; 
        }

        private async void Language_Selected(object sender, SelectedItemChangedEventArgs e)
        {
            var selectedLanguage = e.SelectedItem as Language;

            if (selectedLanguage != null)
            {
                await Navigation.PushAsync(new Views.LanguageDetailPage(selectedLanguage));
                lvwItems.SelectedItem = null;
            }
        }
    }
}
