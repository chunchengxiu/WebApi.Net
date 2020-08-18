using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;

namespace ConsoleAppTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Host.CreateDefaultBuilder()
                .ConfigureWebHostDefaults(webHostBuilder => webHostBuilder                    
                    .Configure( app => app
                        .Run(context => context.Response.WriteAsync("Hello World!")))) 
                .Build()
                .Run();
            //Console.WriteLine("Hello World!");

        }
    }
}
