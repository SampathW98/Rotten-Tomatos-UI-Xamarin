using RottenUI.Model;
using RottenUI.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RottenUI
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DetailsPage : ContentPage
	{
        public DetailsPage (Movie myMovie)
		{
			InitializeComponent ();
            Title = myMovie.Title;
		}

        /*public DetailsPage(Movie movie)
        {
            Movie = movie;
        }*/


    }
}