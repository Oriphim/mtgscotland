using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Hanselman.Portable.Views
{
	public partial class StoresPage : ContentPage
	{

		private StoresPageViewModel ViewModel
		{
			get { return BindingContext as StoresPageViewModel; }
		}


		public StoresPage()
		{
			InitializeComponent();
			BindingContext = new StoresPageViewModel();

			listView.ItemTapped += (sender, args) =>
			{
				if (listView.SelectedItem == null)
					return;
				this.Navigation.PushAsync(new StoresDetailView(listView.SelectedItem as FeedItem));
				listView.SelectedItem = null;
			};
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();
			if (ViewModel == null || !ViewModel.CanLoadMore || ViewModel.IsBusy || ViewModel.FeedItems.Count > 0)
				return;

			ViewModel.LoadItemsCommand.Execute(null);
		}
	}
}
