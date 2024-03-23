using Factory_Method.Services.SubscriptionService;
using Factory_Method.Services.SubscriptionService.Subscriptions;
using Factory_Method.User;

namespace Factory_Method.Clients
{
    // when another subscription is added, then web designers should update their visual for another type of subscription

    public class WebSite
    {
        private ISubscriptionService _subscriptionService;

        public WebSite() : this(new SubscriptionServiceBase()) { }

        public WebSite(ISubscriptionService subscriptionService)
        {
            _subscriptionService = subscriptionService;
        }

        public void ShowNotification(string message)
        {
            Console.WriteLine($"Website notification: {message}");
        }

        public void MakeDomesticSubscription(UserModel user)
        {
            _subscriptionService.MakeDomesticSubscription(user);

            ShowNotification("domestic subscription maded!");
        }

        public void MakeEducationalSubscription(UserModel user)
        {
            _subscriptionService.MakeEducationSubscription(user);

            ShowNotification("educational subscription maded!");
        }

        public void MakePremiumSubscription(UserModel user)
        {
            _subscriptionService.MakePremiumSubscription(user);

            ShowNotification("premium subscription maded!");
        }

        public void RemoveSubscription(UserModel user, ISubscription subscription)
        {
            try
            {
                _subscriptionService.RemoveSubscription(user, subscription);
            }
            catch
            {
                ShowNotification("failed to remove subscription.");
                return;
            }

            ShowNotification("subscription removed.");
        }

        public void ShowSubscriptions(UserModel user)
        {
            Console.WriteLine("Your subscriptions:");
            foreach (var subscription in user.Subscriptions)
            {
                Console.WriteLine(subscription.GetInfo());
            }
        }
    }
}
