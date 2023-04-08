using RottenUI.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Xamarin.Forms;

namespace RottenUI
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnItemSelected(object sender, SelectionChangedEventArgs e)
        {
            var myMovie = e.CurrentSelection.FirstOrDefault() as Movie;

            if (myMovie == null)
                return;

            // Navigate to the new page and pass the object
            Navigation.PushAsync(new DetailsPage(myMovie));

            // Deselect the item
            MyCollectionView.SelectedItem = null;
        }
    }
}
