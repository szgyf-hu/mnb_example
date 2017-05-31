using mnb.hu.mnb.www;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace mnb
{
    class Program
    {
        static void Main(string[] args)
        {
            using (hu.mnb.www.MNBArfolyamServiceSoapImpl c = new hu.mnb.www.MNBArfolyamServiceSoapImpl()) {
              //  c.Timeout = 1000;

                /*MNB.GetCurrenciesResponseBody rb= c.GetCurrencies(new MNB.GetCurrenciesRequestBody());
                Console.WriteLine(rb.GetCurrenciesResult);


                MNB.GetCurrentExchangeRatesResponseBody xrb = c.GetCurrentExchangeRates(new MNB.GetCurrentExchangeRatesRequestBody());
                Console.WriteLine(xrb.GetCurrentExchangeRatesResult);

                MNB.GetInfoResponseBody gir = c.GetInfo(new MNB.GetInfoRequestBody());

                Console.WriteLine(gir.GetInfoResult);*/
                String resp=c.GetCurrentExchangeRates(new hu.mnb.www.GetCurrentExchangeRatesRequestBody()).GetCurrentExchangeRatesResult;

                Console.WriteLine(resp);

                XmlDocument xmlDoc = new XmlDocument();

                //<MNBCurrentExchangeRates><Day date=\"2017-05-02\"><Rate unit=\"1\" curr=\"AUD\">215,43000</Rate>
                xmlDoc.LoadXml(resp);
                XmlNodeList xnl = xmlDoc.SelectNodes("//Rate[@curr='EUR']");
                if (xnl.Count>0)
                    Console.WriteLine(Double.Parse(xnl[0].InnerText));
            }
            Console.ReadKey();
        }
    }
}
