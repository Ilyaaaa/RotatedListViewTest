using CoreGraphics;
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
    class RotatedListViewRenderer : CollectionViewRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<GroupableItemsView> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                NSArray s = Control.ValueForKey(new NSString("_subviewCache")) as NSMutableArray;
                UICollectionView collection = s.GetItem<UICollectionView>(0);

                collection.Transform = CGAffineTransform.MakeRotation((float)Math.PI);
            }
        }
    }
}