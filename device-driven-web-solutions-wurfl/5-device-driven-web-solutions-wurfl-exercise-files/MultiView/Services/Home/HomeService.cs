using System;
using MultiView.Common.Extensions;
using MultiView.Services.Shared;
using MultiView.ViewModels.Home;
using WURFL;

namespace MultiView.Services.Home
{
    public class HomeService : IHomeService
    {
        public IndexViewModel GetModelForIndex()
        {
            return new IndexViewModel 
                       {
                           Title = "Home",
                           StatusMessage = "This site is not available on desktop browsers. Try using a mobile or tablet browser.",
                           HotNews = GetHotNewsInternal(),
                           ImageUrl = GetPicOfTheDayInternal()
                       };
        } 

        public String GetAppStoreLink(String userAgent)
        {
            // Suppose we have only an iOS native app to point to (i.e. no Android, BB, WP)
            var deviceInfo = WURFLManagerBuilder.Instance.GetDeviceForRequest(userAgent);
            return deviceInfo.HasOs("iphone os", new Version(3, 0)) 
                ? "For a better experience, try out the iOS app!" 
                : String.Empty;
        }

        private String GetHotNewsInternal()
        {
            return "Hey, this is great stuff!";
        }

        private String GetPicOfTheDayInternal()
        {
            return "pic1.jpg";
        }

    }
}