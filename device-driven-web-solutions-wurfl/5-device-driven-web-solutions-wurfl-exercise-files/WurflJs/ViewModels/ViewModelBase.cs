using System;
using WurflJs.Resources;

namespace WurflJs.ViewModels
{
    public class ViewModelBase
    {
        public ViewModelBase()
        {
            Title = Literals.AppTitle;
        }
        public ViewModelBase(String title)
        {
            Title = title;
        }

        public String Title { get; set; }
    }
}
