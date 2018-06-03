using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace csharp72
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            await getHeaders(args[0]);
        }

        static private async Task getHeaders(string url)
        {
            WebResponse response = await WebRequest
                .Create(url)
                .GetResponseAsync()
                .ConfigureAwait(false);
            Console.WriteLine(response.Headers.ToString());
        }
    }
}
