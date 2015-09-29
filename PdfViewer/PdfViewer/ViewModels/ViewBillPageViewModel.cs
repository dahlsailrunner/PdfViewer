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
            WebSource = "https://www.expensesmart.com/imageview.aspx?barcode=06528683557&clientid=2319";
            //WebSource = "http://www.google.com";
        }
    }
}
