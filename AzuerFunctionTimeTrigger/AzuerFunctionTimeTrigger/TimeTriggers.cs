using System;
using System.IO;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;

namespace AzuerFunctionTimeTrigger
{
    public static class TimeTriggers
    {
        [FunctionName("TimeTriggers")]
        public static void Run([TimerTrigger("0/10 * * * * *")]TimerInfo myTimer, TraceWriter log)
        {
            log.Info($"C# Timer trigger function executed at: {DateTime.Now}");

            var guid = Guid.NewGuid();

            Console.WriteLine(guid);

           // string path = $@"C:\Users\KOKU-DEV\Desktop\Test\MyTest-{guid}.txt";

           // if (!File.Exists(path))
           // {
           //     // Create a file to write to.
           //     for (int i = 0; i < 10000; i++)
           //     {
           //         using (StreamWriter sw = new StreamWriter(path, true))
           //         {
           //             sw.WriteLine($"Hello : {i} " + DateTime.Now);
           //         }
           //     }
           // }
        }
    }
}
