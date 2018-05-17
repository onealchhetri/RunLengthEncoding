using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunLengthEncoding
{
    class Program
    {
        static void Main(string[] args)
        {
            //string originaltext = "AAAABBBCCDAA";
            string originaltext = "abcd";
            originaltext = originaltext.ToLower();
            StringBuilder encodedText = new StringBuilder();
            encodedText.Clear();

            int duplength = 0;
            int count ;
            do
            {
                count = 0;
                char temp = originaltext[duplength];
                duplength++;
                count++;
                while (true)
                {
                    try
                    {
                        if (duplength < originaltext.Length && temp == originaltext[duplength])
                        {
                            count++;
                            duplength++;
                        }
                        else
                        {
                            encodedText.Append(count.ToString());
                            encodedText.Append(temp);
                            break;
                        }
                    }
                    catch (Exception e) { 
                    
                        Console.WriteLine(e.Message);
                        break;
                    }
                   
                }
            } while (duplength <= originaltext.Length - 1);
            


            Console.Write($"Original Text::: {originaltext} \t");
            Console.WriteLine($"Encoded Text::: {encodedText}");

            Console.Read();
        }
    }
}
