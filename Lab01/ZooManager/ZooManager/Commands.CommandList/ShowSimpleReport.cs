using ZooManagerLibrary.Core;
using ZooManagerLibrary.Reports;

namespace ZooManager.Commands.CommandList
{
    public class ShowSimpleReport : Command
    {
        private readonly ZooContext _context;

        public ShowSimpleReport(ZooContext context)
        {
            _context = context;

            Description = "base report command";
        }

        public override object Clone()
        {
            return new ShowSimpleReport(_context);
        }

        public override void Execute(object? parameter)
        {
            BaseReporter reporter = new(_context);

            Console.WriteLine(reporter.GetReport());
        }
    }
}
