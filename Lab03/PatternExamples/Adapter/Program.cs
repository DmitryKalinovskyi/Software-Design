using Adapter;

void TestLogger(ILogger logger)
{
    logger.Log("Test log.");
    logger.Warn("Test warn.");
    logger.Error("Test error.");
}

TestLogger(new Logger());

if (Path.Exists("./Logs") == false)
    Directory.CreateDirectory("./Logs");

TestLogger(new FileLogger(new FileWriter("./Logs/testlog.txt")));

