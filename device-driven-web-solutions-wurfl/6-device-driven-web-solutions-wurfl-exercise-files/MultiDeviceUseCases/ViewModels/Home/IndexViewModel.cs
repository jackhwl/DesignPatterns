using System;
using System.Collections.Generic;

namespace MultiDeviceUseCases.ViewModels.Home
{
    public class IndexViewModel : ViewModelBase
    {
        public IndexViewModel()
        {
            ImageUrl = "";
            HotNews = "";
            GotoAppStoreLink = "";
            LiveMatches = new List<string>();
        }

        // Desktop 
        // Not supported in this site; so just display a friendly message
        public String StatusMessage { get; set; }

        // Mobile
        // We just display a 3x3 menu with (small) icons -- no special model is required

        // Tablet
        // We display pic-of-the-day and hot-news plus a 4x2 menu. Different dimensions and layout for tablets.
        // We also show a link to the app-store if there's an app for the particular OS.
        public String ImageUrl { get; set; }
        public String HotNews { get; set; }
        public String GotoAppStoreLink { get; set; }

        // Smartphone only
        public IList<String> LiveMatches { get; set; }
    }
}