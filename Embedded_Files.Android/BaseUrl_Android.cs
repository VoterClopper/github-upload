﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using Embedded_Files.Droid;

[assembly: Dependency (typeof(BaseUrl_Android))]
namespace Embedded_Files.Droid
{
  
        public class BaseUrl_Android : IBaseUrl
        {
            public string Get()
            {
                return "file:///android_asset/";
            }
        }
}

