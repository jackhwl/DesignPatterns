using WURFL;
using WURFL.Aspnet.Extensions.Config;

namespace MultiView.Common.Config
{
    public class WurflConfig
    {
        public static void Initialize()
        {
            WURFLManagerBuilder.Build(new ApplicationConfigurer());
        }
    }
}