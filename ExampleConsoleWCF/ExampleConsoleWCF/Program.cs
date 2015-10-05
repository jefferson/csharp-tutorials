using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nito.AsyncEx; 
using Simple.OData.Client;

namespace ExampleConsoleWCFClient

{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                 AsyncContext.Run(() => MainAsync(args));
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex);
            }
            
        }

        // Async method to call Remote WCF Service
        static async Task<int> MainAsync(string[] args) {
            var annotations = new ODataFeedAnnotations();
            // define uri WCF service to connect to
            var client = new ODataClient("http://services.odata.org/V4/TripPinServiceRW/");
            var x = ODataDynamic.Expression;
            var duration = TimeSpan.FromHours(4);
            // LINQ Query
            var flights = await client
                .For(x.People)
                .Filter(x.Trips
                .All(x.PlanItems
                    .Any(x.Duration < duration))
                    )
                .FindEntriesAsync();

            foreach (var entry in flights) {
                Console.WriteLine(String.Format("Person [ UserName: {0} FirstName: {1} LastName: {2} Emails: {3} Gender: {4} ]", entry.UserName, entry.FirstName, entry.LastName, entry.Emails[0], entry.Gender));
            }

            Console.WriteLine("--- WCF Client ODATA Query Execution Completed. Press ENTER to exit. ---");
            Console.ReadKey();
            return 1;
        }
    }
}
