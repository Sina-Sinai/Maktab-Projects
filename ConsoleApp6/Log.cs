namespace ConsoleApp6
{
    internal class Log
    {
        public static void log(string message)
        {
            string LogFilePath = @"E:\Programming\c#-ex\log.txt";
            string[] line = { $"----- Start Message -----\n{message}\n------ End of Message ----" };
            File.AppendAllLines(LogFilePath, line);
        }

    }
}
