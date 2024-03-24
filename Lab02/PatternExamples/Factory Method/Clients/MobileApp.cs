using Factory_Method.Services.SubscriptionService;
using Factory_Method.Services.SubscriptionService.Subscriptions;
using Factory_Method.User;

namespace Factory_Method.Clients
{
    public class MobileApp
    {
        private ISubscriptionService _subscriptionService;

        public MobileApp() : this(new SubscriptionServiceBase()) { }

        public MobileApp(ISubscriptionService subscriptionService)
        {
            _subscriptionService = subscriptionService;
        }

        private void DisplayMessageBox(string message)
        {
            Console.WriteLine($"App: {message}");
        }

        public void MakeDomesticSubscription(UserModel user)
        {
            _subscriptionService.MakeDomesticSubscription(user);

            DisplayMessageBox("domestic subscription maded!");
        }

        public void MakeEducationalSubscription(UserModel user)
        {
            _subscriptionService.MakeEducationSubscription(user);

            DisplayMessageBox("educational subscription maded!");
        }

        public void MakePremiumSubscription(UserModel user)
        {
            _subscriptionService.MakePremiumSubscription(user);

            DisplayMessageBox("premium subscription maded!");
        }

        public void RemoveSubscription(UserModel user, ISubscription subscription)
        {
            try
            {
                _subscriptionService.RemoveSubscription(user, subscription);
            }
            catch
            {
                DisplayMessageBox("failed to remove subscription.");
                return;
            }

            DisplayMessageBox("subscription removed.");
        }

        // TODO: methods to render channels content.
    }
}
