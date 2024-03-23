using Factory_Method.Services.SubscriptionService.Subscriptions;
using Factory_Method.User;

namespace Factory_Method.Services.SubscriptionService
{
    public interface ISubscriptionService
    {
        public void MakeDomesticSubscription(UserModel user);
        public void MakeEducationSubscription(UserModel user);
        public void MakePremiumSubscription(UserModel user);

        public void RemoveSubscription(UserModel user, ISubscription subscription);
    }
}
