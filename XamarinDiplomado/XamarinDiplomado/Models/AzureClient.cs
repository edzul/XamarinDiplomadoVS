using Microsoft.WindowsAzure.MobileServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//GIT REPO: https://github.com/edzul/XamarinDiplomadoVS
namespace XamarinDiplomado.Models
{
    public class AzureClient
    {
        private IMobileServiceClient _azureClient;
        private IMobileServiceTable<Language> _table;

        public AzureClient()
        {
            _azureClient = new MobileServiceClient("http://midemo.azurewebsites.net");
            _table = _azureClient.GetTable<Language>();
        }

        public Task<IEnumerable<Language>> GetLanguages()
        {
            return _table.ToEnumerableAsync();
        }
    }
}
