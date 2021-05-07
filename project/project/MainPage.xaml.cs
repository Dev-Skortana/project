using GemBox.Document;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace project
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            init();
            DocumentModel doc = new DocumentModel();
            doc.DefaultCharacterFormat.FontName = "Trebuchet MS";
            Section page = new Section(doc);
            page.Blocks.Add(new Paragraph(doc,"Hello world"));
            doc.Sections.Add(page);
            var path_file_to_save = Path.Combine(await DependencyService.Get<IAcceesFolderBuild>().get_path_folder_build(), "Document Hello.pdf");
            doc.Save(path_file_to_save);
        }

        private async void init()
        {
            ComponentInfo.SetLicense("FREE-LIMITED-KEY");
            ComponentInfo.FreeLimitReached += (sender, e) => e.FreeLimitReachedAction = FreeLimitReachedAction.ContinueAsTrial;
            FontSettings.FontsBaseDirectory = await DependencyService.Get<IAcceesFont>().get_path_folder_font_in_document_build();
        }
    }
}
