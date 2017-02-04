using System;
using UIKit;
using XFAppPortable.iOS;

[assembly: Xamarin.Forms.Dependency(typeof(MobileVersion))]
namespace XFAppPortable.iOS
{
	
	public class MobileVersion:IMobileVersion
	{
		

		public string ShowVersion()
		{
			UIDevice device = new UIDevice();
			return $"{device.SystemName} {device.SystemVersion}";
		}
	}
}
