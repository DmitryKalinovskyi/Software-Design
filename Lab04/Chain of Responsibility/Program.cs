/* Lore behind implementation (real-life case). Today you registered in monobank, and see that you have non-zero credit limit in card.
 * We all know that credits is evil, and secret plan of bank to get all our money and you want to set limit to zero.
 * 
 * 1. First of all you want to change it inside application, but option is not present.
 * 
 * 2. Then you go to the support page
 * 
 * 3. If support didn't helped, you make call to bank-workers, but first you should work with answering machine
 * 
 * 4. After answering machine is not helped, you are redirected to bank worker.
 
 */

using Chain_of_Responsibility;

Console.OutputEncoding = System.Text.Encoding.UTF8;

var director = new Director();

var handler = director.GetApplicationChain();

handler.Handle(new DialogContext());