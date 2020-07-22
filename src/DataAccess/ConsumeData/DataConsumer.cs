using System;
using System.IO;
using System.Net.Http;
using System.Xml;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace DataAccess.ConsumeData
{
    public class DataConsumer
    {
        public static void TestJson()
        {
            using (HttpClient client = new HttpClient())
            {
                var stringAsync = client.GetStringAsync("http://api.nbp.pl/api/exchangerates/rates/a/gbp/last/10/?format=json").Result;
                var deserializeObject = JsonConvert.DeserializeObject<ExchangeRates>(stringAsync);
                Console.WriteLine(deserializeObject);
            }
        }

        public static void TestXml()
        {
            using (HttpClient client = new HttpClient())
            {
                var stringAsync = client.GetStringAsync("http://api.nbp.pl/api/exchangerates/rates/c/usd/last/10/?format=xml").Result;

                using (StringReader stringReader = new StringReader(stringAsync))
                {
                    XmlTextReader reader = new XmlTextReader(stringReader);

                    while (reader.Read())
                    {
                        var description = $"{reader.NodeType.ToString()}, {reader.Name}, {reader.Value}";
                        Console.WriteLine(description);
                    }

                    var exchangeRatesSeries = DeserializeFromXml<Xml.ExchangeRatesSeries>(stringAsync);
                }
            }
        }

        public static T DeserializeFromXml<T>(string xml)
        {
            T result;
            XmlSerializer ser = new XmlSerializer(typeof(T));
            using (TextReader tr = new StringReader(xml))
            {
                result = (T)ser.Deserialize(tr);
            }
            return result;
        }
    }
}