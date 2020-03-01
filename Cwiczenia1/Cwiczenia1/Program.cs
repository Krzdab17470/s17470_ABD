using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Cwiczenia1
{
    public class Program
    {
        public static async Task Main(string[] args)
        {

            var client = new HttpClient();
            HttpResponseMessage result = await client.GetAsync("https://www.pja.edu.pl"); //dodajemy "await. Potrzebne zeby program poczekal na zaladowanie stron www. W przeciwnym razie ta linia nie wykona sie. Dodalismy tez w linii klasy slowa async i Task".

            if(result.IsSuccessStatusCode)
            {
                string html = await result.Content.ReadAsStringAsync();
            }
            
            Console.WriteLine("Koniec!");
        }
    }
}
