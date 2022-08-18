using System;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Collections.Generic;
using static System.Net.WebRequestMethods;
using System.Linq;
using System.Net.Http;

namespace ConsoleApp1
{
    internal class Program
    { 
        // HttpClient is instantiated
        // Http Client provides a base class for sending HTTP request and receiving HTTP responses from URI
        // It should be instantiated once per applicaiton
        
        static readonly HttpClient client = new HttpClient();
        static async Task Main()
        {
            // Declaration URLs that the application plans to process 
           
            string urlA = "https://docs.microsoft.com/en-us/aspnet/signalr/";
            string urlB = "https://docs.microsoft.com/en-us/aspnet/web-api/";
            string urlC = "https://docs.microsoft.com/en-us/aspnet/mobile/tested-devices";

            // I wanted to calucate execution time for an aplication, so I used Stopwatch

            var stopwatch = Stopwatch.StartNew();

            // Start all downloads concurrently

            Task<HttpResponseMessage> downloadTaskA = client.GetAsync(urlA);
            Task<HttpResponseMessage> downloadTaskB = client.GetAsync(urlB);
            Task<HttpResponseMessage> downloadTaskC = client.GetAsync(urlC);

            // Wait for either of the tasks to complete

            Task<HttpResponseMessage> completedTask = await Task.WhenAny(downloadTaskA, downloadTaskB, downloadTaskC);

            // Return response message including the status code and data from that URL

            HttpResponseMessage data = await completedTask;

            // Converted data to HTML

            string responseBody = await data.Content.ReadAsStringAsync();
           
            
            // Stopwatch stop method

            stopwatch.Stop();

            // Print execution time, response message and HTML from URL 

            Console.WriteLine($"Elapsed Time: {stopwatch.Elapsed}");
            Console.WriteLine(data);
            Console.WriteLine(responseBody);

        }



    }
}
