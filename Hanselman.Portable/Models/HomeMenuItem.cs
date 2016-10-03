using System;

namespace Hanselman.Portable
{
    public enum MenuType
    {
        About,
        Blog,
        Twitter,
        Ratchet,
        DeveloperLife
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

