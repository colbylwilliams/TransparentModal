using System;

using Foundation;
using UIKit;

namespace TransparentModal
{
	public partial class ModalViewController : UIViewController
	{
		public ModalViewController (IntPtr handle) : base (handle) { }

		partial void dismissModalButtonClicked (NSObject sender) => DismissViewController (true, null);
	}
}