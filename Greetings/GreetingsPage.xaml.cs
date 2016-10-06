using Xamarin.Forms;

namespace Greetings
{
	partial class GreetingsPage : ContentPage
	{
		public GreetingsPage()
		{
			Content = new Label
			{
				Text = "Saludos, Xamarin.Forms()!",
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.Center
			};

			/*
			 * Adding Padding only for iOS
			 */
			Device.OnPlatform(iOS: () =>
			{
				Padding = new Thickness(0, 20, 0, 0);
			});
		}
	}
}
