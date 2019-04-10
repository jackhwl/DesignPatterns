using System;

namespace WurflJs.ViewModels.Home
{
    public class IndexViewModel : ViewModelBase
    {
        public String Headline { get; set; }
        public String MoreInfo { get; set; }
        public String MoreInfoUrl { get; set; }
        public String MoreInfoTooltip { get; set; }
    }
}