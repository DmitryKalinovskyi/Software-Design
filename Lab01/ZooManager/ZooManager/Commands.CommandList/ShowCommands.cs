namespace ZooManager.Commands.CommandList
{
    public class ShowCommands : Command
    {
        private readonly CommandHandler _handler;

        public ShowCommands(CommandHandler handler)
        {
            _handler = handler;
        }

        public ShowCommands(CommandHandler handler, string description): base(description)
        {
            _handler = handler;
        }

        public override object Clone()
        {
            return new ShowCommands(_handler, Description);
        }

        public override void Execute(object? parameter)
        {
            var info = _handler.GetCommandsInfo();
            Console.WriteLine(info);
        }
    }
}
