using Foundation;
using System;
using UIKit;
using RaysHotDogs.Core;

namespace RaysHotDogs
{
	public partial class HotDogDetailViewController : UIView
	{
		public HotDog SelectedHotDog
		{
			get;
			set;
		}

		public HotDogDetailViewController(IntPtr handle) : base(handle)
		{
			HotDogDataService hotDogDataService = new HotDogDataService();
			SelectedHotDog = hotDogDataService.GetHotDogById(1);
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			DatabindUI();
		}

		private void DatabindUI()
		{
			UIImage img = UIImage.FromFile("Images/" + SelectedHotDog.ImagePath + ".jpg");
			HotDogImageView.Image = img;
			NameLabel.Text = SelectedHotDog.Name;
			ShortDescriptionLabel.Text = SelectedHotDog.ShortDescription;
			LongDescriptionText.Text = SelectedHotDog.Description;
			PriceLabel.Text = "$" + SelectedHotDog.Price.ToString();
		}
	}
}