using System;
using RestSharp;
using RestSharp.Authenticators;
using System.Xml;

namespace program
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new RestClient("https://bionic-reading1.p.rapidapi.com/convert");
            var request = new RestRequest(Method.POST);
            request.AddHeader("content-type", "application/x-www-form-urlencoded");
            request.AddHeader("X-RapidAPI-Host", "bionic-reading1.p.rapidapi.com");
            request.AddHeader("X-RapidAPI-Key", "api");
            request.AddParameter("application/x-www-form-urlencoded", "content=Lorem%20ipsum%20dolor%20sit%20amet%2C%20consetetur%20sadipscing%20elitr%2C%20sed%20diam%20nonumy%20eirmod%20tempor%20invidunt%20ut%20labore%20et%20dolore%20magna%20aliquyam%20erat%2C%20sed%20diam%20voluptua.%20At%20vero%20eos%20et%20accusam%20et%20justo%20duo%20dolores%20et%20ea%20rebum.%20Stet%20clita%20kasd%20gubergren%2C%20no%20sea%20takimata%20sanctus%20est%20Lorem%20ipsum%20dolor%20sit%20amet.%20Lorem%20ipsum%20dolor%20sit%20amet%2C%20consetetur%20sadipscing%20elitr%2C%20sed%20diam%20nonumy%20eirmod%20tempor%20invidunt%20ut%20labore%20et%20dolore%20magna%20aliquyam%20erat%2C%20sed%20diam%20voluptua.%20At%20vero%20eos%20et%20accusam%20et%20justo%20duo%20dolores%20et%20ea%20rebum.%20Stet%20clita%20kasd%20gubergren%2C%20no%20sea%20takimata%20sanctus%20est%20Lorem%20ipsum%20dolor%20sit%20amet.&response_type=html&request_type=html&fixation=1&saccade=10", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content.ToString());
        }
    }
}
