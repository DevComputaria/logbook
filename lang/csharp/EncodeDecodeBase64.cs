using System;
using System.Text;
					
public class Program
{
	public static void Main()
	{
		string original = "This is a string";
            Console.WriteLine("Original String = " + original);
            string base64 = Base64Encode(original);
            Console.WriteLine("Encoded String = "+base64);
		Console.WriteLine("Hello World");
		Console.WriteLine("");
		
		string decodebase64 = base64;
            Console.WriteLine("Encoded String = "+base64);
            string originalDeocode = Base64Decode(base64);
            Console.WriteLine("Decoded String = "+original);
	}
	
	public static string Base64Encode(string plainText)
    {
            var plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
    }
	
	public static string Base64Decode(string base64EncodedData)
    {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
    }
	
}
