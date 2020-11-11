using System;
using System.IO;
using System.Net;

namespace GetStockData
{
    class StockDataMain
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string testURL = "http://download.finance.yahoo.com/d/quotes.csv?s=MCI+DIS+COKE+PEP&f=sl1d1t1c1";

            StockDataUtils WebResponse = new StockDataUtils();
            string response = WebResponse.GetWebResponse(testURL);



            Console.WriteLine("=)");
        }
    }

    class StockDataUtils
    {
        // Get a Web Response
        public string GetWebResponse(string url)
        {
            // Make a Web Client
            WebClient Client = new WebClient();

            // Get the needed URL
            Stream Response = Client.OpenRead(url);

            // Read the result
            using (StreamReader Reader = new StreamReader(Response))
            {
                // Get the Result
                string result = Reader.ReadToEnd();

                // Close the Stream Reader
                Reader.Close();

                // Return the result
                return result;
            }
        }
    }
}
