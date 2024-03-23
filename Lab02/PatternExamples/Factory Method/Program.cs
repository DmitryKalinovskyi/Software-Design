
using Factory_Method.Clients;
using Factory_Method.Seeding;
using Factory_Method.Services.SubscriptionService;
using Factory_Method.User;

// for testing purpose i will use my test subscription service
var testSubscriptionService = new SubscriptionServiceBase(
    new DomesticSubscriptionFactoryTest(),
    new EducationalSubscriptionFactoryTest(),
    new EducationalSubscriptionFactoryTest());


var me = new UserModel("Dmytro", "Kalinovskyi");

// suppose i decided to open the web site
var website = new WebSite(testSubscriptionService);

// from website i make subscription for me
website.MakeDomesticSubscription(me);

// now i have subscription, and i can using client view channels that are specified for me :)

// then using manager i want to make also premium subscription
var call = new ManagerCall(testSubscriptionService);

call.MakePremiumSubscription(me);

// cool, look at the subscriptions i have using website or app, becase manager is to busy to tell me about this.
website.ShowSubscriptions(me);

Console.WriteLine("------------------------------------------------");

// unsubscribe from domestic and add premium
call.RemoveSubscription(me, me.Subscriptions[0]);

// then using app add premium
var app = new MobileApp(testSubscriptionService);
app.MakePremiumSubscription(me);

website.ShowSubscriptions(me);