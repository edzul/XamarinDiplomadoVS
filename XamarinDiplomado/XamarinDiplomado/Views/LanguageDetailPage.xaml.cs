using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using XamarinDiplomado.Models;

namespace XamarinDiplomado.Views
{
    public partial class LanguageDetailPage : ContentPage
    {
        public Language Language { get; set; }
        public LanguageDetailPage(Language language)
        {
            Language = language;
            BindingContext = Language;
            InitializeComponent();
        }
    }
}
