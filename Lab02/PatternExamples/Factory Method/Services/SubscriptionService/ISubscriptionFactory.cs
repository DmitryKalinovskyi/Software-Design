using Factory_Method.Services.SubscriptionService.Subscriptions;

namespace Factory_Method.Services.SubscriptionService
{
    public interface ISubscriptionFactory
    {
        public ISubscription CreateSubscription();
    }
}
