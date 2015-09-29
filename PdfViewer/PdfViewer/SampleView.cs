using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace PdfViewer
{
    public class SampleView : ContentPage
    {
        public SampleView()
        {
            var viewer = new WebView {Source = "http://www.google.com"};
            Content = viewer;            
        }
    }
}
