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
    [Register ("EpisodeCell")]
    partial class EpisodeCell
    {
        [Outlet]
        UIKit.UILabel summaryLabel { get; set; }


        [Outlet]
        UIKit.UIImageView thumbnailImage { get; set; }


        [Outlet]
        UIKit.UILabel titleLabel { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (summaryLabel != null) {
                summaryLabel.Dispose ();
                summaryLabel = null;
            }

            if (thumbnailImage != null) {
                thumbnailImage.Dispose ();
                thumbnailImage = null;
            }

            if (titleLabel != null) {
                titleLabel.Dispose ();
                titleLabel = null;
            }
        }
    }
}