using Factory_Method.Services.SubscriptionService.Subscriptions;
using Factory_Method.User;

namespace Factory_Method.Services.SubscriptionService
{
    public class SubscriptionServiceBase : ISubscriptionService
    {
        private ISubscriptionFactory _domesticFactory;
        private ISubscriptionFactory _educationalFactory;
        private ISubscriptionFactory _premiumFactory;

        public SubscriptionServiceBase()
        {
            _domesticFactory = new DomesticSubscriptionFactory();
            _educationalFactory = new EducationalSubscriptionFactory();
            _premiumFactory = new PremiumSubscriptionFactory();
        }

        public SubscriptionServiceBase(ISubscriptionFactory domesticFactory, ISubscriptionFactory educationalFactory, ISubscriptionFactory premiumFactory)
        {
            _domesticFactory = domesticFactory;
            _educationalFactory = educationalFactory;
            _premiumFactory = premiumFactory;
        }

        public void MakeDomesticSubscription(UserModel user)
        {
            var subscription = _domesticFactory.CreateSubscription();

            user.Subscriptions.Add(subscription);
        }

        public void MakeEducationSubscription(UserModel user)
        {
            var subscription = _educationalFactory.CreateSubscription();

            user.Subscriptions.Add(subscription);
        }

        public void MakePremiumSubscription(UserModel user)
        {
            var subscription = _premiumFactory.CreateSubscription();

            user.Subscriptions.Add(subscription);
        }

        public void RemoveSubscription(UserModel user, ISubscription subscription)
        {
            if (user.Subscriptions.Contains(subscription) == false)
            {
                throw new InvalidOperationException("Subscription is not setted, you can't remove it.");
            }

            user.Subscriptions.Remove(subscription);
        }
    }
}
