using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Notifications;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.Web.Http;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace WindowsStoreApp1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void btDownload_Click(object sender, RoutedEventArgs e)
        {
            HttpClient client = new HttpClient();
            Uri uri = new Uri("http://www.microsoft.com", UriKind.Absolute);
            string content = await client.GetStringAsync(uri);
            tbResult.Text = content;

            UpdateTile();
        }

        public void UpdateTile()
        {
            var updater = TileUpdateManager.CreateTileUpdaterForApplication();
            if (updater.Setting == NotificationSetting.Enabled)
            {

                var tileSquareXml =
                           TileUpdateManager.GetTemplateContent(TileTemplateType.TileSquare150x150Block);

                
                var textSquareElements = tileSquareXml.GetElementsByTagName("text").ToList();

                textSquareElements[0].InnerText = "Heading";
                textSquareElements[1].InnerText = "Subheading 1";

                var tileWideXml =
                             TileUpdateManager.GetTemplateContent(TileTemplateType.TileWide310x150BlockAndText01);

                var textWideElements = tileWideXml.GetElementsByTagName("text").ToList();
                textWideElements[0].InnerText = "Wide Heading";
                textWideElements[1].InnerText = "Wide Subheading 1";
                textWideElements[2].InnerText = "Wide Subheading 2";
                textWideElements[3].InnerText = "Wide Subheading 3";

                var wideBindingNode = tileWideXml.GetElementsByTagName("binding").First();
                var squareVisualNode = tileSquareXml.GetElementsByTagName("visual").First();
                var importNode = tileSquareXml.ImportNode(wideBindingNode, true);
                squareVisualNode.AppendChild(importNode);

                var notification = new TileNotification(tileSquareXml);
                notification.ExpirationTime = DateTimeOffset.Now.AddHours(0);
                updater.Update(notification);
            } 
        }

    }
}
