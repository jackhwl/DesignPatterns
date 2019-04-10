using System;
using MultiDeviceUseCases.ViewModels.Home;

namespace MultiDeviceUseCases.Services.Shared
{
    public interface IHomeService
    {
        IndexViewModel GetModelForIndex(String userAgent);
    }
}