using System.Text;
using ZooManagerLibrary.Core;

namespace ZooManagerLibrary.Reports
{
    public class FoodReporter : IReportService
    {
        private readonly ZooContext _context;

        public FoodReporter(ZooContext context)
        {
            _context = context;        
        }

        public string GetReport()
        {
            StringBuilder builder = new();

            foreach(var foodEntity in _context.Foods)
            {
                builder.AppendLine(foodEntity.ToString());
            }

            return builder.ToString();
        }
    }
}
