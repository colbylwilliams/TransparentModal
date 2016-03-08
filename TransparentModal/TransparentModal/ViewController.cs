using System;

using Foundation;
using UIKit;

namespace TransparentModal
{
	public partial class ViewController : UIViewController
	{
		protected ViewController (IntPtr handle) : base (handle) { }

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			DefinesPresentationContext = true;
		}

		partial void showModalButtonClicked (NSObject sender)
		{
			var modalViewController = Storyboard.InstantiateViewController ("ModalViewController") as ModalViewController;

			modalViewController.ModalPresentationStyle = UIModalPresentationStyle.OverCurrentContext;

			PresentViewController (modalViewController, true, null);
		}
	}
}