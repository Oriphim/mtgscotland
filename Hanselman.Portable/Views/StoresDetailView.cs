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
			var webView = new WebView
			{
				VerticalOptions = LayoutOptions.FillAndExpand,
				HorizontalOptions = LayoutOptions.FillAndExpand
			};
			webView.Source = new HtmlWebViewSource
			{
				Html = item.Description
			};
			Content = new StackLayout
			{
				Children =
		{
		  webView
		}
			};
		}
	}
}

