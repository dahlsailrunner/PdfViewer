using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;

namespace PdfViewer.ViewModels
{
    public class MainPageViewModel: BindableBase
    {
        private INavigationService _navService;
        public DelegateCommand ShowBill { get; set; }
        public DelegateCommand ShowSample { get; set; }

        private string _mainText;

        public string MainText
        {
           get { return _mainText; }
            set { SetProperty(ref _mainText, value); }
        }

        public MainPageViewModel(INavigationService navigationService)
        {
            _navService = navigationService;
            ShowBill = new DelegateCommand(NavigateToBill);
            ShowSample = new DelegateCommand(NavigateToSample);
            MainText = "Welcome to Main Page";

        }

        private void NavigateToBill()
        {
            _navService.Navigate("ViewBillPage");
        }
        private void NavigateToSample()
        {
            _navService.Navigate("SampleView");
        }
    }
}
