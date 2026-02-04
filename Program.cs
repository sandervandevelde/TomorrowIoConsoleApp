using RestSharp;

namespace TomorrowIoConsoleApp
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello, Tomorrow IO!");

            var key = "Generated API KEY";

            // City name location=new york
            //var options = new RestClientOptions($"https://api.tomorrow.io/v4/weather/forecast?location=new%20york");

            // City name location=toronto
            //var options = new RestClientOptions($"https://api.tomorrow.io/v4/weather/realtime?location=toronto");

            // Latitude and Longitude (Decimal degree) 
            //var options = new RestClientOptions($"https://api.tomorrow.io/v4/weather/realtime?location=52.0,5.2");

            //var options = new RestClientOptions($"https://api.tomorrow.io/v4/weather/history/recent?location=52.0,5.2");
            //var options = new RestClientOptions($"https://api.tomorrow.io/v4/weather/history/recent?location=52.0,5.2&timesteps=1h&timesteps=1d&units=metric");
            var options = new RestClientOptions($"https://api.tomorrow.io/v4/weather/history/recent?location=32.16134029123959,-49.228548806929815&timesteps=1h&timesteps=1d&units=metric");

            var client = new RestClient(options);
            var request = new RestRequest("");
            request.AddHeader("accept-encoding", "deflate, gzip, br");
            request.AddHeader("accept", "application/json");
            request.AddHeader("apikey", key);
            var response = await client.GetAsync(request);

            Console.WriteLine("{0}", response.Content);
        }
    }
}
