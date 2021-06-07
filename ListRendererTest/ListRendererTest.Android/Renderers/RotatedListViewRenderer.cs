using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.RecyclerView.Widget;
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
    class RotatedListViewRenderer : CollectionViewRenderer
    {
        public RotatedListViewRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<ItemsView> elementChangedEvent)
        {
            base.OnElementChanged(elementChangedEvent);

            var layoutManager = new LinearLayoutManager(Context);
            layoutManager.ReverseLayout = true;

            SetLayoutManager(layoutManager);
        }
    }
}