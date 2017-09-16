// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace XamariniPhoneApp
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnHello { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblHello { get; set; }

        [Action ("BtnHello_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void BtnHello_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (btnHello != null) {
                btnHello.Dispose ();
                btnHello = null;
            }

            if (lblHello != null) {
                lblHello.Dispose ();
                lblHello = null;
            }
        }
    }
}