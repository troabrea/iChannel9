// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace Channel9
{
    [Register ("ShowCell")]
    partial class ShowCell
    {
        [Outlet]
        UIKit.UILabel dateLabel { get; set; }


        [Outlet]
        UIKit.UIImageView imageView { get; set; }


        [Outlet]
        UIKit.UILabel nameLabel { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (dateLabel != null) {
                dateLabel.Dispose ();
                dateLabel = null;
            }

            if (imageView != null) {
                imageView.Dispose ();
                imageView = null;
            }

            if (nameLabel != null) {
                nameLabel.Dispose ();
                nameLabel = null;
            }
        }
    }
}