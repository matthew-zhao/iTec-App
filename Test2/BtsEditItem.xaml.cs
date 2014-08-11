using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace Test2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class BtsEditItem : Page
    {
        private TranslateTransform move = new TranslateTransform();
        private ScaleTransform resize = new ScaleTransform();
        private TransformGroup rectangleTransforms = new TransformGroup();

        private Brush stationaryBrush;
        private Brush transformingBrush = new SolidColorBrush();

        public Item item { get; set; }
        public BtsEditItem()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {

        }

        private void OnManipulationDelta(object sender, ManipulationDeltaRoutedEventArgs e)
        {
            // Scale the rectangle.
            //this.scale.ScaleX *= e.DeltaManipulation.Scale.X;
            //this.scale.ScaleY *= e.DeltaManipulation.Scale.Y;

            // Move the rectangle.
            //this.translation.X += e.DeltaManipulation.Translation.X;
            //this.translation.Y += e.DeltaManipulation.Translation.Y;
        }


        async void onEditItem(object sender, TappedRoutedEventArgs e)
        {
            var folder = ApplicationData.Current.LocalFolder;
            var file = await folder.CreateFileAsync("item.txt", CreationCollisionOption.ReplaceExisting);

            using (var stream = await file.OpenStreamForWriteAsync())
            {
                var writer = new StreamWriter(stream);
                await writer.WriteAsync("");
                await writer.FlushAsync();
                writer.Dispose();
                
            }
        }
        

    }
}
