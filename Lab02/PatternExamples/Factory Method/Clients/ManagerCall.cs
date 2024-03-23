using Factory_Method.Services.SubscriptionService;
using Factory_Method.Services.SubscriptionService.Subscriptions;
using Factory_Method.User;

namespace Factory_Method.Clients
{
    public class ManagerCall
    {
        private ISubscriptionService _subscriptionService;

        public ManagerCall() : this(new SubscriptionServiceBase()) { }

        public ManagerCall(ISubscriptionService subscriptionService)
        {
            _subscriptionService = subscriptionService;
        }

        public void TellUser(string message)
        {
            Console.WriteLine($"Manager: {message}");
        }

        public void MakeDomesticSubscription(UserModel user)
        {
            _subscriptionService.MakeDomesticSubscription(user);

            TellUser("domestic subscription maded!");
        }

        public void MakeEducationalSubscription(UserModel user)
        {
            _subscriptionService.MakeEducationSubscription(user);

            TellUser("educational subscription maded!");
        }

        public void MakePremiumSubscription(UserModel user)
        {
            _subscriptionService.MakePremiumSubscription(user);

            TellUser("premium subscription maded!");
        }

        public void RemoveSubscription(UserModel user, ISubscription subscription)
        {
            try
            {
                _subscriptionService.RemoveSubscription(user, subscription);
            }
            catch
            {
                TellUser("failed to remove subscription.");
                return;
            }

            TellUser("subscription removed.");
        }
    }
}
