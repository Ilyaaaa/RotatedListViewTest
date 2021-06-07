using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using ListRendererTest.Droid.Renderers;
using ListRendererTest.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(RotatedListView), typeof(RotatedListViewRenderer))]
namespace ListRendererTest.Droid.Renderers
{
    class RotatedListViewRenderer : ListViewRenderer
    {
        public RotatedListViewRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.ListView> e)
        {
            base.OnElementChanged(e);
            Control.StackFromBottom = true;
            Control.TranscriptMode = TranscriptMode.Normal;
        }
    }
}