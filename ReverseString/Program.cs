namespace ReverseString
{
    public class Program
    {
        static void Main(string[] args)
        {
        
            Console.WriteLine("Enter String: ");
            var str = Console.ReadLine();

            var reverseString =GetReverseString(str);
  
            Console.WriteLine($"Reverse string is : {reverseString}");
            Console.ReadLine();     
        }


        public static string GetReverseString( string str)
        {
            var revString = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                revString = revString + str[i];
            }

            return revString;
        }


    }
}