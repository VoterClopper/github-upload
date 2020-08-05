using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Embedded_Files
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            var source = new HtmlWebViewSource();
            source.BaseUrl = DependencyService.Get<IBaseUrl>().Get();

            string fileName = Path.Combine(source.BaseUrl, "UserGuideTest.htm");
            //string fileName = Path.Combine(source.BaseUrl, "HTMLPage1.html");
            //xlabelembed.Text = fileName;

            source.Html = fileName;

            xwebview1.Source = source.Html;

            //string text = File.ReadAllText(fileName);
            //xlabelembed.Text = text;

            //private string _fileName { get; set; }

        //public string FileFullPath
        //{
        //    get
        //    {
        //        return Path.Combine(Android.OS.Environment.GetExternalStoragePublicDirectory(Android.OS.Environment.DirectoryPictures), _fileName);
        //    }
        //}


    }
    }
}
