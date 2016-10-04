using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Hanselman.Portable.Views
{
	public partial class EventsPage : ContentPage
	{

		private EventsViewModel ViewModel
		{
			get { return BindingContext as EventsViewModel; }
		}


		public EventsPage()
		{
			InitializeComponent();
			BindingContext = new EventsViewModel();

			listView.ItemTapped += (sender, args) =>
			{
				if (listView.SelectedItem == null)
					return;
				this.Navigation.PushAsync(new EventsDetailsView(listView.SelectedItem as FeedItem));
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
