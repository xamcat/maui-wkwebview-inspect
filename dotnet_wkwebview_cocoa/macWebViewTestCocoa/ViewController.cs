using System;

using AppKit;
using CoreGraphics;
using Foundation;
using WebKit;

namespace macWebViewTestCocoa
{
    public partial class ViewController : NSViewController, INSWindowDelegate, IWKUIDelegate
    {
        private WKWebView _webView;

        public ViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad ()
        {
            base.ViewDidLoad ();
            this.InitWebView();
            // Do any additional setup after loading the view.
        }

        private void InitWebView()
        {
            var webConfiguration = new WKWebViewConfiguration();
            webConfiguration.Preferences.SetValueForKey(NSObject.FromObject(true), new NSString("developerExtrasEnabled"));
            _webView = new WKWebView(frame: new CGRect(0,0,640,480), configuration: webConfiguration);
            _webView.UIDelegate = this;
            this.View.AddSubview(_webView);
            var myURL = new NSUrl("https://www.apple.com");
            var myRequest = new NSUrlRequest(url: myURL);
            _webView.LoadRequest(myRequest);
        }

        public override NSObject RepresentedObject {
            get {
                return base.RepresentedObject;
            }
            set {
                base.RepresentedObject = value;
                // Update the view, if already loaded.
            }
        }

    //    func windowDidResize(_ notification: Notification)
    //    {
    //        webView.frame = view.frame
    //}

        public override void ViewWillAppear()
        {
            if (this.View.Window != null)
                this.View.Window.Delegate = this;

            base.ViewWillAppear();
        }
    }
}
