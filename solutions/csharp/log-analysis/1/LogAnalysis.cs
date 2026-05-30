public static class LogAnalysis 
{
    // TODO: define the 'SubstringAfter()' extension method on the `string` type
    public static string SubstringAfter(this string str,string delimiter)
    {
        str = str.Split(delimiter)[1];
        return str;
    }
    // TODO: define the 'SubstringBetween()' extension method on the `string` type
    public static string SubstringBetween(this string str,string delimiter1, string delimiter2)
    {
        str = str.Split(delimiter1)[1].Split(delimiter2)[0];
        return str;
    }
    // TODO: define the 'Message()' extension method on the `string` type
    public static string Message(this string str)
    {
        str = str.Split(':')[1].Trim();
        return str;
    }
    // TODO: define the 'LogLevel()' extension method on the `string` type
    public static string LogLevel(this string str)
    {
        str = str.Split(':')[0].Trim().Replace("[","").Replace("]","");
        return str;
    }
}