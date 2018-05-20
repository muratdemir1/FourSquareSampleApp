using FoursquareSampleApp.Business;
using FoursquareSampleApp.Business.GetVenuesDetails;
using FoursquareSampleApp.Business.GetVenuesList;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Xml.Linq;

namespace FoursquareSampleApp
{
    // NOT: "Service1" sınıf adını kodda, svc'de ve yapılandırma dosyasında birlikte değiştirmek için "Yeniden Düzenle" menüsündeki "Yeniden Adlandır" komutunu kullanabilirsiniz.
    // NOT: Bu hizmeti test etmek üzere WCF Test İstemcisi'ni başlatmak için lütfen Çözüm Gezgini'nde Service1.svc'yi veya Service1.svc.cs'yi seçin ve hata ayıklamaya başlayın.
    public class Service1 : IService1
    {
        public string GetVenues(string venuestype, string areanear = null, string areall = null)
        {
            if (String.IsNullOrEmpty(venuestype) || venuestype.Length < 3)
                throw new Exception("Request Error.Venues type is error.");

            string url = ConfigurationManager.AppSettings["GetVenuesUrl"];
            string clientid = ConfigurationManager.AppSettings["ClientId"];
            string clientsecret = ConfigurationManager.AppSettings["ClientSecret"];

            string parameters = @"?[areatype]=[near]&client_id=[client_id]&client_secret=[client_secret]&v=[date]&query=[query]";

            if (String.IsNullOrEmpty(areanear))
                if (String.IsNullOrEmpty(areall))
                    throw new Exception("Request Error.Venues type is error.");
                else
                {
                    parameters = parameters.Replace("[areatype]", "ll");
                    parameters = parameters.Replace("[near]", areall);
                }
            else
            {
                parameters = parameters.Replace("[areatype]", "near");
                parameters = parameters.Replace("[near]", areanear);
            }

            parameters = parameters.Replace("[client_id]", clientid);
            parameters = parameters.Replace("[client_secret]", clientsecret);
            parameters = parameters.Replace("[date]", DateTime.Now.ToString("yyyyMMdd"));
            parameters = parameters.Replace("[query]", venuestype);

            url += parameters;

            string html = FoursquareApiOperation.CallFourSquareApi(url);


#warning Burada Json Serialize edilemiyor zaman olmadığından daha fazla inceleyemedim.
            Business.GetVenuesList.Response account = JsonConvert.DeserializeObject<Business.GetVenuesList.Response>(html);


            XElement xml = new XElement("venues");
            if (account.venues != null)
            {
                xml = new XElement("venues",
                account.venues.Select(i => new XElement("name",
                    null,
                    i.name
                )));
            }
            return xml.ToString();
        }


        public string GetVenueDetails(string venueid)
        {
            if (String.IsNullOrEmpty(venueid))
                throw new Exception("Request Error.Venue id is error.");
            
            string url = ConfigurationManager.AppSettings["GetVenueDetailsUrl"];
            string clientid = ConfigurationManager.AppSettings["ClientId"];// "VSXIJTTIL3NUA0ZHCG1PZI35EZPOIQVKFXM3M1ZSAMT2RKDD";
            string clientsecret = ConfigurationManager.AppSettings["ClientSecret"]; //"DZ2VUKTV1LSAV5F40NF4CIPBAUH1VH4UYAJ1QMRXQI2444TW";
            string parameters = @"?client_id=[client_id]&client_secret=[client_secret]&v=[date]";

            url += venueid;
            parameters = parameters.Replace("[client_id]", clientid);
            parameters = parameters.Replace("[client_secret]", clientsecret);
            parameters = parameters.Replace("[date]", DateTime.Now.ToString("yyyyMMdd"));

            url += parameters;

            string html = FoursquareApiOperation.CallFourSquareApi(url);

#warning Burada Json Serialize edilemiyor zaman olmadığından daha fazla inceleyemedim.
            Business.GetVenuesDetails.Response account = JsonConvert.DeserializeObject<Business.GetVenuesDetails.Response>(html);

            account.venue = new Business.GetVenuesDetails.Venue
            {
                name = "Deneme1"
            };


            XElement xml = new XElement("venues");
            if (account.venue != null)
            {
                xml = new XElement("venue", new XElement("name",
                    null,
                    account.venue.name
                ));
            }
            return xml.ToString();
        }

    }
}
