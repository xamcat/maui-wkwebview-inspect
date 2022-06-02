//
//  ViewController.swift
//  testWebViewMac
//
//  Created by Alexey Strakh on 6/1/22.
//

import Cocoa
import WebKit

class ViewController: NSViewController, NSWindowDelegate, WKUIDelegate {

    var webView: WKWebView!

    override func viewDidLoad() {
        super.viewDidLoad()
        self.initWebView();
    }
    
    func initWebView() {
        let webConfiguration = WKWebViewConfiguration()
        webView = WKWebView(frame: .zero, configuration: webConfiguration)
        webView.uiDelegate = self
        self.view.addSubview(webView)
        let myURL = URL(string:"https://www.apple.com")
        let myRequest = URLRequest(url: myURL!)
        webView.load(myRequest)
    }

    override var representedObject: Any? {
        didSet {
        // Update the view, if already loaded.
        }
    }
    
    func windowDidResize(_ notification: Notification) {
        webView.frame = view.frame
    }
    
    override func viewWillAppear() {
        view.window?.delegate = self
    }
}
