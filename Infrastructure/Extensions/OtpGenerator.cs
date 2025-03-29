namespace Infrastructure.Extensions;

public static class OtpGenerator
{
    public static string OtpGenerate(int n = 4)
    {
        string otp = "";
        string charsList = "9287634510";
        Random random = new();
        for (int i = 0; i < n; i++)
        {
            otp += charsList[random.Next(charsList.Length)];
        }
        return otp;
    }
}
