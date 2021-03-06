// See https://aka.ms/new-console-template for more information
using INQ.Logger.Application;
using INQ.Logger.Serilog;
using Microsoft.Extensions.Configuration;
using Serilog;

namespace Logger.Console
{
    public class Program
    {
     
        static void Main(string[] args)
        {
            try
            {
                ProcessLogger.LogProcesses();
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }
        }
    }
}
