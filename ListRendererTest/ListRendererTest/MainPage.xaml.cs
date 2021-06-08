using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ListRendererTest
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var items = new List<string>();
            for (int i = 0; i < 5; i++)
                items.Add($"Message {i}");

            list.ItemsSource = items;
        }
    }
}
