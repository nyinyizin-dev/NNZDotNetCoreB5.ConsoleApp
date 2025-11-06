// See https://aka.ms/new-console-template for more information
using NNZDotNetCoreB5.ConsoleApp;

Console.WriteLine("Hello, World!");
Console.ReadLine();

AdoBlogService adoBlogService = new AdoBlogService();
//adoBlogService.Read();
//adoBlogService.Create();
//adoBlogService.Update();
adoBlogService.Delete();
