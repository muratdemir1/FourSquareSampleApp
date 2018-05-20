using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;

namespace FoursquareSampleApp.Business
{
    public class FoursquareApiOperation
    {
        public static string CallFourSquareApi(string url)
        {
            try
            {
                string html = string.Empty;
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.AutomaticDecompression = DecompressionMethods.GZip;

                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                using (Stream stream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(stream))
                {
                    html = reader.ReadToEnd();
                }

                return html;
            }
            catch(Exception Ex)
            {
                Console.WriteLine(Ex.Message);
                return "System Error.";
            }
        }
    }
}