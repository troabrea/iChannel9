// This file has been autogenerated from a class added in the UI designer.

using System;
using System.Collections.Generic;
using System.Linq;
using Channel9.Core.Model;
using Channel9.Core.Services;
using Foundation;
using UIKit;

namespace Channel9
{
    public partial class SeriesViewController : UICollectionViewController, IUICollectionViewSource
	{
		public SeriesViewController (IntPtr handle) : base (handle)
		{
		}

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            LoadData();
        }

        public List<Area> Series { get; set; } = new List<Area>();

		private Boolean hasMoreData = false;
		private Boolean isLoading = false;

		private async void LoadData()
        {
			try
			{
				isLoading = true;
				var cs = new ContentService();
                var newSeries = await cs.GetSeries(Series.Count);
                this.Series.AddRange(newSeries);
				hasMoreData = newSeries.Count == ContentService.PageSize;
				var indexPaths = newSeries.Select(s => NSIndexPath.FromRowSection(Series.IndexOf(s), 0));
				//this.collectionView.ReloadData();
				this.CollectionView.InsertItems(indexPaths.ToArray());
			}
			finally
			{
				isLoading = false;
			}

        }
		
		public override void PrepareForSegue(UIStoryboardSegue segue, Foundation.NSObject sender)
		{
			base.PrepareForSegue(segue, sender);
			if (segue.Identifier == "ShowSeriesEpisodes")
			{
				var sc = (sender as ShowCell);
				var indexPath = this.CollectionView.IndexPathForCell(sc);
				var show = Series[indexPath.Row];
				var sevc = (segue.DestinationViewController as ShowEntriesViewController);
				sevc.Show = show;
			}
		}

		// UICollectionViewSource

        public override nint NumberOfSections(UICollectionView collectionView)
        {
            return 1;
        }

        public override nint GetItemsCount(UICollectionView collectionView, nint section)
        {
            return Series.Count;
        }

        public override UICollectionViewCell GetCell(UICollectionView collectionView, NSIndexPath indexPath)
        {
			var cell = collectionView.DequeueReusableCell("ShowCell", indexPath) as ShowCell;
			var serie = Series[indexPath.Row];
			cell.Configure(serie);

			if (!isLoading && hasMoreData && indexPath.Row == Series.Count - 1)
			{
				LoadData();
			}

			return cell;
        }
		
	}


}
