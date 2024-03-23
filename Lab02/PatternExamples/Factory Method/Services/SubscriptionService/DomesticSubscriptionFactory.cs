using Factory_Method.Services.SubscriptionService.Subscriptions;

namespace Factory_Method.Services.SubscriptionService
{
    public class DomesticSubscriptionFactory : ISubscriptionFactory
    {
        public ISubscription CreateSubscription()
        {
            return new DomesticSubscription();
        }
    }
}
