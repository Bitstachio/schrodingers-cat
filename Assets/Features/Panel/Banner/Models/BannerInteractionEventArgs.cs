using Features.Panel.Banner.Scripts;

namespace Features.Panel.Banner.Models
{
    public class BannerInteractionEventArgs
    {
        public BannerContent Banner { get; private set; }

        public BannerInteractionEventArgs(BannerContent banner) => Banner = banner;
    }
}