using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using project;
using project.Droid;
using Xamarin.Forms;
using System.Threading.Tasks;
using System.IO;

[assembly: Dependency(typeof(AcceesFontAndroid))]
namespace project.Droid
{
    class AcceesFontAndroid:IAcceesFont
    {
        public Task<String> get_path_folder_font_in_document_build()
        {
            var path_folder = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "Font");
            if (!Directory.Exists(path_folder))
            {
                Directory.CreateDirectory(path_folder);
            }

                using (var br = new BinaryReader(Android.App.Application.Context.Assets.Open($"Font/Trebuchet_MS.ttf")))
                {
                    using (var bw = new BinaryWriter(new FileStream($"{path_folder}/Trebuchet_MS.ttf", FileMode.OpenOrCreate)))
                    {
                        byte[] buffer = new byte[2048];
                        int length = 0;
                        while ((length = br.Read(buffer, 0, buffer.Length)) > 0)
                        {
                            bw.Write(buffer, 0, length);
                        }
                    }
                }
            
            return Task.FromResult(path_folder);
        }
    }
}