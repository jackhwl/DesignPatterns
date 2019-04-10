using System;
using System.Collections.Generic;
using MultiDeviceUseCases.Common.Extensions;
using MultiDeviceUseCases.Services.Shared;
using MultiDeviceUseCases.ViewModels.Home;
using WURFL;

namespace MultiDeviceUseCases.Services.Home
{
    public class HomeService : IHomeService
    {
        public IndexViewModel GetModelForIndex(String userAgent)
        {
            var model = new IndexViewModel
            {
                Title = "Home",
                StatusMessage = "This site is not available on desktop browsers. Try using a mobile or tablet browser.",
                HotNews = GetHotNewsInternal(),
                ImageUrl = GetPicOfTheDayInternal(),

                // Device-specific (iOS only)
                GotoAppStoreLink = GetAppStoreLink(userAgent),
                LiveMatches = GetLiveMatches(userAgent)
            };
            return model;
        } 

        private static String GetAppStoreLink(String userAgent)
        {
            // Suppose we have only an iOS native app to point to (i.e. no Android, BB, WP)
            var deviceInfo = WURFLManagerBuilder.Instance.GetDeviceForRequest(userAgent);
            return deviceInfo.HasOs("iOS", new Version(3, 0)) 
                ? "For a better experience, try out the iOS app!" 
                : String.Empty;
        }

        private static IList<String> GetLiveMatches(String userAgent)
        {
            // Suppose we have only an iOS native app to point to (i.e. no Android, BB, WP)
            var deviceInfo = WURFLManagerBuilder.Instance.GetDeviceForRequest(userAgent);
            if (deviceInfo.GetVirtualCapability("is_smartphone") == "true")
            {
                return new List<string>() {"Fed-Djo 76 *53", "Mla/Bab-Wil/Wil 64 21*", "Rao-Dim 33*"};
            }
            return new List<string>();
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