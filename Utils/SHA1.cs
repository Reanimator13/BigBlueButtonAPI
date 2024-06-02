using System.Text;

namespace BigBlueButton.Utils;

public static class SHA1
{
    public static string SHA1HashStringForUTF8String(string s)
    {
        var bytes = Encoding.UTF8.GetBytes(s);
        var sha1 = System.Security.Cryptography.SHA1.Create();
        var hashBytes = sha1.ComputeHash(bytes);

        return HexStringFromBytes(hashBytes);
    }

    private static string HexStringFromBytes(byte[] bytes)
    {
        var sb = new StringBuilder();

        foreach (var b in bytes)
        {
            var hex = b.ToString("x2");
            sb.Append(hex);
        }

        return sb.ToString();
    }
}
