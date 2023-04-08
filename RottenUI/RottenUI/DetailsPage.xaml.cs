using RottenUI.Model;
using RottenUI.ViewModel;
using SkiaSharp;
using SkiaSharp.Views.Forms;
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
			this.BindingContext = myMovie;
			InitializeComponent ();
            //Title = myMovie.Title;
			
		}
        /*
        private void SKCanvasView_PaintSurface(object sender, SkiaSharp.Views.Forms.SKPaintSurfaceEventArgs args)
        {
            SKImageInfo info = args.Info;
            SKSurface surface = args.Surface;
            SKCanvas canvas = surface.Canvas;

            canvas.Clear();

            using (SKPaint paint = new SKPaint())
            {
                // define the color for the shadow
                SKColor shadowColor = Color.FromHex("#5ACB6E").ToSKColor();

                paint.IsDither = true;
                paint.IsAntialias = true;
                paint.Color = shadowColor;

                // create filter for drop shadow
                paint.ImageFilter = SKImageFilter.CreateDropShadow(
                    dx: 0, dy: 0, sigmaX: 40, sigmaY: 40, color: shadowColor, shadowMode: SKDropShadowImageFilterShadowMode.DrawShadowOnly);


                    //dx: 0, dy: 0,
                    //sigmaX: 40, sigmaY: 40,
                    //color: shadowColor,
                    //shadowMode: SKDropShadowImageFilterShadowMode.DrawShadowOnly);
            }
        }*/
    }
}