using Factory_Method.Services.SubscriptionService.Subscriptions;

namespace Factory_Method.Services.SubscriptionService
{
    public class PremiumSubscriptionFactory : ISubscriptionFactory
    {
        public ISubscription CreateSubscription()
        {
            return new PremiumSubscription();
        }
    }
}
