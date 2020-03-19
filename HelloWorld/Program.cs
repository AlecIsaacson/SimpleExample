using System;
//using NewRelic.LogEnrichers.NLog;

namespace HelloWorld
{
    class Program
    {
        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();
     
        static void Main(string[] args)
        {
            //var loggingConfig = new NLog.Config.LoggingConfiguration();

            //var logfile = new NLog.Targets.FileTarget("logfile") { FileName = "NRLog.json" };
            //var logconsole = new NLog.Targets.ConsoleTarget("logconsole");

            //logfile.Layout = new NewRelicCsvLayout() { Delimiter = NLog.Layouts.CsvColumnDelimiterMode.Pipe };
            
            //loggingConfig.AddRule(NLog.LogLevel.Info, NLog.LogLevel.Fatal, logconsole);
            //loggingConfig.AddRule(NLog.LogLevel.Debug, NLog.LogLevel.Fatal, logfile);

            //NLog.LogManager.Configuration = loggingConfig;

            Console.WriteLine("Hello World!");
            Logger.Info("I'm a log message");
            Logger.Debug("I'm a debug message");
        }
    }
}
