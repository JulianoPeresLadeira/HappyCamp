using HappyCamp.DataAccess.Context;
using Microsoft.EntityFrameworkCore;
using System;

namespace HappyCamp.Sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new SQLServerContext();
            context.Database.Migrate();
            Console.WriteLine("Hello World!");
        }
    }
}
