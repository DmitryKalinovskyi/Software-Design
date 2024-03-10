using ZooManagerLibrary.Core;

namespace ZooManagerLibrary.Reports
{
    public class BaseReporter : IReportService
    {
        private readonly ZooContext _context;

        public BaseReporter(ZooContext context)
        {
            _context = context;
        }

        public string GetReport()
        {
            return $"""
                Animals: {_context.Animals.Count()}
                Aviarys: {_context.Aviaries.Count()}
                Food: {_context.Foods.Count()}
                """;
        }
    }
}
