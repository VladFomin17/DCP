using solid5;
using System;

class Program
{
    static void Main(string[] args)
    {
        ILogger logger = new ConsoleLogger();
        MyService service = new MyService(logger);

        service.DoWork();
    }
}