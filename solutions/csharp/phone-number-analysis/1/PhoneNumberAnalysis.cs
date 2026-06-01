public static class PhoneNumber
{
        public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        (string, string, string) phoneNumberparts = (phoneNumber.Split('-')[0], phoneNumber.Split('-')[1], phoneNumber.Split('-')[2]);
        return (phoneNumberparts.Item1 == "212", phoneNumberparts.Item2 == "555", phoneNumberparts.Item3);
    }
    
    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
    {
        return phoneNumberInfo.IsNewYork && phoneNumberInfo.IsFake;
    }    
}
