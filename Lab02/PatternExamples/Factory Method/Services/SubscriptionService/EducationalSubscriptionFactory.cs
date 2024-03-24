using Factory_Method.Services.SubscriptionService.Subscriptions;

namespace Factory_Method.Services.SubscriptionService
{
    public class EducationalSubscriptionFactory : ISubscriptionFactory
    {
        public ISubscription CreateSubscription()
        {
            // here you can build subscription from configuration file, where specified the conditions for it.

            // for channels you can made another service, that allow from string get the channel with respecting source.
            // 
            // for testing purpose i will use test version of this class, where i initialize it with some initial channel
            return new EducationalSubscription();
        }
    }
}
