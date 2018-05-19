using System;
using System.Text;


namespace RunLengthEncoding
{
    class Program
    {
        static void Main(string[] args)
        {
            #region textdata
            //string originaltext = "AAAABBBCCDAA";
            //string originaltext = "OliverQueen";
            //string originaltext = "ARrow";
            //string originaltext = "abB  cCdD";
            //string originaltext = "aabcddeeEEeAAABBB";

            string originaltext = "AAAABBBCCDAA";
            #endregion

            #region User Input
            //Console.Write("Enter the text for Run Length Encoding::: ");
            //string originaltext = Console.ReadLine();

            #endregion

            Console.WriteLine($"Original Text::: {originaltext} \t");
            //changing to lowercase all the letter in string
            originaltext = originaltext.ToLower();
            //removing space if any
            originaltext = originaltext.Replace(" ", "");



            #region Variables needed
            StringBuilder encodedText = new StringBuilder();
            encodedText.Clear();
            int duplength = 0;
            int count ;
            #endregion

            //finding the runlength
            do
            {
                count = 0;
                char temp = originaltext[duplength];
                duplength++;
                count++;
                while (true)
                {

                    if (duplength < originaltext.Length && temp == originaltext[duplength])
                    {
                        count++;
                        duplength++;
                    }
                    else
                    {
                        encodedText.Append(count.ToString());
                        encodedText.Append(temp.ToString().ToUpper());                        
                        break;
                    }
                    
                }
            } while (duplength <= originaltext.Length - 1);
            


            //Display final Answer
            Console.WriteLine($"Encoded Text::: {encodedText}");
            Console.Read();
        }
    }
}
