using Factory_Method.Channels;

namespace Factory_Method.Services.SubscriptionService.Subscriptions
{
    public interface ISubscription
    {
        public double MonthPayment { get; set; }

        public TimeSpan MinimumSubscribePeriod { get; set; }

        public List<IChannel> Channels { get; set; }

        public string GetInfo();
    }
}
