using CoreGraphics;
using Foundation;
using Microsoft.Maui.Handlers;
using UIKit;
using WebKit;

namespace maui_app_webviewtest2.Platforms.MacCatalyst
{
    public partial class CustomWebViewHandler : WebViewHandler
    {
        protected override WKWebView CreatePlatformView()
        {
            Console.WriteLine($"[CustomWebViewHandler] Creating platform view... MacCatalyst Version: {UIDevice.CurrentDevice.SystemVersion}");
            //var webView = base.CreatePlatformView();

            var config = new WKWebViewConfiguration();
            config.Preferences.SetValueForKey(NSObject.FromObject(true), new NSString("developerExtrasEnabled"));
            var webView = new WKWebView(new CGRect(0, 0, 640, 480), config);
             
            Console.WriteLine($"[CustomWebViewHandler] WebView has been created: {webView}");
            return webView;
        }
    }
}

