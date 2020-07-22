using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace DataAccess.ConsumeData
{
    public class Xml
    {
        [Serializable, XmlType("Rate")]
        public class Rate
        {
            [XmlElement(ElementName = "No")]
            public string No { get; set; }
            [XmlElement(ElementName = "EffectiveDate")]
            public string EffectiveDate { get; set; }
            [XmlElement(ElementName = "Bid")]
            public string Bid { get; set; }
            [XmlElement(ElementName = "Ask")]
            public string Ask { get; set; }
        }

        [Serializable, XmlType("Rates")]
        public class Rates
        {
            [XmlElement(ElementName = "Rate")]
            public List<Rate> Rate { get; set; }
        }

        [Serializable, XmlType("ExchangeRatesSeries")]
        public class ExchangeRatesSeries
        {
            [XmlElement(ElementName = "Table")]
            public string Table { get; set; }
            [XmlElement(ElementName = "Currency")]
            public string Currency { get; set; }
            [XmlElement(ElementName = "Code")]
            public string Code { get; set; }
            [XmlElement(ElementName = "Rates")]
            public Rates Rates { get; set; }
            [XmlAttribute(AttributeName = "xsd", Namespace = "http://www.w3.org/2000/xmlns/")]
            public string Xsd { get; set; }
            [XmlAttribute(AttributeName = "xsi", Namespace = "http://www.w3.org/2000/xmlns/")]
            public string Xsi { get; set; }
        }
    }
}