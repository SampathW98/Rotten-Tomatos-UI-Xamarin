using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: ExportFont("OpenSans-Bold.ttf", Alias = "BoldFont")]
[assembly: ExportFont("OpenSans-Regular.ttf", Alias = "RegularFont")]
[assembly: ExportFont("OpenSans-Light.ttf", Alias = "LightFont")]

namespace RottenUI
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            MainPage = new NavigationPage(new MainPage());

        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
