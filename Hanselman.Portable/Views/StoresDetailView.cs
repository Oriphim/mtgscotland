using Hanselman.Portable.Helpers;
using Plugin.Share;
using System;
using Xamarin.Forms;

namespace Hanselman.Portable
{
	public class StoresDetailView : BaseView
	{
		public StoresDetailView(FeedItem item)
		{
			BindingContext = item;
			var storeAddress = item.Address;
			string url;



			//ITEM IS XML
			Device.OnPlatform(iOS: () =>
			                  //http://maps.apple.com/?address=1,Infinite+Loop,Cupertino,California
  {
	  url = String.Format(" <a href=http://maps.apple.com/?q={0}>Location</a>", storeAddress);
	  var fullHtml = item.Description + url;
	  var webView = new WebView
	  {
		  VerticalOptions = LayoutOptions.FillAndExpand,
		  HorizontalOptions = LayoutOptions.FillAndExpand
	  };
	  webView.Source = new HtmlWebViewSource
	  {

		  Html = fullHtml

	  };
	  Content = new StackLayout
	  {
		  Children =
		{
		  webView
		}
	  };

  },
			                  Default: () =>
  {
	  url = String.Format(" <a href=http://maps.google.com/?q={0}>Location</a>", storeAddress);
	  var fullHtml = item.Description + url;
	  var webView = new WebView
	  {
		  VerticalOptions = LayoutOptions.FillAndExpand,
		  HorizontalOptions = LayoutOptions.FillAndExpand
	  };
	  webView.Source = new HtmlWebViewSource
	  {

		  Html = fullHtml

	  };
	  Content = new StackLayout
	  {
		  Children =
		{
		  webView
		}
	  };
  });


			//Device.OpenUri(url);
			/*
			var webView = new WebView
			{
				VerticalOptions = LayoutOptions.FillAndExpand,
				HorizontalOptions = LayoutOptions.FillAndExpand
			};
			webView.Source = new HtmlWebViewSource
			{

				Html = fullHtml
				           
			};

			Content = new StackLayout
			{
				Children =
		{
		  webView
		}
			};
		}
*/
		}
	}
}

