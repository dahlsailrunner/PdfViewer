using Prism.Mvvm;
using Prism.Navigation;

namespace PdfViewer.ViewModels
{
    public class ViewBillPageViewModel :BindableBase, INavigationAware
    {
        private string _webSource;

        public string WebSource
        {
            get { return _webSource;}
            set { SetProperty(ref _webSource, value); }
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
            //throw new NotImplementedException();
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            WebSource = "http://www.google.com";
        }
    }
}
