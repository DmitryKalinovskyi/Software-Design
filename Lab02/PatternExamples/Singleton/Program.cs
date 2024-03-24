using Singleton;

var process1 = new Thread(
    Authenticator.MainAuthenticator.Authenticate);

var process2 = new Thread(
    Authenticator.MainAuthenticator.Authenticate);

var process3 = new Thread(
    Authenticator.MainAuthenticator.Authenticate);

process1.Start();
process2.Start();
process3.Start();

var process4 = new Thread(
    LazyAuthenticator.MainAuthenticator.Authenticate);
var process5 = new Thread(
    LazyAuthenticator.MainAuthenticator.Authenticate);
var process6 = new Thread(
    LazyAuthenticator.MainAuthenticator.Authenticate);

process4.Start();
process5.Start();
process6.Start();

// it's all (◔_◔)🍔🍕
