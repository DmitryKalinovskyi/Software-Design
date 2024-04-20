/* Lore behind implementation (real-life case). Today you registered in monobank, and see that you have non-zero credit limit in card.
 * We all know that credits is evil, and secret plan of bank to get all our money and you want to set limit to zero.
 * Then you make call to the bank.
 */

using Chain_of_Responsibility;
using Chain_of_Responsibility.Handlers;

var director = new Director();

var handler = director.GetApplicationChain();

handler.Handle(new DialogContext());