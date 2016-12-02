using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using XamarinDiplomado.Models;
using Xamarin.Forms;
using System.Collections.ObjectModel;

namespace XamarinDiplomado.ViewModels
{
    public class LanguagesVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public ObservableCollection<Language> Items { get; set; }
        private AzureClient _azureClient;
        private bool _isBusy;
        public Command GetLanguagesCommand { get; set; }

        public LanguagesVM()
        {
            _azureClient = new AzureClient();
            Items = new ObservableCollection<Language>();
            GetLanguagesCommand = new Command(() => Load(), () => !IsBusy);
        }


        public bool IsBusy
        {
            get { return _isBusy; }
            set
            {
                _isBusy = value;
                OnPropertyChanged();
                GetLanguagesCommand.ChangeCanExecute();
            }
        }

        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public async void Load()
        {
            var result = await _azureClient.GetLanguages();
            Items.Clear();

            foreach (var lang in result)
            {
                Items.Add(lang);
            }

            IsBusy = false;
        }

    }
}
