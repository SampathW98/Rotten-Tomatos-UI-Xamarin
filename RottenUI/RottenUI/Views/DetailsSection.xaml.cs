using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RottenUI.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailsSection : ContentView
    {
        int selectionIndex = 0;
        List<Label> tabHeaders = new List<Label>();
        List<VisualElement> tabContent = new List<VisualElement>();

        public DetailsSection()
        {
            InitializeComponent();

            tabHeaders.Add(InfoTab);
            tabHeaders.Add(CastTab);
            tabHeaders.Add(NewsTab);
            tabHeaders.Add(CriticsTab);
            tabHeaders.Add(MediaTab);

            tabContent.Add(InfoContent);
            tabContent.Add(CastContent);
            tabContent.Add(NewsContent);
            tabContent.Add(CriticsContent);
            tabContent.Add(MediaContent);
        }

        private async Task ShowSelection(int newTab)
        {
            if(newTab == selectionIndex) { return; }

            //navigate the selection pill
            var selectdTabLabel = tabHeaders[newTab];
            _ = SelectionUnderline.TranslateTo(selectdTabLabel.Bounds.X, 0, 150, easing:Easing.SinInOut);

            //update style of header
            var unselectedStyle = (Style)Application.Current.Resources["TabLabel"];
            var selectedStyle = (Style)Application.Current.Resources["SelectedTabLabel"];

            tabHeaders[selectionIndex].Style = unselectedStyle;
            selectdTabLabel.Style = selectedStyle;

            //change the actual tabs
            await tabContent[selectionIndex].FadeTo(0);
            tabContent[selectionIndex].IsVisible = false;
            tabContent[newTab].IsVisible = true;
            _ = tabContent[selectionIndex].FadeTo(1);

            selectionIndex = newTab;
        }
         
        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            var tabIndex = tabHeaders.IndexOf((Label)sender);
            await ShowSelection(tabIndex);
        }
    }
}