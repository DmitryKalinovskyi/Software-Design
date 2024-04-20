
using Mediator.AircraftSystem;

var centre = new CommandCentre();

var a1 = new Aircraft("A-1", centre);
var a2 = new Aircraft("A-2", centre);
var a3 = new Aircraft("A-3", centre);

centre.Aircrafts = [a1, a2, a3];
centre.Runways = [new(), new()];

a1.Land();

a2.Land();

a3.Land();

a2.TakeOff();

a3.Land();



/* Problem analysis, we need to support few operations, for the Aircraft it will be landing, and taking off
 * 
 * to land we need first to request free runway from command center
 * them we perform the landing operation, and if it was sucessful we notify about it command center
 * 
 * there can be problem, command center can give for 2 aircrafts the same runway. (while first aircraft is landing runway considered as free)
 * to prevent this case, we can add another state to the runway, like "isRequested" or just mark it as isBusy.
 * 
 * also there can be problem with multithreading. Operation for giving the aircraft should be blocked with lock.
 */