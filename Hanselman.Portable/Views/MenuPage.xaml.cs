﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Hanselman.Portable.Views
{
    public partial class MenuPage : ContentPage
    {
        RootPage root;
        List<HomeMenuItem> menuItems;
        public MenuPage(RootPage root)
        {
            
            this.root = root;
            InitializeComponent();
            if (!App.IsWindows10)
            {
                BackgroundColor = Color.FromHex("#03A9F4");
                ListViewMenu.BackgroundColor = Color.FromHex("#F5F5F5");
            }
            BindingContext = new BaseViewModel
                {
                    Title = "Hanselman.Forms",
                    Subtitle="Hanselman.Forms",
                    Icon = "slideout.png"
                };

            ListViewMenu.ItemsSource = menuItems = new List<HomeMenuItem>
                {
                    new HomeMenuItem { Title = "About", MenuType = MenuType.About, Icon ="about.png" },
                    new HomeMenuItem { Title = "News", MenuType = MenuType.Blog, Icon = "blog.png" },
				new HomeMenuItem { Title = "Events", MenuType = MenuType.Events, Icon = "twitternav.png" },
                 //   new HomeMenuItem { Title = "Hanselminues", MenuType = MenuType.Hanselminutes, Icon = "hm.png" },
				new HomeMenuItem { Title = "Local Game Stores", MenuType =MenuType.Stores, Icon = "ratchet.png" },
                  //  new HomeMenuItem { Title = "Developers Life", MenuType = MenuType.DeveloperLife, Icon = "tdl.png"},

                };

            ListViewMenu.SelectedItem = menuItems[0];

            ListViewMenu.ItemSelected += async (sender, e) => 
                {
                    if(ListViewMenu.SelectedItem == null)
                        return;

                    await this.root.NavigateAsync(((HomeMenuItem)e.SelectedItem).MenuType);
                };
        }
    }
}

