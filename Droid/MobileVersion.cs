using System;
using XFAppPortable.Droid;

[assembly: Xamarin.Forms.Dependency(typeof(MobileVersion))]
namespace XFAppPortable.Droid
{
	
	public class MobileVersion:IMobileVersion
	{
		

		public string ShowVersion()
		{
			return $"Android API {Android.OS.Build.VERSION.Sdk}";
		}
	}
}
