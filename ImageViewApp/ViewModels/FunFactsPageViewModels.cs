using Azure;
using Azure.AI.OpenAI;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ImageViewApp.ViewModels;
using ImageViewApp.Services;
using ImageViewApp.Views;
using ImageViewApp.Services.Interfaces;

namespace ImageViewApp.ViewModels
{
    public partial class FunFactsPageViewModel : BaseViewModel
    {
        private IYodaService _helper;

        private ChatMessage _response;

        public ChatMessage Response
        {
            get { return _response; }
            set
            {
                _response = value;

                OnPropertyChanged();
            }
        }

        public FunFactsPageViewModel(IYodaService helper)
        {
            _helper = helper;
        }

        [RelayCommand]
        public async void GetResponses()
        {
            Response = await _helper.GetCompletion();
        }
    }
}