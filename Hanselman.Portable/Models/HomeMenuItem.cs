using System;

namespace Hanselman.Portable
{
    public enum MenuType
    {
        About,
        Blog,
        Events,
        Stores
    }
    public class HomeMenuItem : BaseModel
    {
        public HomeMenuItem()
        {
            MenuType = MenuType.About;
        }
        public string Icon { get; set; }
        public MenuType MenuType { get; set; }
    }
}

