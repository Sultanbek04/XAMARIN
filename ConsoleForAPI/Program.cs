using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleForAPI
{
 
  class Program
  {
    public static string str { get; set; }

    static Mutex mutex = new Mutex();
    static void Main(string[] args)
    {
      APIHelper.InitializeClient();

    
         

      Console.ReadKey();
    }
    public static async Task<List<Crypto>> LoadComic(string str)
    {


      string url = $"https://api.nomics.com/v1/currencies/ticker?key=360472c5a5615a51d45542cdeac75f5fb2ca1080&ids={str}&interval=1d,30d&convert=EUR&per-page=100&page=1";



      using (HttpResponseMessage response = await APIHelper.APIClient.GetAsync(url))

        if (response.IsSuccessStatusCode)
        {
          var result = await response.Content.ReadAsAsync<List<Crypto>>();

          return result;
        }
        else
        {
          throw new Exception(response.ReasonPhrase);

        }

    }
    public static void Repater()
    {
    
      while (true)
      {
        try
        {

          var result = LoadComic("BTC");
          Console.WriteLine(result.Result[0].price);
         
      

        }
        catch (Exception ex)
        {
          continue;
        }
      }
    }

  }
}