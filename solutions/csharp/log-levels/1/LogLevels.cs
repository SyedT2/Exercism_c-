static class LogLine
{
    public static string Message(string logLine)
    {
        return logLine.Split(':')[1].Trim();
    }

    public static string LogLevel(string logLine)
    {
       return logLine.Split(':')[0].Trim().Replace("[","").Replace("]","").ToLower();
    }

    public static string Reformat(string logLine)
    {
        string[] arr = logLine.Split(':');
        String a, b;
        a = arr[0].Trim().Replace("[","(").Replace("]", ")").ToLower();
        b = arr[1].Trim();
        return $"{b} {a}";
    }
}
