using Foundation;
using ListRendererTest.iOS.Renderers;
using ListRendererTest.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(RotatedListView), typeof(RotatedListViewRenderer))]
namespace ListRendererTest.iOS.Renderers
{
    class RotatedListViewRenderer : ListViewRenderer
    {
    }
}