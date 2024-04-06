namespace Adapter
{
    public interface ILogger
    {
        public void Log(string message);

        public void Error(string errorMessage);

        public void Warn(string warnMessage);
    }
}
