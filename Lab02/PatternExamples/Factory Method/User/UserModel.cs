using Factory_Method.Services.SubscriptionService.Subscriptions;

namespace Factory_Method.User
{
    public class UserModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public List<ISubscription> Subscriptions { get; set; }

        public UserModel() : this("", "", new()) { }

        public UserModel(string name, string email) : this(name, email, new()) { }

        public UserModel(string name, string email, List<ISubscription> subscriptions)
        {
            Id = new Guid();
            Subscriptions = subscriptions;
            Name = name;
            Email = email;
        }


    }
}
