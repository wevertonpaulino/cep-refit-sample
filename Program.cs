﻿using Refit;
using System;
using System.Threading.Tasks;

namespace CepRefitSample
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var client = RestService.For<ICepService>("https://ws.apicep.com/");

            Console.WriteLine("Enter the zip code...");
            var cep = Console.ReadLine();
            
            Console.WriteLine($"\nSearching for information about the zip code: {cep}...");
            var response = await client.GetAsync(cep);

            Console.WriteLine($"\nStatus: {response.Status}" +
                              $"\nCode: {response.Code}" +
                              $"\nState: {response.State}" +
                              $"\nCity: {response.City}" +
                              $"\nDistrict: {response.District}" +
                              $"\nAddress: {response.Address}");

            Console.ReadKey();
        }
    }
}
