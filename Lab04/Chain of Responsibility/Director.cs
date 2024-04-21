using Chain_of_Responsibility.Handlers;

namespace Chain_of_Responsibility
{
    public class Director
    {
        public BaseHandler<DialogContext> GetApplicationChain()
        {
            var mainHandler = new ApplicationHandler();

            mainHandler
                .SetNext(new SupportHandler())
                .SetNext(new AnsweringMachineHandler())
                .SetNext(new BankWorkerHandler())

                // to make it circular.
                .SetNext(mainHandler);

            return mainHandler;
        }
    }
}
