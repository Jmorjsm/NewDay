using System;
using System.CommandLine;
using System.CommandLine.Invocation;
using System.IO;

namespace Todo
{
    class Program
    {
        static int Main(string[] args)
        {
            var rootCommand = new RootCommand
            {
                new Command("init", "creates a new todo list")
                {
                    Handler = CommandHandler.Create<int>((intOption) =>
                    {
                        Console.WriteLine("Init command:");
                    }),
                },
                new Command("new-day", "moves ongoing tasks to a new todo list for to day")
                {
                    Handler = CommandHandler.Create<int>((intOption) =>
                    {
                        Console.WriteLine("New-day command:");
                    }),
                },
                new Command("view",	"views the todo list")
                {
                    Handler = CommandHandler.Create<int>((intOption) =>
                    {
                        Console.WriteLine("View command:");
                    }),
                },
                new Command("review", "steps through viewing each task")
                {
                    Handler = CommandHandler.Create<int>((intOption) =>
                    {
                        Console.WriteLine("Review command:");
                    }),
                },
            };

            rootCommand.Description = "Todo";

            // Parse the incoming args and invoke the handler
            return rootCommand.InvokeAsync(args).Result;
        }
    }
}
