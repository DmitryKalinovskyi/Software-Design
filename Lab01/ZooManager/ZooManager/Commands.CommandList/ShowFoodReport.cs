using ZooManagerLibrary.Core;
using ZooManagerLibrary.Reports;

namespace ZooManager.Commands.CommandList
{
    public class ShowFoodReport : Command
    {
        private ZooContext _context;

        public ShowFoodReport(ZooContext context, string description): base(description)
        {
            _context = context;
        }

        public ShowFoodReport(ZooContext context)
        {
            _context = context;

            Description = "Shows simple food report.";
        }

        public override object Clone()
        {
            return new ShowFoodReport(_context, Description);
        }

        public override void Execute(object? parameter)
        {
            IReportService foodReporter = new FoodReporter(_context);

            Console.WriteLine(foodReporter.GetReport());
        }
    }
}
