using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace API_Xamarin
{
  class CommicProcessor
  {
    public static async Task<string> LoadComic()
    {



      string url = $"https://dex.binance.org/api/v1/time";


      using (HttpResponseMessage response = await APIHelper.APIClient.GetAsync(url))
      {
        if (response.IsSuccessStatusCode)
        {
          string result = await response.Content.ReadAsStringAsync();

          return result;
        }
        else
        {
          throw new Exception(response.ReasonPhrase);
        }
      }
    }
  }
}

