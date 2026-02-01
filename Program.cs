using RestSharp;

namespace TomorrowIoConsoleApp
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello, Tomorrow IO!");

            var key = "2C2qeEqsZDz33Tfm6mVb6w3rPA10qdDi";

            // City name location=new york
            //var options = new RestClientOptions($"https://api.tomorrow.io/v4/weather/forecast?location=new%20york&apikey={key}");

            // City name location=toronto
            //var options = new RestClientOptions($"https://api.tomorrow.io/v4/weather/realtime?location=toronto&apikey={key}");

            // Latitude and Longitude (Decimal degree) 
            //var options = new RestClientOptions($"https://api.tomorrow.io/v4/weather/realtime?location=52.0,5.2&apikey={key}");

            //var options = new RestClientOptions($"https://api.tomorrow.io/v4/weather/history/recent?location=52.0,5.2&apikey={key}");
            //var options = new RestClientOptions($"https://api.tomorrow.io/v4/weather/history/recent?location=52.0,5.2&apikey={key}&timesteps=1h&timesteps=1d&units=metric");
            var options = new RestClientOptions($"https://api.tomorrow.io/v4/weather/history/recent?location=32.16134029123959,-49.228548806929815&apikey={key}&timesteps=1h&timesteps=1d&units=metric");

            var client = new RestClient(options);
            var request = new RestRequest("");
            request.AddHeader("accept-encoding", "deflate, gzip, br");
            request.AddHeader("accept", "application/json");
            var response = await client.GetAsync(request);

            Console.WriteLine("{0}", response.Content);
        }
    }
}
