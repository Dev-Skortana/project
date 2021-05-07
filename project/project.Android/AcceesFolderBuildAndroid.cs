using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using project;
using project.Droid;
using Xamarin.Forms;

[assembly: Dependency(typeof(AcceesFolderBuildAndroid))]

namespace project.Droid
{
    class AcceesFolderBuildAndroid:IAcceesFolderBuild
    {
        public Task<String> get_path_folder_build()
        {
            var path_folder = Android.OS.Environment.GetExternalStoragePublicDirectory(Android.OS.Environment.DirectoryDocuments).AbsolutePath;           
            return Task.FromResult(path_folder);
        }

    }
}