using System;

using UIKit;

namespace XamariniPhoneApp
{
    public partial class ViewController : UIViewController
    {


        int iCounter = 0;
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        partial void BtnHello_TouchUpInside(UIButton sender)
        {
            lblHello.Text = string.Format( "Number of clicks {0}", ++iCounter);
        }
    }
}