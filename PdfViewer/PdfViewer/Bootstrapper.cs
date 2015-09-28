using Microsoft.Practices.Unity;
using PdfViewer.Views;
using Prism.Unity;
using Xamarin.Forms;

namespace PdfViewer
{
    public class Bootstrapper : UnityBootstrapper
    {
        protected override Page CreateMainPage()
        {
            return Container.Resolve<MainPage>();
        }
        
        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<ViewBillPage>();
            Container.RegisterTypeForNavigation<SampleView>();
        }
    }
}
