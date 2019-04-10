using System;
using MultiView.ViewModels.Home;

namespace MultiView.Services.Shared
{
    public interface IHomeService
    {
        IndexViewModel GetModelForIndex();
        String GetAppStoreLink(String userAgent);
    }
}