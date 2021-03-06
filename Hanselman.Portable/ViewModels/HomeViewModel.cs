﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Hanselman.Portable
{
    public class HomeViewModel : BaseViewModel
    {
        public ObservableCollection<HomeMenuItem> MenuItems { get; set; }
        public HomeViewModel()
        {
            CanLoadMore = true;
            Title = "MTGScot";
            MenuItems = new ObservableCollection<HomeMenuItem>();
            MenuItems.Add(new HomeMenuItem
            {
                Id = 0,
                Title = "About",
                MenuType = MenuType.About,
                Icon = "about.png"
            });
            MenuItems.Add(new HomeMenuItem
            {
                Id = 1,
                Title = "Blog",
                MenuType = MenuType.Blog,
                Icon = "blog.png"
            });
            MenuItems.Add(new HomeMenuItem
            {
                Id = 2,
                Title = "Events",
				MenuType = MenuType.Events,
                Icon = "events.png"
            });
			/*
            MenuItems.Add(new HomeMenuItem
            {
                Id = 3,
                Title = "Hanselminutes",
                MenuType = MenuType.Hanselminutes,
                Icon = "hm.png"
            });
            */
            MenuItems.Add(new HomeMenuItem
            {
                Id = 3,
                Title = "Local Game Stores",
				MenuType = MenuType.Stores,
                Icon = "stores.png"
            });

        }

    }
}

