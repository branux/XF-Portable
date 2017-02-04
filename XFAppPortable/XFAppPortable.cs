using System;

using Xamarin.Forms;

namespace XFAppPortable
{
	public class App : Application
	{
		public App()
		{
			var version = DependencyService.Get<IMobileVersion>();

			// The root page of your application
			var content = new ContentPage
			{
				Title = "XFAppPortable",
				Content = new StackLayout
				{
					VerticalOptions = LayoutOptions.Center,
					Children = {
						new Label {
							HorizontalTextAlignment = TextAlignment.Center,
							Text = version.ShowVersion()
						}
					}
				}
			};

			MainPage = new NavigationPage(content);
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
