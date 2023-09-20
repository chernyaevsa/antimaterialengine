using Avalonia.Media.Imaging;
using Avalonia.Shared.PlatformSupport;
using ReactiveUI;
using System;

namespace AnitMaterialEngine.ViewModels
{
	public class MainWindowViewModel : ViewModelBase
	{
		private static AssetLoader assetLoader = new AssetLoader();
		private Bitmap _imageSrc = new Bitmap(assetLoader.Open(new Uri("avares://AnitMaterialEngine/Assets/missle.png")));
		public Bitmap ImageSrc
		{
			get
			{
				return _imageSrc;
			}
			set
			{
				this.RaiseAndSetIfChanged(ref _imageSrc, value);
			}
		}
		public string Greeting => "Welcome to Avalonia!";

		public void Start()
		{
			ImageSrc = new Bitmap(assetLoader.Open(new Uri("avares://AnitMaterialEngine/Assets/explo.png")));
		}
	}
}