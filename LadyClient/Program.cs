using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LadyClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new LadyClient.BordelServiceClient("BasicHttpBinding IbordelApp");
            var ladies = client.GetLadies();
            foreach (var lady in ladies)
            {
                Console.WriteLine("Name: {0}\tAge: {1)", lady.Name, lady.Age);
            }
        }
    }
}