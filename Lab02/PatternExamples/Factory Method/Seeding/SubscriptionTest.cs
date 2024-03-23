using Factory_Method.Channels;
using Factory_Method.ContentSource;
using Factory_Method.Services.SubscriptionService;
using Factory_Method.Services.SubscriptionService.Subscriptions;

namespace Factory_Method.Seeding
{


    public class DomesticSubscriptionFactoryTest : ISubscriptionFactory
    {
        public ISubscription CreateSubscription()
        {
            return new DomesticSubscription(10, new TimeSpan(31, 0, 0, 0, 0, 0), new List<IChannel>
            {
                new SimpleChannel("Plus plus", "One of my favorite channels, when i was child.", new VideoSource(new Uri("https://www.youtube.com/watch?v=sJXSU15Sj-o"))),
            });
        }
    }

    public class EducationalSubscriptionFactoryTest : ISubscriptionFactory
    {
        public ISubscription CreateSubscription()
        {
            return new EducationalSubscription(0, new TimeSpan(31, 0, 0, 0, 0, 0), new List<IChannel>
            {
                new SimpleChannel("Plus plus", "One of my favorite channels, when i was child.", new VideoSource(new Uri("https://www.youtube.com/watch?v=sJXSU15Sj-o"))),
                new SimpleChannel("Education.ua", "Some educational content.", new VideoSource(new Uri("https://www.youtube.com/watch?v=sJXSU15Sj-o")))
            });
        }
    }

    public class PremiumSubscriptionFactoryTest : ISubscriptionFactory
    {
        public ISubscription CreateSubscription()
        {
            return new PremiumSubscription(23, new TimeSpan(31, 0, 0, 0, 0, 0), new List<IChannel>
            {
                new SimpleChannel("Plus plus", "One of my favorite channels, when i was child.", new VideoSource(new Uri("https://www.youtube.com/watch?v=sJXSU15Sj-o"))),
                new SimpleChannel("QTV", "I will never forget about this channel...", new VideoSource(new Uri("https://www.youtube.com/watch?v=sJXSU15Sj-o")))
            });
        }
    }
}
